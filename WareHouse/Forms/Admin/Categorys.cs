using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WareHouse.Application.DTOs;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;

namespace WareHouse.Forms.Admin
{
    public partial class Categorys : Form
    {
        public Categorys()
        {
            InitializeComponent();
        }
        public void GetAll()
        {
            CategoryService service = new CategoryService();
            try
            {

                List<Category> list = service.GetAll();
                dtgwList.DataSource = list;
                if (list != null)
                {

                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("Tires"))
                    {
                        dtgwList.Columns["Tires"].Visible = false;
                    }
                    dtgwList.Columns["CategoryId"].ReadOnly = true;
                    dtgwList.Columns["CategoryId"].DisplayIndex = 0;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 1;

                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            CategoryService service = new CategoryService();
            try
            {
                Category search = new Category { CategoryName = txtsearch.Text };
                List<Category> list = service.GetSearch(search);

                if (list != null)
                {

                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("Tires"))
                    {
                        dtgwList.Columns["Tires"].Visible = false;
                    }
                    dtgwList.Columns["CategoryId"].ReadOnly = true;
                    dtgwList.Columns["CategoryId"].DisplayIndex = 0;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 1;

                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtadd.Text;
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Lütfen gerekli alanı doldurunuz");
            }
            CategoryService service = new CategoryService();
            try
            {
                Category model = new Category { CategoryName = name };
                service.GetAdd(model);
                txtadd.Clear();
                GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Categorys_Load_1(object sender, EventArgs e)
        {
            GetAll();
        }     

        private void dtgwList_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            dtgwList.Columns["CategoryName"].ReadOnly = true;
            if (dtgwList.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var item = (Category)dtgwList.Rows[e.RowIndex].DataBoundItem;
                    CategoryService service = new CategoryService();

                    service.Update(item);
                    GetAll();

                    MessageBox.Show("Başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (ArgumentException ex)
                {

                    MessageBox.Show(ex.Message, "Doğrulama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    btnsearch_Click(null, null);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dtgwList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            var row = dtgwList.Rows[e.RowIndex];
            if (row.DataBoundItem == null) return;

            var model = (Category)row.DataBoundItem;


            var onay = MessageBox.Show(
                $"{model.CategoryName} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    CategoryService service = new CategoryService();
                    int sonuc = service.Delete(model);

                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi");
                        // Listeyi yenile
                        btnsearch_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }
    }
}
