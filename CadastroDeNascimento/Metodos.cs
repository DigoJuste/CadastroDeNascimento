using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroDeNascimento
{
    public class Metodos
    {
        public void VerificaCampoVazio(string campo, string campo1, string campo2, string campo3, string campo5, string campo6, string campo8, string campo9, DateTime campo10, string campo11, string campo12, DateTime campo13, string campo14, string campo15)
        //public void VerificaCampoVazio(string campo1)
        {
            campo15 = campo15.Trim();
            campo15 = campo15.Replace("-", "");
            int tamanho = campo15.Length;
            if(campo == "[Selecione]")
            {
                throw new System.ArgumentException("Parameter Livro deve ser preenchido", "original");
            }
            else if (campo1 == String.Empty)
            {
                throw new System.ArgumentException("Parameter Numero do Livro be null", "original");
            }
            else if (campo2 == String.Empty)
            {
                throw new System.ArgumentException("Parameter Numero da Pagina be null", "original");
            }
            else if (campo3 == String.Empty)
            {
                throw new System.ArgumentException("Parameter Numero do Registro be null", "original");
            }
            
            else if (campo5 == String.Empty)
            {
                throw new System.ArgumentException("Parameter Nome do Registrado be null", "original");
            }
            else if (campo6 == "[Selecione]")
            {
                throw new System.ArgumentException("Parametro sexo não esta preenchido", "original");
            }
            
            else if (campo8 == "hh:mm")
            {
                throw new System.ArgumentException("Parameter Hora de Nascimento deve ser preenchido", "original");
            }
            else if (campo9 == String.Empty)
            {
                throw new System.ArgumentException("Parameter Nome do Pai be null", "original");
            }
            else if (campo10 == DateTime.Now)
            {
                throw new System.ArgumentException("Data de Nascimento do pai igual data de hoje", "original");
            }
            else if (campo11 == "Cidade/UF")
            {
                throw new System.ArgumentException("Parameter Local Nascimento Pai não esta preenchido", "original");
            }
            else if (campo12 == String.Empty)
            {
                throw new System.ArgumentException("Parameter Nome Mae be null", "original");
            }
            else if (campo13 == DateTime.Now)
            {
                throw new System.ArgumentException("Data de Nascimento da Mãe igual data de hoje", "original");
            }
            else if (campo14 == "Cidade/UF")
            {
                throw new System.ArgumentException("Parameter Local Nascimento Pai não esta preenchido", "original");
            }
            
            else if (tamanho < 8 || tamanho > 11)
            {
                throw new System.ArgumentException("DNV ou DO invalido", "original");
            }


        }
        public int calculaIdade(DateTime dtNascimento, DateTime dtRelacao)
        {
            int idade = dtRelacao.Year - dtNascimento.Year;
            if (dtRelacao.Month < dtNascimento.Month || (dtRelacao.Month == dtNascimento.Month && dtRelacao.Day < dtNascimento.Day))
                idade--;

            return idade;
        }

        public string dv1(string num)
        {
            string tempDv;
            int numero;
            string verificador;
            num = num.Trim();
            num = num.Replace(".", "").Replace("-", "");
            string validacao = num;
            tempDv = num.Substring(0, 8);
            numero = Convert.ToInt32(tempDv);
            int dv = numero % 11;
            string digitocompleto = tempDv + Convert.ToString(dv);
            if(dv == 10)
            {
                verificador = numero + "0";
            }
            else
            {
                verificador = digitocompleto;
            }
            if(validacao == verificador)
            {
                return "Numero Valido";

            }
            else
            {
                
                return "Numero Invalido";
                

            }
        }

        public string dv2do(string num)
        {
            int[] peso = new int[8] { 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempDv;
            num = num.Trim();
            num = num.Replace(".", "").Replace("-", "");
            string validacao = num;
            tempDv = num.Substring(0, 8);
            int soma = 0;

            for (int i = 0; i < 8; i++)
            {
                soma += int.Parse(tempDv[i].ToString()) * peso[i];
            }

           int resto = soma % 11;
           resto = 11 - resto;

            if (resto == 10 || resto == 11)
            {
                resto = 0;
            }
            string digitocompleto = tempDv + Convert.ToString(resto);
            if (digitocompleto == validacao)
            {
                return "Numero Valido";

            }
            else
            {
                return "Numero Invalido";
            }

        }

        public string dv2dnv(string num)
        {
            int[] peso = new int[10] { 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempDv;
            num = num.Trim();
            num = num.Replace(".", "").Replace("-", "");
            string validacao = num;
            tempDv = num.Substring(0, 10);
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                soma += int.Parse(tempDv[i].ToString()) * peso[i];
            }

            int resto = soma % 11;
            resto = 11 - resto;

            if (resto == 10 || resto == 11)
            {
                resto = 0;
            }
            string primeiraparte = tempDv.Substring(0, 2);
            string segundaparte = tempDv.Substring(2, 8);
            string digitocompleto = primeiraparte + segundaparte + Convert.ToString(resto);
            if (digitocompleto == validacao)
            {
                return "Numero Valido";

            }
            else
            {
                return "Numero Invalido";
            }
            /*
            if (tamanho == 8)
            {
                int numero = Convert.ToInt32(num);
                if (numero < 43700001 || numero < 12075501)
                {
                    MessageBox.Show("Não cai na regra DV1 e DV2");
                }
                else
                {
                    MessageBox.Show(DnvOuDo + " invalido");
                }

            }
            else if (tamanho == 9)
            {
                string tempDv = num.Substring(0, 8);
                int numero = Convert.ToInt32(tempDv);
                if (livro == "C AUX")
                {
                    if (numero >= 43700001 && numero < 48101001)
                    {
                        var validador = new Metodos();
                        var resultado = validador.dv1(txtDnvDo.Text);
                        MessageBox.Show("Caiu na regra DV1: " + resultado);
                    }
                    else if (numero >= 13600000)
                    {
                        var validador = new Metodos();
                        var resultado = validador.dv2do(txtDnvDo.Text);
                        MessageBox.Show("Caiu na regra DV2 DO: " + resultado);
                    }
                    else
                    {
                        MessageBox.Show(DnvOuDo + " invalido");
                    }
                }
                else
                {
                    if (numero >= 12075501 && numero < 13600000)
                    {
                        var validador = new Metodos();
                        var resultado = validador.dv1(txtDnvDo.Text);
                        MessageBox.Show("Caiu na regra DV1: " + resultado);
                    }
                    else
                    {
                        MessageBox.Show(DnvOuDo + " invalido");
                    }
                }

            }
            else if (tamanho == 11)
            {
                string tempDv = num.Substring(2, 8);
                int numero = Convert.ToInt32(tempDv);
                if (numero >= 48101000 && livro == "A")
                {
                    var validador = new Metodos();
                    var resultado = validador.dv2dnv(txtDnvDo.Text);
                    MessageBox.Show("Caiu na regra DV2 DNV: " + resultado);
                }
                else
                {
                    MessageBox.Show(DnvOuDo + " invalido");

                }
            }
            else
            {
                MessageBox.Show(DnvOuDo + " invalido");

            }
            */

        }
    }
}
