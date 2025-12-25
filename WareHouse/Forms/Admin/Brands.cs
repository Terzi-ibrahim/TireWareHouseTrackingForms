using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;

namespace WareHouse.Forms.Admin
{
    public partial class Brands : Form
    {
        public Brands()
        {
            InitializeComponent();
        }
        public void GetAll()
        {
            BrandService service = new BrandService();
            try
            {
                List<Brand> all = service.GetAll();
                if (all != null)
                {

                    dtgwBrand.DataSource = all;

                    if (dtgwBrand.Columns.Contains("Models"))
                    {
                        dtgwBrand.Columns["Models"].Visible = false;
                    }
                    dtgwBrand.Columns["BrandId"].ReadOnly = true;

                }
                else
                {

                    dtgwBrand.DataSource = null;
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine($"veri getirirken hata oluştu{ex.Message}");
            }


        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            BrandService service = new BrandService();
            try
            {
                Brand aranansize = new Brand { BrandName = txtsearch.Text };
                List<Brand> tiresizelist = service.GetBrandSize(aranansize);

                if (tiresizelist != null)
                {

                    dtgwBrand.DataSource = tiresizelist;

                    if (dtgwBrand.Columns.Contains("Models"))
                    {
                        dtgwBrand.Columns["Models"].Visible = false;
                    }
                    dtgwBrand.Columns["BrandId"].ReadOnly = true;
                }
                else
                {

                    dtgwBrand.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string add = txtadd.Text;
            BrandService service = new BrandService();
            try
            {
                Brand brand = new Brand { BrandName = add };
                service.Add(brand);
                txtadd.Clear();
                GetAll();
                MessageBox.Show("Başarılı bi şekilde eklendi");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dtgwBrand_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var brand = (Brand)dtgwBrand.Rows[e.RowIndex].DataBoundItem;

                var onay = MessageBox.Show($"{brand.BrandName} isimli itemi silmek istiyor musunuz?",
                                           "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    BrandService service = new BrandService();
                    int silinenId = service.Delete(brand);

                    if (silinenId > 0)
                    {
                        MessageBox.Show("Başarıyla silindi.");

                        btnsearch_Click(null, null);
                    }
                }
            }
        }
        private void dtgwBrand_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dtgwBrand.Columns["BrandId"].ReadOnly = true;
            if (dtgwBrand.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var brand = (Brand)dtgwBrand.Rows[e.RowIndex].DataBoundItem;
                    BrandService service = new BrandService();

                    service.Update(brand);

                    MessageBox.Show("Başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {

                    MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    btnsearch_Click(null, null);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Beklenmedik bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void Brands_Load(object sender, EventArgs e)
        {
            GetAll();
        }
    }
}
