using MongoDB.Driver;
using MongoDB.Bson;
using System.Collections.Generic;

namespace miapp2.Models
{
    public class ProductoDAL
    {
        private readonly IMongoDatabase _database;
        public ProductoDAL()
        {
            _database = Conectar();
        }

        public IEnumerable<Producto> Todos()
        {
            var productos = _database.GetCollection<Producto>("productos")
                .Find(new BsonDocument()).ToListAsync();
            return productos.Result;
        }

        private IMongoDatabase Conectar()
        {
            var cliente = new MongoClient("mongodb://localhost:27017");
            var database = cliente.GetDatabase("productos");
            return database;
        }
    }
}