using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCirculares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Terminal ter = new Terminal();
        private void btnAgregarBase_Click(object sender, EventArgs e)
        {
            Base nuevo = new Base(txtBase.Text, Convert.ToInt32(txtTiempo.Text));

            ter.agregarFinal(nuevo);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtRecorrido.Text = ter.ruta(txtDato.Text, Convert.ToDateTime(txtHoraInicio.Text), Convert.ToDateTime(txtHoraFinal.Text));
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtRecorrido.Text = ter.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            txtRecorrido.Text = ter.buscar(txtDato.Text).ToString();
        }

        private void btnEliminarPrimero_Click(object sender, EventArgs e)
        {
            ter.eliminarInicio();
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            ter.eliminarUltimo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ter.eliminar(txtDato.Text);
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Base nuevo = new Base(txtBase.Text, Convert.ToInt32(txtTiempo.Text));
            ter.insertar(nuevo, Convert.ToInt32(txtDato.Text));
        }
    }
}
