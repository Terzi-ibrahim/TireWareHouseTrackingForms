using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WareHouse.Application.DTOs;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;


namespace WareHouse.Forms.Admin
{
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
        }
        private void GetAll()
        {
            LocationService service = new LocationService();
            try
            {
                List<LocationDTO> list = service.GetAll();
                dtgwList.DataSource = list;
                if (list != null)
                {
                    dtgwList.DataSource = list;
                    dtgwList.Columns["LocationId"].ReadOnly = true;
                    dtgwList.Columns["WareHouseId"].ReadOnly = true;
                    dtgwList.Columns["WareHouseName"].ReadOnly = true;
                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
        private void GetWareHouse()
        {

            WareHouseService service = new WareHouseService();
            try
            {
                List<WareHouse.Domain.Entity.WareHouse> repo = service.GetAll();

                cmbwarehouse.DataSource = repo;
                cmbwarehouse.DisplayMember = "WareHouseName";
                cmbwarehouse.ValueMember = "WareHouseId";

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string baz = cmbaz.SelectedItem.ToString();
            string raf = cmbraf.SelectedItem.ToString();
            string tamAdres = $"{baz}-{raf}";
            int wrhs = (int)cmbwarehouse.SelectedValue;
            if (cmbaz.SelectedItem == null && cmbraf.SelectedItem == null && cmbwarehouse.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapın!");
            }
            LocationService service = new LocationService();
            try
            {
                LocationDTO add = new LocationDTO { LocationName = tamAdres, WareHouseId = wrhs };
                service.GetAdd(add);
                GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void Locations_Load(object sender, EventArgs e)
        {

            for (char c = 'A'; c <= 'Z'; c++)
            {
                cmbaz.Items.Add(c.ToString());
            }


            for (int i = 1; i <= 50; i++)
            {
                cmbraf.Items.Add(i.ToString("D2"));
            }


            if (cmbaz.Items.Count > 0) cmbaz.SelectedIndex = 0;
            if (cmbraf.Items.Count > 0) cmbraf.SelectedIndex = 0;
            GetAll();
            GetWareHouse();
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            LocationService service = new LocationService();
            try
            {
                LocationDTO search = new LocationDTO { LocationName = txtsearch.Text };
                List<LocationDTO> list = service.GetSearch(search);

                if (list != null)
                {

                    dtgwList.DataSource = list;
                    dtgwList.Columns["LocationId"].ReadOnly = true;
                    dtgwList.Columns["WareHouseId"].ReadOnly = true;
                    dtgwList.Columns["WareHouseName"].ReadOnly = true;
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

        private void dtgwList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            var row = dtgwList.Rows[e.RowIndex];
            if (row.DataBoundItem == null) return;

            var model = (LocationDTO)row.DataBoundItem;


            var onay = MessageBox.Show(
                $"{model.LocationName} isimli kategoriyi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    LocationService service = new LocationService();
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
            dtgwList.Columns["LocationId"].ReadOnly = true;
            dtgwList.Columns["WareHouseId"].ReadOnly = true;
            dtgwList.Columns["WareHouseName"].ReadOnly = true;
            if (dtgwList.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var item = (LocationDTO)dtgwList.Rows[e.RowIndex].DataBoundItem;
                    LocationService service = new LocationService();

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
