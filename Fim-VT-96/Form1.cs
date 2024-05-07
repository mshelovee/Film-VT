using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fim_VT_96
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            FilmEkleForm ekleForm = new FilmEkleForm();
            ekleForm.ShowDialog();
        }

        private void btnTumFilmler_Click(object sender, EventArgs e)
        {
            TumFilmlerForm filmlerForm = new TumFilmlerForm();
            filmlerForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string klasorYolu = @"poster";
            if (!Directory.Exists(klasorYolu))
            {
                Directory.CreateDirectory(klasorYolu);
            }
        }
    }
}
