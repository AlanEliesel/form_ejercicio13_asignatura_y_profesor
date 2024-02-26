using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_ejercicio13_asignatura_y_profesor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rdo_virtual.Checked = false;
            rdo_Precensiar.Checked = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_procesar_Click(object sender, EventArgs e)
        {

            string asignatura, profesor, modalidad;

            
            asignatura = txt_asignatura.Text;
            profesor =  txt_profesor.Text;

            if(rdo_Precensiar.Checked = true) 
            {

                modalidad = rdo_Precensiar.Text;
                 
                string resultado = "Asignatura" + " " + asignatura + " " + "Profesor" + " " + profesor + " " + "la modalidad es" + " " + modalidad;

                MessageBox.Show(resultado);
            }
            else if(rdo_virtual.Checked = true)
            {
                modalidad = rdo_virtual.Text;

                string resultado = "Asignatura" + " " + asignatura + " " + "Profesor" + " " + profesor + " " + "la modalidad es" + " " + modalidad;

                MessageBox.Show(resultado);
            }

        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_asignatura.Clear();

            txt_profesor.Clear();

            rdo_Precensiar.Checked = false;
            rdo_virtual.Checked = false;


        }
    }
}
