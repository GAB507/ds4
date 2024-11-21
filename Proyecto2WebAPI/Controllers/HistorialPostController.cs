using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Web.Http;
using System.Web.Mvc;
using Proyecto2WebAPI.Models;

namespace Proyecto2WebAPI.Controllers
{
    public class HistorialPostController : ApiController
    {
        private readonly string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("api/POST")]
        public IHttpActionResult PostHistorial([FromBody] Historial historial)
        {
            if (historial == null)
            {
                return BadRequest("No se proporcionaron datos.");
            }

            // Insertar el nuevo historial en la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Consulta SQL para insertar el historial
                    string query = "INSERT INTO Historial (id,Operacion, Resultado) VALUES (@id,@Operacion, @Resultado)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar parámetros para evitar inyecciones SQL 
                        command.Parameters.AddWithValue("@Operacion", historial.Operacion);
                        command.Parameters.AddWithValue("@Resultado", historial.Resultado);

                        // Ejecutar la consulta
                        int rowsAffected = command.ExecuteNonQuery();

                        // Verificar si se insertó correctamente
                        if (rowsAffected > 0)
                        {
                            return Ok("Historial guardado correctamente.");
                        }
                        else
                        {
                            return BadRequest("Hubo un error al guardar el historial.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    return InternalServerError(ex);
                }
            }
        }
    }
}