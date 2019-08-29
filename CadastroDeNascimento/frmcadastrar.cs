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
    public partial class frmcadastrar : Form
    {
        string prazo;
        string livro;
        string DnvOuDo;
        public frmcadastrar()
        {
            InitializeComponent();
        }
        private void RadioSim_CheckedChanged(object sender, EventArgs e)
        {
            prazo = "SIM";
        }

        private void RadioNao_CheckedChanged(object sender, EventArgs e)
        {
            prazo = "NAO";
        }

      
        private void BtnInserirCadastro_Click(object sender, EventArgs e)
        {
            int idademae;
            int idadepai;
            NpgsqlConnection conexao = new NpgsqlConnection("Server=127.0.0.1;Port=5432;User Id=postgres;Password=852ddd;Database=cadastro;");
            conexao.Open();
            var Calculo = new Metodos();
            
            try
            {
                if (boxLivro.SelectedIndex == 0)
                {
                    livro = "A";
                    DnvOuDo = "DNV";
                }
                if (boxLivro.SelectedIndex == 1)
                {
                    livro = "C AUX";
                    DnvOuDo = "DO";
                }
                Calculo.VerificaCampoVazio(boxLivro.Text, txtNumLivro.Text, txtNumPagina.Text, txtNumRegistro.Text, txtNoRegistrado.Text, boxSexo.Text, txtHoraNascimento.Text, txtNomePai.Text, dtpNascimentoPai.Value, txtLocalPai.Text, txtNomeMae.Text, dtpNascimentoMae.Value, txtLocalMae.Text, txtDnvDo.Text);
                string num = txtDnvDo.Text;
                num = num.Trim();
                num = num.Replace("-", "");
                long digito = Convert.ToInt64(num);
                int tamanho = num.Length;
                
                if (livro == "A")
                {
                    if(tamanho == 8)
                    {
                        if(digito < 43700001)
                        {
                            MessageBox.Show("Não se Aplica regra de DV");
                        }
                        else
                        {
                            throw new System.ArgumentException("DNV Invalido", "original");
                        }
                    }

                    if (tamanho == 9)
                    {
                        string tempDv = num.Substring(0, 8);
                        int numero = Convert.ToInt32(tempDv);
                        if (numero >= 43700001 && numero < 48101001)
                        {
                            var validador = new Metodos();
                            var resultado = validador.dv1(txtDnvDo.Text);
                            MessageBox.Show("Caiu na regra DV1 DNV: " + resultado);
                            if (resultado == "Numero Invalido")
                            {
                                throw new System.ArgumentException("DNV Invalido", "original");
                            }
                        }
                        else
                        {
                            throw new System.ArgumentException("DNV Invalido", "original");
                        }
                    }

                    if (tamanho == 11)
                    {
                        string tempDv = num.Substring(2, 8);
                        int numero = Convert.ToInt32(tempDv);
                        if (numero >= 48101000)
                        {
                            var validador = new Metodos();
                            var resultado = validador.dv2dnv(txtDnvDo.Text);
                            MessageBox.Show("Caiu na regra DV2 DNV: " + resultado);
                            if (resultado == "Numero Invalido")
                            {
                                throw new System.ArgumentException("DNV Invalido", "original");
                            }
                        }
                        else
                        {
                            throw new System.ArgumentException("DNV Invalido", "original");
                        }
                    }
                }
                if (livro == "C AUX")
                {
                    if (tamanho == 8)
                    {
                        if (digito < 12075501)
                        {
                            MessageBox.Show("Não se Aplica regra de DV");
                        }
                        else
                        {
                            throw new System.ArgumentException("DO Invalido", "original");
                        }
                    }

                    if (tamanho == 9)
                    {
                        string tempDv = num.Substring(0, 8);
                        int numero = Convert.ToInt32(tempDv);
                        if (numero >= 12075501 && numero < 13600000)
                        {
                            var validador = new Metodos();
                            var resultado = validador.dv1(txtDnvDo.Text);
                            MessageBox.Show("Caiu na regra DV1 DO: " + resultado);
                            if (resultado == "Numero Invalido")
                            {
                                throw new System.ArgumentException("DO Invalido", "original");
                            }
                        }
                        else if (numero >= 13600000)
                        {
                            var validador = new Metodos();
                            var resultado = validador.dv2do(txtDnvDo.Text);
                            MessageBox.Show("Caiu na regra DV2 DO: " + resultado);
                            if (resultado == "Numero Invalido")
                            {
                                throw new System.ArgumentException("DO Invalido", "original");
                            }
                        }
                        else
                        {
                            throw new System.ArgumentException("DO Invalido", "original");
                        }
                    }

                }
                if (prazo == "NAO")
                {
                    idademae = Calculo.calculaIdade(dtpNascimentoMae.Value, dtpDataRegistro.Value);
                }
                else
                {
                    idademae = Calculo.calculaIdade(dtpNascimentoMae.Value, dtpDataNascimento.Value);
                }
                    idadepai = Calculo.calculaIdade(dtpNascimentoPai.Value, dtpDataRegistro.Value);
                
                string cmdInserir = String.Format("Insert INTO regnascimento(nlivro,nulivro,nupagina,nuregistro,daregistro,nregistrado,sexo,danascimento,hnascimento,npai,danascimentopai,cidadepai,nmae,danascimentomae,cidademae,ndnvdo,regprazo, idadedopai, idadedamae) VALUES('" + livro + "', '" + txtNumLivro.Text + "','" + txtNumPagina.Text + "', '" + txtNumRegistro.Text + "','" + dtpDataRegistro.Value + "', '" + txtNoRegistrado.Text + "','" + boxSexo.Text + "', '" + dtpDataNascimento.Value + "','" + txtHoraNascimento.Text + "', '" + txtNomePai.Text + "','" + dtpNascimentoPai.Value + "', '" + txtLocalPai.Text + "','" + txtNomeMae.Text + "', '" + dtpNascimentoMae.Value + "','" + txtLocalMae.Text + "', '" + txtDnvDo.Text + "','" + prazo + "','" + idadepai + "','" + idademae + "')");
                NpgsqlCommand conexaocommand = new NpgsqlCommand(cmdInserir, conexao);
                conexaocommand.ExecuteNonQuery();
                MessageBox.Show("Inserido com sucesso");
                conexao.Close();
            }
            
            catch (NpgsqlException xe)
            {
                MessageBox.Show("Erro: " + xe);
            }
            catch (Exception xe)
            {
                MessageBox.Show("Erro: " + xe);
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            txtNumLivro.Text = String.Empty;
            txtNumPagina.Text = String.Empty;
            txtNumRegistro.Text = String.Empty;
            txtNoRegistrado.Text = String.Empty;
            txtNomePai.Text = String.Empty;
            txtNomeMae.Text = String.Empty;
            txtDnvDo.Text = String.Empty;
            txtHoraNascimento.Text = "hh:mm";
            txtLocalPai.Text = "Cidade/UF";
            txtLocalMae.Text = "Cidade/UF";
            //Radio
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            txtNumLivro.Text = "12345";
            txtNumPagina.Text = "12345";
            txtNumRegistro.Text = "12345";
            txtNoRegistrado.Text = "Rodrigo Justen";
            txtNomePai.Text = "José Alves";
            txtNomeMae.Text = "Maura Cristina";
            txtDnvDo.Text = "12345";
            txtHoraNascimento.Text = "21:30";
            txtLocalPai.Text = "Taubate/SP";
            txtLocalMae.Text = "São José dos Campos/UF";
            


        }
    }
}
