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
    public partial class Form_Template : Form
    {
        public Form_Template()
        {
            InitializeComponent();
        }

        //Inicio de mis variables
        int EstadoGuardar = 0;
        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            EstadoGuardar = 1; // cuando tenga el valor de 1 será para registrar
            lst_mantenimiento.Enabled = false;

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = true;
            txt_codigo.Enabled = true;
            grb_botones_principales.Enabled = false;

            txt_codigo.Focus();
            //txt_codigo.Select();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;
            lst_mantenimiento.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            string Registro;
            Registro = txt_codigo.Text.Trim() + " | " + txt_descripcion.Text.Trim();

            if (EstadoGuardar == 1) 
            {
                lst_mantenimiento.Items.Add(Registro);
            }
            else
            {
                int ElementoSeleccionado = lst_mantenimiento.SelectedIndex;

                lst_mantenimiento.Items.Remove(lst_mantenimiento.SelectedItem);

                lst_mantenimiento.Items.Insert(ElementoSeleccionado, Registro);

            }

            MessageBox.Show("Se registró correctamente.");

            txt_codigo.Text = "";
            txt_descripcion.Text = "";

            grb_mantenimiento.Enabled = false;
            grb_botones_principales.Enabled = true;

            lst_mantenimiento.Enabled = true;
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            foreach (var item in lst_mantenimiento.SelectedItems.Cast<object>().ToList())
            {
                lst_mantenimiento.Items.Remove(item);
            }
            MessageBox.Show("Se eliminó correctamente.");
        }

        private void lst_mantenimiento_Click(object sender, EventArgs e)
        {
            string textoSeleccionado;
            int LongitudTexto;

            textoSeleccionado = this.lst_mantenimiento.SelectedItem.ToString();
            LongitudTexto = textoSeleccionado.Length;

            txt_codigo.Text = textoSeleccionado.Trim().Substring(0, 5);
            txt_descripcion.Text = textoSeleccionado.Trim().Substring(7, LongitudTexto - 7);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            EstadoGuardar = 2;

            lst_mantenimiento.Enabled = false;
            grb_mantenimiento.Enabled = true;
            grb_botones_principales.Enabled = false;
            txt_codigo.Enabled = false;

            txt_codigo.Focus();

        }
    }
}
