using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Template
{
    public partial class Form_Categorias : Form
    {
        public Form_Categorias()
        {
            InitializeComponent();
        }

        #region "Mis Métodos" 

        private void Formato_ca()
        {
            Dgv_Principal.Columns[0].Width = 80;
            Dgv_Principal.Columns[0].HeaderText = "CÓDIGO";
            Dgv_Principal.Columns[1].Width = 200;
            Dgv_Principal.Columns[1].HeaderText = "DESCRIPCIÓN";
        }
        private void Listado_ca(string cTexto)
        {
            Dgv_Principal.DataSource = N_Categoria.Listar_ca(cTexto);
            this.Formato_ca();
        }

        private void Estado(bool lEstado)
        {
            Txt_descripcion_ca.Enabled = lEstado;
            Btn_guardar.Enabled = lEstado;
            Btn_cancelar.Enabled = lEstado;

            Btn_actualizar.Enabled = !lEstado;
            Btn_eliminar.Enabled = !lEstado;
            Btn_reporte.Enabled = !lEstado;
            Btn_salir.Enabled = !lEstado;

            Txt_buscar.Enabled = lEstado;
            Btn_buscar.Enabled = !lEstado;
            Dgv_Principal.Enabled = lEstado;
        }
        #endregion

        private void Form_Categorias_Load(object sender, EventArgs e)
        {
            this.Listado_ca("%");
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_descripcion_ca.Text))
            {
                MessageBox.Show("No se tiene información para ser guardad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String Rpta = "";
                E_Categoria oCa = new E_Categoria();
                oCa.Codigo_ca = 0;
                oCa.Descripcion_ca = Txt_descripcion_ca.Text.Trim();
                Rpta = N_Categoria.Guardar_ca(1, oCa);
                if (Rpta.Equals("OK"))
                {
                    this.Listado_ca("%");
                    this.Estado(false);
                    Txt_descripcion_ca.Text = "";
                    MessageBox.Show("Datos Guardados Correctamente", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show(Rpta, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            this.Listado_ca(Txt_buscar.Text.Trim());
        }

        private void Btn_nuevo_Click(object sender, EventArgs e)
        {
            this.Estado(true);
            Txt_descripcion_ca.Text = "";
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Estado(false);
            Txt_descripcion_ca.Text = "";
        }
    }
}
