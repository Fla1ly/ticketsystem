using Microsoft.AspNetCore.Authentication;
using MongoDB.Bson;
using MongoDB.Driver;

namespace c_ApiLayout.Utilities
{
    public class Log
    {
        public static void LogEvent(IMongoCollection<BsonDocument> logCollection, string name, string email, int ticketNum)
        {
            var log = new BsonDocument
         {
             { "name", name },
             { "email", email },
             {"ticket", ticketNum }
         };
            logCollection.InsertOne(log);
        }
    }
}
