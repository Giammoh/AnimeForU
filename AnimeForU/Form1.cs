using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimeForU
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "5 Centimetri al secondo")
            {
                richTextBox1.Text = "Film: http://spaceanime.ml/view.php?t=2&id=YzpKJtu132y";
            }

            if (comboBox2.Text == "Koe no Katachi")
            {
                richTextBox1.Text = "Film: http://spaceanime.ml/view.php?type=1&id=AKPSSJpdKjy";
            }

            if (comboBox2.Text == "La ragazza che saltava nel tempo")
            {
                richTextBox1.Text = "Film: http://spaceanime.ml/view.php?t=2&id=E1Iol51T1Ux";
            }

            if (comboBox2.Text == "Sword Art Online: Ordinal Scale")
            {
                richTextBox1.Text = "Film: http://spaceanime.ml/view.php?type=1&id=gj_OebPHouB";
            }

            if (comboBox2.Text == "Your Name")
            {
                richTextBox1.Text = "Film: http://spaceanime.ml/view.php?type=1&id=EK9iimwIgRZ";
            }
        }
    }
}
