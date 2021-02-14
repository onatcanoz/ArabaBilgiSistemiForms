using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaBilgiSistemiForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lsonuc.Text = "";
            ddlKapiSayisi.SelectedIndex = 1;
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            sonuc += tbMarka.Text + "\n" + "\n";
            sonuc += tbModel.Text + "\n" + "\n";
            sonuc += lbCekis.Text + "\n" + "\n";
            if (rbBinek.Checked)
                sonuc += "Binek" + "\n" + "\n";
            else
                sonuc += "Ticari" + "\n" + "\n";
            sonuc += ddlKapiSayisi.Text + "\n" + "\n";
            sonuc += nupBeygir.Value + "\n" + "\n";
            sonuc += nupMax.Value + "\n" + "\n";
            sonuc += nupSıfıryuz.Value + "\n" + "\n";
            sonuc += nupAgırlık.Value + "\n" + "\n";
            sonuc += nupMotorHacmi.Value + "\n" + "\n";

            lsonuc.Text = sonuc;
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbMarka.Text = "";
            tbModel.Text = "";            
            rbTicari.Checked = false;
            rbBinek.Checked = true;
            lbCekis.ClearSelected();
            ddlKapiSayisi.SelectedIndex = 1;
            nupBeygir.Value = 120;
            nupMax.Value = 200;
            nupSıfıryuz.Value = 8;
            nupAgırlık.Value = 1000;
            nupMotorHacmi.Value = 1200;

            lsonuc.Text = "";         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Yallah!!!!");
        }        
    }
}
