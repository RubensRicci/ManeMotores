using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mane_Motores
{
    public partial class frmMane : Form
    {
        public frmMane()
        {
            InitializeComponent();
            btnAbaDeRecfe.Location = new Point(118, 0);
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            pnlBusca.Visible = true;
            pnlCadastro.Visible = false;
        }

        private void frmMane_SizeChanged(object sender, EventArgs e)
        {
            pnlBusca.Size = this.Size;
            pnlBuscar.Width = pnlBusca.Width - 42;
        }

        private void btnTelaIni_Click(object sender, EventArgs e)
        {
            pnlBusca.Visible = false;
            pnlCadastro.Visible = false;
        }

        private void btnCadas_Click(object sender, EventArgs e)
        {
            pnlBusca.Visible = false;
            pnlCadastro.Visible = true;
        }
        #region Abre Recursos
        private void btnAbaDeRecursos_Click(object sender, EventArgs e)
        {
            AbreRecursos();
        }

        private void btnAbaDeRecAbr2_Click(object sender, EventArgs e)
        {
            AbreRecursos();
        }
        private void btnAbaDeRecAbr3_Click(object sender, EventArgs e)
        {
            AbreRecursos();
        }
        #endregion

        #region Fecha Recursos

        private void btnAbaDeRecfe_Click(object sender, EventArgs e)
        {
            FechaRecursos();
        }

        private void btnAbaDeRecfe2_Click(object sender, EventArgs e)
        {
            FechaRecursos();
        }

        private void btnAbaDeRecfe3_Click(object sender, EventArgs e)
        {
            FechaRecursos();
        }
        #endregion

        public void FechaRecursos()
        {
            pnlRecursos.Location = new Point(-129, 0);
            btnAbaDeRecfe.Visible = false;
            btnAbaDeRecfe2.Visible = false;
            btnAbaDeRecfe3.Visible = false;
        }

        public void AbreRecursos()
        {
            pnlRecursos.Location = new Point(0, 0);
            btnAbaDeRecfe.Visible = true;
            btnAbaDeRecfe2.Visible = true;
            btnAbaDeRecfe3.Visible = true;
        }
    }
}
