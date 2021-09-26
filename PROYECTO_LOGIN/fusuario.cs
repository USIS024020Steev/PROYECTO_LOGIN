using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace PROYECTO_LOGIN
{
    public partial class fusuario : Form
    {
        //Crear variable......para conexion
        public OleDbConnection micoexion;

        //Crear variable.....para saber cual actualizar 
        public string usuario_modificar;

        public fusuario()
        {
            //Crear variable.....para conexion


            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\Usuario.accdb ");
            OleDbCommand com = new OleDbCommand();
            OleDbDataReader dtr;

            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NV76SQV;Initial Catalog=Loginn;Integrated Security=True");
        public void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnaccess_Click(object sender, EventArgs e)
        {
            OleDbConnection conexion = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DELL\Documents\Usuario.accdb ");
            OleDbCommand com = new OleDbCommand();
            OleDbDataReader dtr;
            conexion.Open();
            com.Connection = conexion;
            com.CommandType = CommandType.Text;
            com.CommandText = "SELECT Contraseña FROM Usuarios WHERE nUsuario='" + txtuser.Text + "'";
            try
            {
                dtr = com.ExecuteReader();
                if (dtr.HasRows)
                {
                    while (dtr.Read())
                    {
                        if (dtr.GetValue(0).ToString() == txtclave.Text)
                        {
                            MessageBox.Show("Loggin Exitoso");
                        }

                        else
                        {
                            MessageBox.Show("Contraseña incorrecta");
                        }

                    }
                }
            }
            catch (Exception k)
            {
                MessageBox.Show(k.ToString());
            }
        }

        private void fusuario_Load(object sender, EventArgs e)
        {
            txtuser.Enabled = false;
            txtclave.Enabled = false;
            //lstnivel.Enabled = false;

            //this.tusuarioTableAdapter.Fill(this.sistemaDataSet.tusuario);
        }

        private void btnsql_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-NV76SQV;Initial Catalog=Loginn;Integrated Security=True");
            connection.Open();
            SqlCommand comd = new SqlCommand("SELECT Contraseña FROM Users WHERE USuario= @vusuario AND Contraseña= @vContraseña", connection);
            comd.Parameters.AddWithValue("@vusuario", txtuser.Text);
            comd.Parameters.AddWithValue("@vContraseña", txtclave.Text);
            SqlDataReader lector = comd.ExecuteReader();
            if (lector.Read());
            {
                MessageBox.Show("Contraseña correcta");
            }
        }
    }
}
