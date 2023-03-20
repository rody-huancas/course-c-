using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class Form_Principal : Form
    {
        Form_Template Frm_1;
        Form_TrackBar TrackBar_1;
        Form_Categorias Frm_ca;

        public Form_Principal()
        {
            InitializeComponent();
        }

        private void miPrimerFormularioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_1 == null)
            {
                Frm_1 = new Form_Template();
                Frm_1.MdiParent = this;
                Frm_1.FormClosed += new FormClosedEventHandler(Alta_Frm_01);
                Frm_1.Show();
            }
            else
            {
                Frm_1.Activate();
            }

        }

        void Alta_Frm_01(object sender, EventArgs e)
        {
            Frm_1 = null;
        }

        private void trackBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (TrackBar_1 == null)
            {
                TrackBar_1 = new Form_TrackBar();
                TrackBar_1.MdiParent = this;
                TrackBar_1.FormClosed += new FormClosedEventHandler(Alta_Frm_02);
                TrackBar_1.Show();
            }
            else
            {
                TrackBar_1.Activate();
            }
        }
        void Alta_Frm_02(object sender, EventArgs e)
        {
            TrackBar_1 = null;
        }

        private void m_btn_01_Click(object sender, EventArgs e)
        {
            if (Frm_1 == null)
            {
                Frm_1 = new Form_Template();
                Frm_1.MdiParent = this;
                Frm_1.FormClosed += new FormClosedEventHandler(Alta_Frm_01);
                Frm_1.Show();
            }
            else
            {
                Frm_1.Activate();
            }
        }

        private void m_btn_02_Click(object sender, EventArgs e)
        {
            if (TrackBar_1 == null)
            {
                TrackBar_1 = new Form_TrackBar();
                TrackBar_1.MdiParent = this;
                TrackBar_1.FormClosed += new FormClosedEventHandler(Alta_Frm_02);
                TrackBar_1.Show();
            }
            else
            {
                TrackBar_1.Activate();
            }
        }

        private void categoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Frm_ca == null)
            {
                Frm_ca = new Form_Categorias();
                Frm_ca.MdiParent = this;
                Frm_ca.FormClosed += new FormClosedEventHandler(Alta_Frm_ca);
                Frm_ca.Show();
            }
            else
            {
                Frm_ca.Activate();
            }
        }
        void Alta_Frm_ca(object sender, EventArgs e)
        {
            Frm_ca = null;
        }
    }
}
