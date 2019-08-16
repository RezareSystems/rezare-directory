using System;
using System.Collections.Generic;
using System.Text;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;

namespace Rezare.rSite.Persistence.DynamoDb
{
    /// <summary>
    /// Create table.
    /// </summary>
    public class CreateTable : ICreateTable
    {
        private readonly IAmazonDynamoDB _client;
        private string _tableName = "RSiteLinks";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="client"></param>
        public CreateTable(IAmazonDynamoDB client)
        {
            _client = client;
        }

        /// <summary>
        /// Create.
        /// </summary>
        public async void Create()
        {
            //var client = new AmazonDynamoDBClient();

            Console.WriteLine("Getting list of tables");

            var listTableResponse = await _client.ListTablesAsync();
            List<string> currentTables = listTableResponse.TableNames;
            Console.WriteLine("Number of tables: " + currentTables.Count);
            if (!currentTables.Contains(_tableName))
            {
                var request = new CreateTableRequest
                {
                    TableName = _tableName,
                    AttributeDefinitions = new List<AttributeDefinition>
                    {
                        new AttributeDefinition
                        {
                            AttributeName = "Id",
                            AttributeType = "S"   // "S" = string, "N" = number, and so on.
                        },
                        new AttributeDefinition
                        {
                            AttributeName = "Url",
                            AttributeType = "S"
                        }
                    },
                    KeySchema = new List<KeySchemaElement>
                    {
                        new KeySchemaElement
                        {
                            AttributeName = "Id",
                            KeyType = "HASH" // "HASH" = hash key, "RANGE" = range key.
                        },
                        new KeySchemaElement
                        {
                            AttributeName = "Url",
                            KeyType = "RANGE"
                        }
                    },
                    ProvisionedThroughput = new ProvisionedThroughput
                    {
                        ReadCapacityUnits = 5,
                        WriteCapacityUnits = 5
                    }
                };

                var response = await _client.CreateTableAsync(request);

                Console.WriteLine("Table created with request ID: " + response.ResponseMetadata.RequestId);

                WaitTillTableCreation();
           }
        }

        /// <summary>
        /// 
        /// </summary>
        public async void WaitTillTableCreation()
        {
            //var client = new AmazonDynamoDBClient();
            var status = "";
            do
            {
                // Wait 5 seconds before checking (again).
                System.Threading.Thread.Sleep(TimeSpan.FromSeconds(5));
                try
                {
                    var response = await _client.DescribeTableAsync(new DescribeTableRequest
                    {
                        TableName = _tableName
                    });
                    Console.WriteLine("Table = {0}, Status = {1}", response.Table.TableName, response.Table.TableStatus);
                    status = response.Table.TableStatus;
                }
                catch (ResourceNotFoundException)
                {
                    // DescribeTable is eventually consistent. So you might
                    //   get resource not found. 
                }
            } while (status != TableStatus.ACTIVE);
        }
    }
}
