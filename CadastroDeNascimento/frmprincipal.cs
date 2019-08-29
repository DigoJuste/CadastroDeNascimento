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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            frmcadastrar Cadastro = new frmcadastrar();
            Cadastro.ShowDialog();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            frmconsultar Consulta = new frmconsultar();
            Consulta.ShowDialog();
        }
    }
}
