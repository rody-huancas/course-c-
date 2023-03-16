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
    public partial class Form_NumericUpDown : Form
    {
        public Form_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            string DiaTexto = "";
            decimal NroDia = num_nrodia.Value;

            switch (NroDia)
            {
                case 1:
                    DiaTexto = "Lunes";
                    break;
                case 2:
                    DiaTexto = "Martes";
                    break;
                case 3:
                    DiaTexto = "Miércoles";
                    break;
                case 4:
                    DiaTexto = "Jueves";
                    break;
                case 5:
                    DiaTexto = "Viernes";
                    break;
                case 6:
                    DiaTexto = "Sábado";
                    break;
                case 7:
                    DiaTexto = "Domingo";
                    break;
            }

            lb_mostrarDia.Text = DiaTexto;
        }
    }
}
