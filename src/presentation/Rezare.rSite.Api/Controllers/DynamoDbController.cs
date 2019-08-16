using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rezare.rSite.Api.Models;
using Rezare.rSite.Application.Interfaces;
using Rezare.rSite.Domain.ValueObjects;
using Rezare.rSite.Persistence.DynamoDb;

namespace Rezare.rSite.Api.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/dynamo-db")]
    [ApiController]
    public class DynamoDbController : ControllerBase
    {
        private readonly ICreateTable _createTable;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="createTable"></param>
        public DynamoDbController(ICreateTable createTable)
        {
            _createTable = createTable;
        }

        /// <summary>
        /// Creates table.
        /// </summary>
        /// <returns></returns>
        [Route("createtable")]
        public IActionResult CreateTable()
        {
             _createTable.Create();
            return Ok();
        }
    }
}
