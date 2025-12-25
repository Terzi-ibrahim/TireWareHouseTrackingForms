using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Application.DTOs;
using WareHouse.Application.Services;
using WareHouse.Domain.Entity;

namespace WareHouse.Forms.Admin
{
    public partial class Stocks : Form
    {
        public Stocks()
        {
            InitializeComponent();
        }
        private void GetAll()
        {
            StockService service = new StockService();
            try
            {
                List<StockDTO> list = service.GetAll();
                dtgwList.DataSource = list;
                if (list != null)
                {
                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("TireId"))
                    {
                        dtgwList.Columns["TireId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("LocationId"))
                    {
                        dtgwList.Columns["LocationId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("StockId"))
                    {
                        dtgwList.Columns["StockId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("WarehouseId"))
                    {
                        dtgwList.Columns["WarehouseId"].Visible = false;
                    }
                    dtgwList.Columns["Amount"].DisplayIndex = 0;
                    dtgwList.Columns["TireSizeName"].DisplayIndex = 1;
                    dtgwList.Columns["LocationName"].DisplayIndex = 2;
                    dtgwList.Columns["Dot"].DisplayIndex = 3;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 4;
                    dtgwList.Columns["BrandName"].DisplayIndex = 5;
                    dtgwList.Columns["ModelName"].DisplayIndex = 6;

                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void GetLoad()
        {
            TireService t = new TireService();
            LocationService l = new LocationService();
            WareHouseService d = new WareHouseService();
            try
            {

                List<TireDTO> tr = t.GetAll();
                List<LocationDTO> lc = l.GetAll();
                List<WareHouse.Domain.Entity.WareHouse> dt = d.GetAll();


                cmbdepo.DataSource = dt.ToList();
                cmbdepo.DisplayMember = "WarehouseName";
                cmbdepo.ValueMember = "WarehouseId";
              

                cmbgundepo.DataSource = dt.ToList();
                cmbgundepo.DisplayMember = "WarehouseName";
                cmbgundepo.ValueMember = "WarehouseId";


                cmbtire.DataSource = tr.ToList();
                cmbtire.DisplayMember = "TireFullInfo";
                cmbtire.ValueMember = "TireId";


                cmbguntire.DataSource = tr.ToList();
                cmbguntire.DisplayMember = "TireFullInfo";
                cmbguntire.ValueMember = "TireId";


                cmbloc.DataSource = lc.ToList();
                cmbloc.DisplayMember = "LocationName";
                cmbloc.ValueMember = "LocationId";

                cmbgunloc.DataSource = lc.ToList();
                cmbgunloc.DisplayMember = "LocationName";
                cmbgunloc.ValueMember = "LocationId";



            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text.Trim();
            if (name.Length == 7 && long.TryParse(name, out _))
            {

                name = $"{name.Substring(0, 3)}-{name.Substring(3, 2)}-{name.Substring(5, 2)}";
            }
            StockService service = new StockService();
            try
            {
                StockDTO search = new StockDTO { TireSizeName = txtsearch.Text };
                List<StockDTO> list = service.GetSearch(search);

                if (list != null)
                {

                    dtgwList.DataSource = list;

                    if (dtgwList.Columns.Contains("TireId"))
                    {
                        dtgwList.Columns["TireId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("LocationId"))
                    {
                        dtgwList.Columns["LocationId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("StockId"))
                    {
                        dtgwList.Columns["StockId"].Visible = false;
                    }
                    dtgwList.Columns["Amount"].DisplayIndex = 0;
                    dtgwList.Columns["TireSizeName"].DisplayIndex = 1;
                    dtgwList.Columns["LocationName"].DisplayIndex = 2;
                    dtgwList.Columns["Dot"].DisplayIndex = 3;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 4;
                    dtgwList.Columns["BrandName"].DisplayIndex = 5;
                    dtgwList.Columns["ModelName"].DisplayIndex = 6;


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

        private void Stocks_Load(object sender, EventArgs e)
        {
            GetLoad();
            GetAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int tr = (int)cmbtire.SelectedValue;
            int lc = (int)cmbloc.SelectedValue;
            int amount = (int)nmbadd.Value;
            string dot = mskdot.Text;


            StockService service = new StockService();
            try
            {
                if (cmbtire.SelectedValue == null || cmbloc.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen Lastik, Depo ve Raf seçimini yapınız!");
                    return;
                }
                if (amount <= 0)
                {
                    MessageBox.Show("stok sayısı 0 ve 0dan düşük olamaz ");
                    return;
                }
                if (!mskdot.MaskCompleted)
                {
                    MessageBox.Show("Lütfen DOT tarihini tam giriniz (Örn: 25-04)!");
                    return;
                }
                if (cmbtire.SelectedItem == null && cmbloc.SelectedItem == null && mskdot.Text == null && mskprice.Text == null)
                {
                    MessageBox.Show("Lütfen tüm değerleri doldurunn!");
                    return;
                }
                StockDTO add = new StockDTO { Dot = dot, Amount = amount, LocationId = lc, TireId = tr };
                service.GetAdd(add);
                GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtgwList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow row = dtgwList.Rows[e.RowIndex];

                    // StockId
                    materialLabel10.Text = row.Cells["StockId"].Value.ToString();

                    // Depo Seçimi (ValueMember int ise Convert şart)
                    if (row.Cells["WarehouseId"].Value != null)
                    {
                        int whId = Convert.ToInt32(row.Cells["WarehouseId"].Value);
                        cmbgundepo.SelectedValue = whId;
                    }

                    // Lastik Seçimi
                    if (row.Cells["TireId"].Value != null)
                    {
                        cmbguntire.SelectedValue = Convert.ToInt32(row.Cells["TireId"].Value);
                    }

                    // DOT ve Miktar
                    mskgundot.Text = row.Cells["Dot"].Value?.ToString();
                    nmbupdate.Value = Convert.ToDecimal(row.Cells["Amount"].Value);

                    // Konum Seçimi (Depo değişiminden sonra yüklendiği için en son bu yapılmalı)
                    if (row.Cells["LocationId"].Value != null)
                    {
                        cmbgunloc.SelectedValue = Convert.ToInt32(row.Cells["LocationId"].Value);
                    }

                    btngun.Enabled = true;
                    btndelete.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veri yüklenirken hata oluştu: " + ex.Message);
                }
            }
        }

        private void btngun_Click(object sender, EventArgs e)
        {
            int tr = (int)cmbguntire.SelectedValue;
            int lc = (int)cmbgunloc.SelectedValue;
            int amount = (int)nmbupdate.Value;
            string dot = mskgundot.Text;
            StockService service = new StockService();
            try
            {
                if (amount <= 0)
                {
                    MessageBox.Show("stok sayısı 0 ve 0dan düşük olamaz ");
                    return;
                }
                if (!mskgundot.MaskCompleted)
                {
                    MessageBox.Show("Lütfen DOT tarihini tam giriniz (Örn: 25-04)!");
                    return;
                }
                if (cmbguntire.SelectedItem == null && cmbgunloc.SelectedItem == null && mskgundot.Text == null && nmbupdate.Text == null)
                {
                    MessageBox.Show("Lütfen tüm değerleri doldurunn!");
                    return;
                }
                StockDTO updateModel = new StockDTO();
                updateModel.StockId = Convert.ToInt32(materialLabel10.Text);
                updateModel.LocationId = lc;
                updateModel.TireId = tr;
                updateModel.Amount = amount;
                updateModel.Dot = dot;

                service.Update(updateModel);
                GetAll();
                MessageBox.Show("Başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btngun.Enabled = false;
                btndelete.Enabled = false;


                materialLabel10.Text = "Güncellenecek Stock";
                mskgundot.Clear();
                nmbupdate.Value = 0;
                cmbguntire.SelectedIndex = -1;
                cmbgunloc.SelectedIndex = -1;
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            StockService service = new StockService();

            try
            {

                string lastikBilgisi = dtgwList.CurrentRow.Cells["TireSizeName"].Value.ToString();

                DialogResult onay = MessageBox.Show(
                    $"{lastikBilgisi} isimli stoğu silmek istediğinize emin misiniz?",
                    "Silme Onayı",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );


                if (onay == DialogResult.Yes)
                {
                    StockDTO deleteModel = new StockDTO();
                    deleteModel.StockId = Convert.ToInt32(materialLabel10.Text);

                    service.Delete(deleteModel);


                    dtgwList.DataSource = service.GetAll();

                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    materialLabel10.Text = "0";
                    btngun.Enabled = false;
                    btndelete.Enabled = false;
                }
                else
                {

                    MessageBox.Show("Silme işlemi iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        private void cmbdepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbdepo.SelectedValue != null && cmbdepo.SelectedIndex != -1)
            {

                if (int.TryParse(cmbdepo.SelectedValue.ToString(), out int warehouseId))
                {
                    LocationService l = new LocationService();

                    var filteredLocs = l.GetAll().Where(x => x.WareHouseId == warehouseId).ToList();

                    cmbloc.DataSource = filteredLocs;
                    cmbloc.DisplayMember = "LocationName";
                    cmbloc.ValueMember = "LocationId";
                }
            }
        }

        private void cmbgundepo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbgundepo.SelectedValue != null && cmbgundepo.SelectedIndex != -1)
            {

                if (int.TryParse(cmbgundepo.SelectedValue.ToString(), out int warehouseId))
                {
                    LocationService l = new LocationService();

                    var filteredLocs = l.GetAll().Where(x => x.WareHouseId == warehouseId).ToList();

                    cmbgunloc.DataSource = filteredLocs;
                    cmbgunloc.DisplayMember = "LocationName";
                    cmbgunloc.ValueMember = "LocationId";
                }
            }
        }
    }
}
