using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;

namespace WareHouse.Forms.Admin
{
    public partial class WareHouses : Form
    {
        public WareHouses()
        {
            InitializeComponent();
        }
        private void GetAll()
        {
            WareHouseService service = new WareHouseService();
            try
            {
                List<WareHouse.Domain.Entity.WareHouse> list = service.GetAll();
                dtgwList.DataSource = list;
                if (list != null)
                {

                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("locations"))
                    {
                        dtgwList.Columns["locations"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("UserWareHouses"))
                    {
                        dtgwList.Columns["UserWareHouses"].Visible = false;
                    }
                    dtgwList.Columns["WarehouseId"].ReadOnly = true;
                    dtgwList.Columns["WarehouseId"].DisplayIndex = 0;
                    dtgwList.Columns["WarehouseName"].DisplayIndex = 1;
                    dtgwList.Columns["WarehouseAdress"].DisplayIndex =2;

                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }


            }
            catch (Exception ex) { throw new Exception($"hata:{ex.Message}"); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtadd.Text;
            string adress = txtadress.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(adress))
            {
                MessageBox.Show("lütfen tüm alanları doldurunuz");
            }
            WareHouseService service = new WareHouseService();
            try
            {
                WareHouse.Domain.Entity.WareHouse model = new WareHouse.Domain.Entity.WareHouse { WarehouseName = name, WarehouseAdress = adress };
                service.Add(model);
                txtadd.Clear();
                txtadress.Clear();
                GetAll();
                MessageBox.Show("Kayıt başarılı");

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            WareHouseService service = new WareHouseService();
            try
            {
                WareHouse.Domain.Entity.WareHouse search = new WareHouse.Domain.Entity.WareHouse { WarehouseName = txtsearch.Text };
                List<WareHouse.Domain.Entity.WareHouse> list = service.GetSearch(search);

                if (list != null)
                {

                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("locations"))
                    {
                        dtgwList.Columns["locations"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("UserWareHouses"))
                    {
                        dtgwList.Columns["UserWareHouses"].Visible = false;
                    }
                    dtgwList.Columns["WarehouseId"].ReadOnly = true;
                    dtgwList.Columns["WarehouseId"].DisplayIndex = 0;
                    dtgwList.Columns["WarehouseName"].DisplayIndex = 1;
                    dtgwList.Columns["WarehouseAdress"].DisplayIndex = 2;

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

        private void WareHouses_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void dtgwList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            var row = dtgwList.Rows[e.RowIndex];
            if (row.DataBoundItem == null) return;

            var model = (WareHouse.Domain.Entity.WareHouse)row.DataBoundItem;


            var onay = MessageBox.Show(
                $"{model.WarehouseName} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    WareHouseService service = new WareHouseService();
                    int sonuc = service.Delete(model);
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi");                     
                        btnsearch_Click(null, null);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Silme sırasında bir hata oluştu: " + ex.Message);
                }
            }
        }

        private void dtgwList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dtgwList.Columns["WareHouseId"].ReadOnly = true;
            if (dtgwList.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var item = (WareHouse.Domain.Entity.WareHouse)dtgwList.Rows[e.RowIndex].DataBoundItem;
                    WareHouseService service = new WareHouseService();

                    service.Update(item);

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
    }
}
