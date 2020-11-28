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
    public class ProductTypesController : ApiController
    {
        // GET: api/ProductTypes
        public IEnumerable<ProductTypes> Get()
        {
            string sql = "SELECT * FROM ProductTypes";

            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                var productType = connection.Query<ProductTypes>(sql).ToList();
                return productType;
            }
        }

        // GET: api/ProductTypes/5
        public IHttpActionResult Get(int id)
        {
            string sql = "SELECT * FROM ProductTypes WHERE id = @productTypesID;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                var productType = connection.QuerySingleOrDefault<ProductTypes>(sql, new { productTypesID = id });

                if (productType == null)
                {
                    return NotFound();
                }
                return Ok(productType);
            }
        }

        // CREATE: api/ProductTypes
        public bool Create(string type)
        {
            string sql = "INSERT INTO ProductTypes (type)" +
                " VALUES (@type)";
            if (type != null && type != "")
            {
                string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
                using (var connection = new SqlConnection(connStr))
                {
                    var productTypes = connection.Query(sql, new
                    {
                        type = type,
                    });
                }
                return true;
            }
            return false;
        }

        // POST: api/ProductTypes
        public void Post([FromBody]string value)
        {
        }

        // DELETE: api/ProductTypes/5
        public void Delete(int id)
        {
            string sql = "DELETE * FROM ProductTypes WHERE id = @productTypesID;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                connection.Query(sql, new { productTypesID = id });
            }
        }
    }
}
