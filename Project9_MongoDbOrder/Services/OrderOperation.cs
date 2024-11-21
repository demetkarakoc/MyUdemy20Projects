using MongoDB.Bson;
using MongoDB.Driver;
using Project9_MongoDbOrder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project9_MongoDbOrder.Services
{
    public class OrderOperation
    {
        public void AddOrder(Order order)

        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollections();

            var document = new BsonDocument
            {
                {"CustomerName", order.CustomerName },
                {"City", order.City },
                {"District", order.District },
                {"TotalPrice", order.TotalPrice }

            };

            orderCollection.InsertOne(document);

        }

        public List<Order> GetAllOrders()
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollections();

            var orders = orderCollection.Find(new BsonDocument()).ToList();

            List<Order> ordersList = new List<Order>();
            foreach (var order in orders)
            {
                ordersList.Add(new Order
                {
                    City = order["City"].ToString(),
                    CustomerName = order["CustomerName"].ToString(),
                    District = order["District"].ToString(),
                    TotalPrice = decimal.Parse(order["TotalPrice"].ToString()),
                    OrderId = order["_id"].ToString()
                }) ;

            }

            return ordersList;
        }

        public void DeleteOrder(string orderId)
        {
            var connection=new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollections();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse( orderId));
            orderCollection.DeleteOne(filter);
        }

        public void UpdateOrder(Order order)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollections();
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(order.OrderId));
            var updatedValue = Builders<BsonDocument>.Update
                .Set("CustomerName", order.CustomerName)
                .Set("District", order.District)
                .Set("TotalPrice", order.TotalPrice)
                .Set("City", order.City);

            orderCollection.UpdateOne(filter, updatedValue);
        }


        public Order GetOrderById (string orderId)
        {
            var connection = new MongoDbConnection();
            var orderCollection = connection.GetOrdersCollections();

            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse( orderId));
            var result = orderCollection.Find(filter).FirstOrDefault();
            
            if(result != null)
            {
                return new Order
                {
                    City = result["City"].ToString(),
                    CustomerName = result["CustomerName"].ToString(),
                    District = result["District"].ToString(),
                    OrderId = orderId,
                    TotalPrice = decimal.Parse(result["TotalPrice"].ToString())
                };
            }
            else
            {
                return null;
            }
        }

    }
}
