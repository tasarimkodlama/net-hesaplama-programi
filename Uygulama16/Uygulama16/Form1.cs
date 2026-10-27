using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            //giriş
            double turkceDogru, turkceYanlis, turkceNet, matDogru, matYanlis, matNet;
            turkceDogru = Convert.ToDouble(txtTurkceDogru.Text);
            turkceYanlis = Convert.ToDouble(txtTurkceYanlis.Text);
            matDogru = Convert.ToDouble(txtMatDogru.Text);
            matYanlis = Convert.ToDouble(txtMatYanlis.Text);

            //işlemler
            turkceNet = turkceDogru - turkceYanlis / 4;
            matNet = matDogru - matYanlis / 4;

            //çıkış
            txtTurkceNet.Text = turkceNet.ToString();
            txtMatNet.Text= matNet.ToString();

        }
    }
}
