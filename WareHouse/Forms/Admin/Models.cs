using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Application.DTOs;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;

namespace WareHouse.Forms.Admin
{
    public partial class Models : Form
    {
        public Models()
        {
            InitializeComponent();
        }
        private void GetBrand()
        {
            BrandService service = new BrandService();
            try
            {
                List<Brand> all = service.GetAll();
                cmbList.DataSource = all;
                cmbList.DisplayMember = "BrandName";
                cmbList.ValueMember = "BrandId";

            }
            catch (Exception ex)
            {
                MessageBox.Show($"hata oluştu {ex.Message}");
            }
        }
        private void GetAll()
        {
            ModelService service = new ModelService();
            try
            {

                List<ModelDTO> all = service.GetAll();
                dtgwList.DataSource = all;
                if (all != null)
                {

                    dtgwList.DataSource = all;

                    if (dtgwList.Columns.Contains("Tires"))
                    {
                        dtgwList.Columns["Tires"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("ModelId"))
                    {
                        dtgwList.Columns["ModelId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("BrandId"))
                    {
                        dtgwList.Columns["BrandId"].Visible = false;
                    }
                    dtgwList.Columns["BrandName"].ReadOnly = true;
                    dtgwList.Columns["BrandName"].DisplayIndex = 0;
                    dtgwList.Columns["ModelName"].DisplayIndex = 1;

                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"veri getirirken hata oluştu{ex.Message}");
            }
        }
        private void dtgwList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var model = (ModelDTO)dtgwList.Rows[e.RowIndex].DataBoundItem;

                var onay = MessageBox.Show($"{model.ModelName} isimli itemi silmek istiyor musunuz?",
                                           "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    ModelService service = new ModelService();
                    int silinenId = service.Delete(model);

                    if (silinenId > 0)
                    {
                        MessageBox.Show("Başarıyla silindi.");
                        GetAll();

                        btnsearch_Click(null, null);
                    }
                }
            }
        }

        private void dtgwList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dtgwList.Columns["ModelName"].ReadOnly = true;
            if (dtgwList.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var model = (ModelDTO)dtgwList.Rows[e.RowIndex].DataBoundItem;
                    ModelService service = new ModelService();

                    service.Update(model);

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

        private void Models_Load(object sender, EventArgs e)
        {
            GetAll();
            GetBrand();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtadd.Text;
            int id = Convert.ToInt32(cmbList.SelectedValue);
            ModelService service = new ModelService();
            try
            {
                Model model = new Model { ModelName = name, BrandId = id };
                service.GetAdd(model);
                txtadd.Clear();
                GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"hata oluştu {ex.Message}");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            ModelService service = new ModelService();
            try
            {
                ModelDTO aranansize = new ModelDTO { ModelName = txtsearch.Text };
                List<ModelDTO> dTOs = service.GetSearch(aranansize);

                if (dTOs != null)
                {

                    dtgwList.DataSource = dTOs;

                    if (dtgwList.Columns.Contains("Tires"))
                    {
                        dtgwList.Columns["Tires"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("ModelId"))
                    {
                        dtgwList.Columns["ModelId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("BrandId"))
                    {
                        dtgwList.Columns["BrandId"].Visible = false;
                    }
                    dtgwList.Columns["BrandName"].ReadOnly = true;
                    dtgwList.Columns["BrandName"].DisplayIndex = 0;
                    dtgwList.Columns["ModelName"].DisplayIndex = 1;

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
    }
}
