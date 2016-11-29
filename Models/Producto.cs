using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace miapp2.Models 
{
    public class Producto
    {
        [BsonId]
        public ObjectId id { get; set; }
        [BsonElement("nombre")]
        public string Nombre { get; set; }
        [BsonElement("precio")]
        public int Precio { get; set; }
        [BsonElement("cantidad")]
        public int Cantidad { get; set; }
    }
}