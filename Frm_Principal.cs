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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_DemostracaoKey_Click(object sender, EventArgs e)
        {
            Frm_Demostracao f = new Frm_Demostracao();
            f.ShowDialog();
        }

        private void Btn_HelloWorld_Click(object sender, EventArgs e)
        {
            Frm_HelloWord h = new Frm_HelloWord();
            h.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Frm_Mascara m = new Frm_Mascara();
            m.ShowDialog();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF v = new Frm_ValidaCPF();  
            v.ShowDialog();
        }

        private void Btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF2 v2 = new Frm_ValidaCPF2();   
            v2.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha vs = new Frm_ValidaSenha(); 
            vs.ShowDialog();
        }
    }
}
