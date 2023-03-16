using System;
using System.Windows.Forms;

namespace Template
{
    public partial class Form_Encuesta : Form
    {
        public Form_Encuesta()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string Resultado = "";

            // checkbox
            if (chk_javascript.Checked) Resultado += chk_javascript.Text + ", ";

            if (chk_react.Checked) Resultado += chk_react.Text + ", ";

            if (chk_csharp.Checked) Resultado += chk_csharp.Text + ", ";

            if (chk_java.Checked) Resultado += chk_java.Text;

            //Radio button
            if (rdb_presencial.Checked) Resultado += ":::::::::" + rdb_presencial.Text + ":::::::::";
            else Resultado += ":::::::::" + rdb_virtual.Text + ":::::::::";

            txt_Resultado.Text = Resultado; 
        }
    }
}
