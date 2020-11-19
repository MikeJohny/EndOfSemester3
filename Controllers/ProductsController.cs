using Dapper;
using EndOfSemester3.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EndOfSemester3.Controllers
{
    public class ProductsController : ApiController
    {
        // GET: api/Products
        public IEnumerable<Products> Get()
        {
            string sql = "SELECT * FROM Products";

            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                var product = connection.Query<Products>(sql).ToList();
                return product;
            }
        }

        // GET: api/Products/5
        public IHttpActionResult Get(int id)
        {
            string sql = "SELECT * FROM Products WHERE id = @productsID;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                var product = connection.QuerySingleOrDefault<Products>(sql, new { productsID = id });

                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
        }

        // TODO: create object and push to DB 
        // POST: api/Products
        public void Post([FromBody]string value)
        {
            string sql = "INSERT INTO Products name = @name, startingPrice = @startingPrice, location = @location, productTypes_id = @productTypes_id;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                connection.Query(sql, new { });
            }
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
            string sql = "DELETE * FROM Products WHERE id = @productsID;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                connection.Query(sql, new { productsID = id });
            }
        }
    }
}
