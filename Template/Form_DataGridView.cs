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
    public partial class Form_DataGridView : Form
    {
        public Form_DataGridView()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text != "" && txt_email.Text != "")
            {
                dtv_datos.Rows.Add(txt_nombre.Text, txt_email.Text);
                txt_nombre.Text = "";
                txt_email.Text = "";

                MessageBox.Show("Datos agregados correctamente");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult Respuesta;
            Respuesta = MessageBox.Show("¿Estás seguro de eliminar?", "Eliminar", MessageBoxButtons.YesNo);
            if (Respuesta == DialogResult.Yes)
            {
                int NFila = dtv_datos.CurrentRow.Index;
                dtv_datos.Rows.RemoveAt(NFila);
                MessageBox.Show("Datos eliminados correctamente");
            }
        }

        private void dtv_datos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nombre.Text = Convert.ToString(dtv_datos.CurrentRow.Cells["Column1"].Value);
            txt_email.Text = Convert.ToString(dtv_datos.CurrentRow.Cells["Column2"].Value);
        }
    }
}
