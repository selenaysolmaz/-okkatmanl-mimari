using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Northwind.ORM1.Entity;
using Northwind.ORM1.Fascade;

namespace Northwind.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void KategoriListele()
        {
            dataGridView1.DataSource = Categories.Select();
            dataGridView1.Columns["CategoryID"].Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KategoriListele();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.CategoryName = txtAdi.Text;
            c.Description = txtTanim.Text;
            bool sonuc = Categories.Insert(c);
            if (sonuc)
            {
                MessageBox.Show("kayıt basarıyla eklendi.");
                KategoriListele();
            }
            else
            {
                MessageBox.Show("kayıt eklenirken hata olustu.");
            }
        }

     
    }
}
