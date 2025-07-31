using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoWindowsForms
{
    public partial class Frm_HelloWord : Form
    {
        public Frm_HelloWord()
        {
            InitializeComponent();
        }

        private void Frm_HelloWord_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HelloWord_Load(object sender, EventArgs e)
        {

        }

        private void Btn_ModificaLabel_Click(object sender, EventArgs e)
        {
           lbl_Titulo.Text = Txt_ConteudoLabel.Text;
        }
    }
}
