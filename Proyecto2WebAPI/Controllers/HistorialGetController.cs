using Proyecto2WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.Http; 

namespace Proyecto2WebAPI.Controllers
{
    public class HistorialGetController : ApiController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("api/historial")]
        public IHttpActionResult GetHistorial()
        {
            var historialList = new List<Historial>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT id , Operacion, Resultado FROM Historial";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            historialList.Add(new Historial
                            {
                                Id = int.Parse(reader["id"].ToString()),
                                Operacion = reader["Operacion"].ToString(),
                                Resultado = reader["Resultado"].ToString()

                            });
                        }
                    }
                }
            }

            return Ok(historialList);
        }
    }
}