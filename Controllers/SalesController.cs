using Dapper;
using EndOfSemester3.Models;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Http;

namespace EndOfSemester3.Controllers
{
    public class SalesController : ApiController
    {
        // GET: api/Sales
        public IEnumerable<Sales> Get()
        {
            string sql = "SELECT * FROM Sales";

            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                var sale = connection.Query<Sales>(sql).ToList();
                return sale;
            }
        }

        // GET: api/Sales/5
        public IHttpActionResult Get(int id)
        {
            string sql = "SELECT * FROM Sales WHERE id = @salesID;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                var sale = connection.QuerySingleOrDefault<Sales>(sql, new { salesID = id });

                if (sale == null)
                {
                    return NotFound();
                }
                return Ok(sale);
            }
        }

        // CREATE: api/Sales (Take a look at this!)
        public void Create(int users_id, int products_id, bool isBid, string description, int currentPrice)
        {
            string sql = "INSERT INTO Users (users_id, products_id, isBid, description, currentPrice)" +
                " VALUES (@users_id, @products_id, @isBid, @description, @currentPrice)";

            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            using (var connection = new SqlConnection(connStr))
            {
                var Sales = connection.Query(sql, new
                {
                    users_id = users_id,
                    products_id = products_id,
                    isBid = isBid,
                    description = description,
                    currentPrice = currentPrice,
                });
            }
        }

        // POST: api/Sales
        public void Post([FromBody]string value)
        {
        }

        // DELETE: api/Sales/5
        public void Delete(int id)
        {
            string sql = "DELETE * FROM Sales WHERE id = @salesID;";
            string connStr = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;

            using (var connection = new SqlConnection(connStr))
            {
                connection.Query(sql, new { salesID = id });
            }
        }
    }
}
