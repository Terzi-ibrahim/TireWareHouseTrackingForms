using System;
using System.Windows.Forms;
using WareHouse.Application.Services;

namespace WareHouse.Forms.Admin
{
    public partial class TireSize : Form
    {
        public TireSize()
        {
            InitializeComponent();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            TireSizeService size = new TireSizeService();

            dataGridView1.DataSource = size.GetTireSizesDataTable();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskadd.Text))
            {
                MessageBox.Show("Lütfen geçerli bir ebat yazınız.", "Giriş Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                TireSizeService size = new TireSizeService();

                var yeniebat = size.AddTireSize(mskadd.Text);

                MessageBox.Show($"Yeni ebat başarıyla eklendi: {yeniebat.TireSizeName}");

                dtgwegs.DataSource = size.GetTireSizesDataTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mskupdate.Text) || string.IsNullOrEmpty(txtupdate.Text))
            {
                MessageBox.Show("tüm alanları doldurun.");
            }
            int.TryParse(txtupdate.Text, out int id);
            try
            {
                TireSizeService size = new TireSizeService();
                var update = size.UpdateTireSize(id, mskupdate.Text);

                MessageBox.Show(" ebat başarıyla güncellendi:");

                dtgwegs.DataSource = size.GetTireSizesDataTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtdelete.Text))
            {
                MessageBox.Show("Lütfen ıd doldurunuz.");
            }
            int.TryParse(txtdelete.Text, out int id);
            try
            {
                TireSizeService size = new TireSizeService();
                var delete = size.DeleteTireSize(id);

                MessageBox.Show(" ebat başarıyla silindi:");

                dtgwegs.DataSource = size.GetTireSizesDataTable();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Beklenmeyen bir hata oluştu: " + ex.Message);
            }
        }
    }
}
