using c_ApiLayout.Utilities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;

namespace c_ApiLayout.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class apiLayoutController : ControllerBase
    {
        private readonly IMongoCollection<BsonDocument> _testCollection;
        private readonly IConfiguration _configuration;

        public apiLayoutController(IConfiguration configuration, IMongoClient mongoClient)
        {
            _configuration = configuration;

            var client = mongoClient;
            var userDatabase = client.GetDatabase("TicketSystems");
            _testCollection = userDatabase.GetCollection<BsonDocument>("Tickets");
        }

        [HttpPost("testDtoEndpoint")]
        public IActionResult dtoEndpoint([FromBody] UserDto userForm)
        {
            int ticket = 0;
            string name = userForm.name;
            string email = userForm.email;
            int ticketNum = ticket++;
            Log.LogEvent(_testCollection, email, name, ticketNum);
            return Ok(email);
        }
    }
}