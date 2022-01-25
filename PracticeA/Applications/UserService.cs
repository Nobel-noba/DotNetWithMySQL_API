using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using PracticeA.Models;
using System.Collections.Generic;
using System.Linq;

namespace PracticeA.Applications
{
    public class UserService
    {
        private IConfiguration configuration;

        public UserService(IConfiguration _configuration)
        {
            configuration = _configuration;
        }
        public List<Users> GetAllUsers()
        {
            var collection = new MongoClient(configuration.GetConnectionString("mongoConnection")).GetDatabase("PracticeA").GetCollection<Users>("Users");
            var DbList = collection.AsQueryable();
            return DbList.ToList();
        }

        public Users GetUser(int id)
        {
            var collection = new MongoClient(configuration.GetConnectionString("mongoConnection")).GetDatabase("PracticeA").GetCollection<Users>("Users");
            var filter = Builders<Users>.Filter.Eq("userid", id);
            return collection.Find(filter).FirstOrDefault();
        }

        public void SetUsers(Users user)
        {
            var collection = new MongoClient(configuration.GetConnectionString("mongoConnection")).GetDatabase("PracticeA").GetCollection<Users>("Users");
            int LastUSer = collection.AsQueryable().Count();
            user.userid = LastUSer + 1;
            collection.InsertOne(user);
            
        }

        public void UpdateUser(int id,Users user)
        {
            var collection = new MongoClient(configuration.GetConnectionString("mongoConnection")).GetDatabase("PracticeA").GetCollection<Users>("Users");
            var filter = Builders<Users>.Filter.Eq("userid", id);
            var update = Builders<Users>.Update.Set("name", user.name);
            collection.UpdateOne(filter, update);
        }

        public void DeleteUser(int id)
        {
            var collection =new MongoClient(configuration.GetConnectionString("mongoConnection")).GetDatabase("PracticeA").GetCollection<Users>("Users");
            var filter = Builders<Users>.Filter.Eq("userid", id);
            collection.DeleteOne(filter);
        }
    }
}
