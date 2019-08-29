using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeNascimento
{
    public partial class frmconsultar : Form
    {
        public frmconsultar()
        {
            InitializeComponent();

        }
        string parametro;
        
        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            
            if (boxConsulta.Text == String.Empty)
            {

                try
                {
                    using (NpgsqlConnection conexao = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=852ddd;Database=cadastro;"))
                    {
                        conexao.Open();
                        string cmdSeleciona = "Select * from regnascimento";

                        using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, conexao))
                        {
                            Adpt.Fill(dt);
                        }
                        dtConsulta.DataSource = dt;
                        conexao.Close();
                    }

                }
                catch (NpgsqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            else
            {
                try
                {
                    using (NpgsqlConnection conexao = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=852ddd;Database=cadastro;"))
                    {
                        
                        conexao.Open();
                        if(boxConsulta.Text == "Data de registro")
                        {
                            parametro = "daregistro";
                        }
                        if (boxConsulta.Text == "Nome do Registrado")
                        {
                            parametro = "nregistrado";
                        }
                        if (boxConsulta.Text == "Data de Nascimento")
                        {
                            parametro = "danascimento";
                        }
                        if (boxConsulta.Text == "Hora de Nascimento")
                        {
                            parametro = "hnascimento";
                        }
                        if (boxConsulta.Text == "Nome do Pai")
                        {
                            parametro = "npai";
                        }
                        if (boxConsulta.Text == "Nome da Mae")
                        {
                            parametro = "nmae";
                        }
                        if (boxConsulta.Text == "Numero DNV ou DO")
                        {
                            parametro = "ndnvdo";
                        }
                        string cmdSeleciona = "SELECT * FROM regnascimento WHERE " + parametro + " = '" + txtParametro.Text + "'";
                        using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmdSeleciona, conexao))
                        {
                            Adpt.Fill(dt);
                        }
                        dtConsulta.DataSource = dt;
                        conexao.Close();
                    }

                }
                catch (NpgsqlException ex)
                {
                    throw ex;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}

