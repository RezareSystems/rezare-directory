using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.Model;
using Rezare.rSite.Application.Interfaces;
using Rezare.rSite.Domain.ValueObjects;

namespace Rezare.rSite.Persistence.DynamoDb
{
    /// <summary>
    /// 
    /// </summary>
    public class LinkRepository : ILinkRepository
    {
        private readonly IAmazonDynamoDB _client;
        private readonly string _tableName = "RSiteLinks";

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="client"></param>
        public LinkRepository(IAmazonDynamoDB client)
        {
            _client = client;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="link"></param>
        public async Task<string> Create(Link link)
        {
            var linkId = Guid.NewGuid();
            Dictionary<string, AttributeValue> attributes = new Dictionary<string, AttributeValue>();
            attributes["Id"] = new AttributeValue { S = linkId.ToString() };
            attributes["Url"] = new AttributeValue { S = link.Uri.ToString() };
            attributes["Name"] = new AttributeValue { S = link.Name };
            attributes["Description"] = new AttributeValue { S = link.Description };
            //attributes["Tag"] = new AttributeValue { S = string.Empty };
            PutItemRequest request = new PutItemRequest
            {
                TableName = _tableName,
                Item = attributes
            };
            await _client.PutItemAsync(request);
            return linkId.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Link>> GetLinks()
        {
            var request = new ScanRequest
            {
                TableName = _tableName
            };
            var response = await _client.ScanAsync(request);
            return response.Items.Select(Map).ToList();
        }

        private Link Map(Dictionary<string, AttributeValue> result)
        { 
            return new Link(new Uri(result["Url"].S), result["Name"].S, result["Description"].S);
        }
    }
}
