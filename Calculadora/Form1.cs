namespace Calculadora
{
    using NCalc;
    using System.Linq;
    using System.Drawing; 
    using System.Windows.Forms;
    using System.Data.SqlClient;
    using System.Text.RegularExpressions;

    public partial class Form1 : Form
    {

        private protected RJboton[] ColectionBtn = new RJboton[10];
        private protected RJboton[] special = new RJboton[2];
        private const string connectionString = "Data Source=DESKTOP-IDC5EG0;Initial Catalog=Calculadora;Integrated Security=True";
        private ListBox listBoxResultados = new ListBox();
        private SqlConnection con;
        double op1, op2;
        string signo = "";
        bool esInfinite = false;
        object result;

        public Form1()
        {
            InitializeComponent();
            initializeBtn();

        }

        private void createPanel()
        {
         
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Size = new Size(313, 464);
            panel2.Location = new Point(7, 7);
            panel2.Name = "PanelSecundario";
            panel2.TabIndex = 1023; 
            this.Controls.Add(panel2);
             
            panel2.Visible = false;
           
        }


        private void initializeBtn()
        {
            createPanel();

            // Agregar el ListBox al Panel ya existente
            // Cambiar la visibilidad del ListBox y los paneles

            // Configurar propiedades del ListBox
            listBoxResultados.Size = new Size(300, 400); // Tamaño del ListBox
            listBoxResultados.Location = new Point(5, 60); // Posición dentro del Panel
            listBoxResultados.BackColor = Color.Wheat;
            listBoxResultados.ScrollAlwaysVisible = true;  // Siempre muestra la barra de desplazamiento
            listBoxResultados.IntegralHeight = false;      // Permite que el ListBox se ajuste correctamente
            listBoxResultados.Height = 150;                // Altura fija para ver el scrollbar

            special[0] = btnEspecial; // RAIZ CUADRADA
            special[1] = BtnEspecial2; // POTENCIA

            for (int j = 0; j < special.Length; j++) special[j].Click += ButtonEspecial_Click;


            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                {
                    ColectionBtn[i] = btnCero;
                    ColectionBtn[i].Click += Button_Click;
                    break;
                }
                int x = 11 + (i % 3) * 74; //cambia al prin
                int y = 228 + (i / 3) * 60;
                string[] array = { "7", "8", "9", "4", "5", "6", "1", "2", "3" };


                //creacion dinamica de botones, quitando el Cero....
                ColectionBtn[i] = new RJboton
                {
                    BackColor = Color.FromArgb(34, 34, 34),
                    BackgroundColor = Color.FromArgb(34, 34, 34),
                    BorderColor = Color.FromArgb(0, 0, 0, 30),
                    BorderRadius = 20,
                    BorderSize = 0,
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0),
                    ForeColor = Color.FromArgb(224, 224, 224),
                    Location = new Point(x, y),
                    Name = "rJboton10",
                    Size = new Size(68, 54),
                    TabIndex = 1032,
                    Text = array[i],
                    TextColor = Color.FromArgb(224, 224, 224),
                    UseVisualStyleBackColor = false
                };

                ColectionBtn[i].FlatAppearance.BorderColor = Color.Red;
                ColectionBtn[i].FlatAppearance.BorderSize = 0;
                ColectionBtn[i].Click += Button_Click;

                PaneSpecial.Controls.Add(ColectionBtn[i]);

            } 
             
        }


        private void tamOriginal() =>
             txtDisplay.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);

        string concat;
        private void Button_Click(object sender, EventArgs e)
        {
            if (esInfinite)
            {
                tamOriginal();
                esInfinite = false;
            }
            string tmp = ((Button)sender).Text;
            concat += tmp;
            txtDisplay.Text = concat;
            txtDisplay.SelectionStart = txtDisplay.Text.Length;

        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                signo = "÷";
                concat += signo;
                txtDisplay.Text = concat;
            }
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                signo = "*";
                concat += signo;
                txtDisplay.Text = concat;
            }
        }

        private void BtnRest_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                signo = "-";
                concat += signo;
                txtDisplay.Text = concat;
            }
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                signo = "+";
                concat += signo;
                txtDisplay.Text = concat;
            }
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            bool raizSquat = txtDisplay.Text.Contains("^") || txtDisplay.Text.Contains("√");
            if (raizSquat)
            {
                Operacion = txtDisplay.Text;
                // Regex para encontrar la expresión de potencia
                string potenciaPattern = @"(\d+(?:\.\d+)?)\s*\^\s*(\d+(?:\.\d+)?)";
                Match match = Regex.Match(txtDisplay.Text, potenciaPattern);

                // Calcular y reemplazar potencias
                while (match.Success)
                {
                    double baseNumero = double.Parse(match.Groups[1].Value);
                    double exponenteNumero = double.Parse(match.Groups[2].Value); 
                    double resultadoPotencia = Math.Pow(baseNumero, exponenteNumero);
                    txtDisplay.Text = txtDisplay.Text.Replace(match.Value, resultadoPotencia.ToString());
                    match = Regex.Match(txtDisplay.Text, potenciaPattern);
                }

                // Regex para encontrar la raíz cuadrada
                string raizCuadradaPattern = @"√(\d+)|√(\d+)";
                match = Regex.Match(txtDisplay.Text, raizCuadradaPattern);

                // Calcular y reemplazar raíces cuadradas
                while (match.Success)
                {
                    int numeroRaiz = int.TryParse(match.Groups[1].Value, out var num1) ? num1 : int.Parse(match.Groups[2].Value);
                    double resultadoRaiz = Math.Sqrt(numeroRaiz);
                    txtDisplay.Text = txtDisplay.Text.Replace(match.Value, resultadoRaiz.ToString());
                    match = Regex.Match(txtDisplay.Text, raizCuadradaPattern);
                }
                concat = txtDisplay.Text;
                Result(txtDisplay.Text);
                resultado = txtDisplay.Text; 
                inserted();
            }
            else
            {
                Operacion = txtDisplay.Text;
                Result(txtDisplay.Text);
                resultado = txtDisplay.Text;
                inserted();
            }

        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Contains('.'))
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtDisplay.Text, @"^\d*\.?\d*$"))
                {

                    signo = ".";
                    concat += signo;
                    txtDisplay.Text = concat;
                }

            }
            else
            {

                signo = ".";
                concat += signo;
                txtDisplay.Text = concat;
            }
        }


        private string Operacion;
        private string resultado;

        private void Result(string cad)
        {
            if (concat.Contains('÷'))
                concat = concat.Replace('÷', '/');

            //aqui puede devolver lo que sea, int double.... ojo
            var expresion = new Expression(concat);
            result = expresion.Evaluate();

            if (result.ToString() == "∞")
            {
                esInfinite = true;
            }
            //validar si es int o double o long y listo!!!

            if (esInfinite)
            {
                txtDisplay.Font = new Font("Microsoft Sans Serif", 16.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
                txtDisplay.Text = "No se puede dividir por cero";
                result = 0;
                concat = "";
            }
            else
            {
                txtDisplay.Text = result.ToString();
                concat = txtDisplay.Text;
            }

            signo = "\0";
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {
            string text = txtDisplay.Text;

            string[] partes = Regex.Split(text, @"\+|\-|\*|\/|\^");

            bool esValido = true;

            foreach (var parte in partes)
            {
                if (Regex.IsMatch(parte, @"^\d+$") && parte.StartsWith("0") && parte != "0")
                {
                    esValido = false;
                }
            }

            if (!esValido)
            {
                txtDisplay.Text = text.Substring(0, text.Length - 1);
                concat = txtDisplay.Text;
                txtDisplay.SelectionStart = txtDisplay.Text.Length;
            }

            if (System.Text.RegularExpressions.Regex.IsMatch(text, @"[*÷^+-]{2,}"))
            {
                txtDisplay.Text = text.Substring(0, text.Length - 1);
                concat = txtDisplay.Text;
                txtDisplay.SelectionStart = txtDisplay.Text.Length;
            }

        }

        private void txtDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox text = sender as TextBox;


            if (e.KeyChar == (char)Keys.Back) return;

            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == '/' || e.KeyChar == '*' || e.KeyChar == '+' || e.KeyChar == '-')
            {
                if (e.KeyChar == '.' && text.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
            else
            {
                e.Handled = true;
            }

        }

        private void BtnEraseAll_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            concat = "";
            if (esInfinite) tamOriginal();
        }

        private void Erase_Click(object sender, EventArgs e)
        {

            if (double.TryParse(txtDisplay.Text, out _))
            {
                if (txtDisplay.Text.Length > 1)
                {
                    txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                    txtDisplay.SelectionStart = txtDisplay.Text.Length;
                    concat = txtDisplay.Text;
                }
                else if (txtDisplay.Text.Length < 2)
                {
                    txtDisplay.Text = "0";
                    concat = "";
                }
            }
            else
            {
                txtDisplay.Text = "0";
                concat = "";
                if (esInfinite) tamOriginal();

            }
        }

        private void ButtonEspecial_Click(object sender, EventArgs e)
        {
            string input = (sender as Button).Text;

            if (input == "^")
            {
                if (txtDisplay.Text.Length > 0)
                {
                    concat += "^";
                    txtDisplay.Text = concat;
                }
            }
            else
            {
                concat += "√";
                txtDisplay.Text = concat; 
            }
        }


        private bool enPanelSecundario = false;
        private void lb_historial_Click(object sender, EventArgs e)
        { 

            // Agregar el ListBox al Panel
            panel2.Controls.Add(listBoxResultados);

            if (!enPanelSecundario)
            {
                PaneSpecial.Visible = false;
                panel2.Visible = true;
                enPanelSecundario = true;
                lb_historial.ForeColor = SystemColors.ControlDark; 
                panel2.Controls.Add(lb_historial); 
                
                llamadaResultado();
            }
            else
            {
                txtDisplay.SelectionStart = txtDisplay.Text.Length;
                panel2.Visible = false;
                PaneSpecial.Visible = true;
                lb_historial.ForeColor = SystemColors.ControlLight;
                PaneSpecial.Controls.Add(lb_historial);
                enPanelSecundario = false;
            }
 
        }




        private void llamadaResultado()
        {
            string query = "SELECT Operacion, resultado FROM Historial";
            listBoxResultados.Items.Clear();

            // Establecer la conexión con la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        { 
                            while (reader.Read())
                            {
                                // Leer las columnas de la base de datos
                                string operacion = reader["Operacion"].ToString();
                                decimal resultado = (decimal)reader["resultado"];

                                string text = $"{operacion} = {resultado}";
                                listBoxResultados.Items.Add(text);
                                
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al conectarse a la base de datos: {ex.Message}");
                }
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            panel2.Visible = false;
        }

        private void inserted()
        {

            string query = "INSERT INTO Historial (operacion, resultado) VALUES (@operacion, @resultado)"; // Cambia esto por tu consulta SQL

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Añadir parámetros
                    command.Parameters.AddWithValue("@operacion", Operacion);
                    command.Parameters.AddWithValue("@resultado", decimal.Parse(resultado));

                    try
                    {
                        connection.Open(); // Abrir conexión
                        int filasAfectadas = command.ExecuteNonQuery(); // Ejecutar la inserción  
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al insertar: {ex.Message}");
                    }
                }
            }

        }


    }
}
