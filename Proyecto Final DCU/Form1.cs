using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FaceRecognition;

namespace Proyecto_Final_DCU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            FaceRec.isTrained = true;
            txtnombre.Text = nombre;
        }

        FaceRec FaceRec = new FaceRec();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FaceRec.openCamera(pcbcamara, pcbimagen);
        }

        string nombre;
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            FaceRec.Save_IMAGE(txtnombre.Text);
            nombre = txtnombre.Text;
            
            MessageBox.Show("Guardado Correctamente");

            txtnombre.Text = "";       
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
