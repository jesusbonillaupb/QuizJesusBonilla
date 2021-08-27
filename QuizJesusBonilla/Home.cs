using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizJesusBonilla
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void cBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstAparatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numEdad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            DateTimePicker date = datFechaViaje;
            var a = txtNombre.Text;
            var h = radGeneroH.Checked;
            var m = radGeneroM.Checked;
            var o = radGeneroO.Checked;
            var d = cmbDestino.Text;
            var f=  numEdad.Text;
            var t = lstClase.Text;
            var g = "";
            var c = date.Value.Date.ToString("dd/MM/yyyy");
            if (h) {
                g="hombre";

            }
            if (m)
            {
                g = "mujer";

            }
            if (o)
            {
                g = "hombre";

            }
            respuesta = a + ", "+ g + ", edad= " + f + " años, con " + " destino a " + d +" en "+ t+" el "+c;
            
            respuesta = respuesta + "\n";
            rtbDatos.Text =rtbDatos.Text + respuesta;
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void radGeneroH_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {


            Report enviar = new Report();

            enviar.rtbReport.Text = rtbDatos.Text;
            enviar.Show();


        }
    }
}
