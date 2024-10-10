using System.Data.SqlClient;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        private protected const string StringConnectionString = @"Server =.\sqlexpress;Database=Northwind;TrustServerCertificate=true
                                                                ;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnConnection_Click(object sender, EventArgs e)
        {
            using SqlConnection conex = new(StringConnectionString);
            conex.Open();
            MessageBox.Show("Se abrio la conexion con el servidor SQL Server y se selecciono la base de datos");
            conex.Close();
            MessageBox.Show("se cerro la conexion");

        }

        private void BtnDesplegar_Click(object sender, EventArgs e)
        {
            using (var SqlConex = new SqlConnection(StringConnectionString)) { 
            
                SqlConex.Open();
                const string SqlExecute = "SELECT *FROM dbo.Products;";

                SqlCommand cmd = new SqlCommand(SqlExecute,SqlConex);

                SqlDataReader reader = cmd.ExecuteReader();

                lb_container.Items.Clear();

                while (reader.Read()) {

                    lb_container.Items.Add(reader["ProductName"].ToString());
                 
                }
                reader.Close();
                SqlConex.Close();
                 
            }



        }
    }
}
