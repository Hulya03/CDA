using MongoDB.Bson.Serialization.Attributes;

namespace _01_Api_Rest.Models
{
    public class Achat
    {
        [BsonId]

        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }              //par cenvention dans .Net, majuscule aux accesseurs
        public string Nom { get; set; }
        public DateTime Date { get; set; }
        public decimal Montant { get; set; }
        public string CodePostal { get; set; }  
    }
}
