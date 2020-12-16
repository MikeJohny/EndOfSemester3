using System.Collections.Generic;
using RestSharp;
using WebClient1000.Models;

namespace WebClient1000
{
    public class RestSharpCaller
    {
        public RestClient client;
        public RestSharpCaller(string baseUrl)
        {
            client = new RestClient(baseUrl);
        }
        public List<Products> GetProducts()
        {
            var request = new RestRequest("Products", Method.GET);
            var response = client.Execute<List<Products>>(request);
            return response.Data;
        }
        public List<Products> GetProduct(int id)
        {
            var request = new RestRequest("Products/" + id, Method.GET);
            var response = client.Execute<List<Products>>(request);
            return response.Data;
        }
        public bool CreateProduct(string name, int startingPrice, string location, int productTypes_id)
        {
            var request = new RestRequest("Products?name=" + name + "startingPrice=" + startingPrice + "&location=" + location + "&productTypes_id=" + productTypes_id, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public bool DeleteProducts(int id)
        {
            var request = new RestRequest("Products/" + id, Method.DELETE);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public bool LogIn(string username, string password)
        {
            var request = new RestRequest("Login?userName=" + username + "&password=" + password, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public bool CreateUser(string username, string password, string name, string email, string address)
        {
            var request = new RestRequest("Login?userName=" + username + "&password=" + password + "&name=" + name + "&email=" + email + "&address=" + address, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;

        }
        public List<Users> GetUsers()
        {
            var request = new RestRequest("Users", Method.GET);
            var response = client.Execute<List<Users>>(request);
            return response.Data;
        }
        public List<Users> GetUser(int id)
        {
            var request = new RestRequest("Users/" + id, Method.GET);
            var response = client.Execute<List<Users>>(request);
            return response.Data;
        }
        public bool PostUser(string username)
        {
            var request = new RestRequest("Users?userName=" + username, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public bool DeleteUser(int id)
        {
            var request = new RestRequest("Users?userName=" + id, Method.DELETE);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public List<ProductTypes> GeProductTypes()
        {
            var request = new RestRequest("ProductTypes", Method.GET);
            var response = client.Execute<List<ProductTypes>>(request);
            return response.Data;
        }
        public List<ProductTypes> GetProductType(int id)
        {
            var request = new RestRequest("ProductTypes/" + id, Method.GET);
            var response = client.Execute<List<ProductTypes>>(request);
            return response.Data;
        }
        public bool CreateProductTypes(string productTypes)
        {
            var request = new RestRequest("ProductTypes?type=" + productTypes, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public bool DeleteProductTypes(int id)
        {
            var request = new RestRequest("ProductTypes?type=" + id, Method.DELETE);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public List<Sales> GetSales(int id)
        {
            var request = new RestRequest("Sales/" + id, Method.GET);
            var response = client.Execute<List<Sales>>(request);
            return response.Data;
         }
        public bool CreateSale(int userId,int productId,bool isBid,string description,int currentPrice,int bidHours)
        {
            var request = new RestRequest("Sales?user_id=" +userId+"&products_id="+productId+"&isBid"+isBid+"&description="+description+"&currentPrice="+currentPrice+"&bidHours="+bidHours, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public bool BidSale(int saleId, int userId, int bidValue)
        {
            var request = new RestRequest("Sales/" + saleId+"&users_id="+userId+"&bidValue="+bidValue, Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public bool UpdateSaleName(string name)
        {
            var request = new RestRequest("Sales?name="+name  , Method.POST);
            var response = client.Execute<bool>(request);
            return response.Data;
        }
        public List<Sales> GetSalesBy(string sort)
        {
            var request = new RestRequest("Sales?sortBy=" + sort, Method.POST);
            var response = client.Execute<List<Sales>>(request);
            return response.Data;
        }
        public bool DeleteSale(int id)
        {
            var request = new RestRequest("Sales/" + id, Method.DELETE);
            var response = client.Execute<bool>(request);
            return response.Data;
        }

        //Comming back in 10 minutes
    }
}
