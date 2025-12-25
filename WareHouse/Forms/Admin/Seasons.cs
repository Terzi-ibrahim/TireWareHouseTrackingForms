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
    public partial class Seasons : Form
    {
        public Seasons()
        {
            InitializeComponent();
        }
        private void GetAll()
        {
            SeasonService service = new SeasonService();
            try
            {
                List<Season> seasons = service.GetAll();
                if (seasons != null)
                {
                    dtgwList.DataSource = seasons;
                }
                dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SeasonService service = new SeasonService();
            string name = txtadd.Text;
            if (string.IsNullOrEmpty(name)) { MessageBox.Show("lütfen bir mevsim yazınız"); }
            try
            {
                Season season = new Season { SeasonName = name };
                service.Add(season);
                txtadd.Clear();
                GetAll();
                MessageBox.Show("Kayıt Başarılı");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Seasons_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void dtgwList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;


            var row = dtgwList.Rows[e.RowIndex];
            if (row.DataBoundItem == null) return;

            var model = (Season)row.DataBoundItem;


            var onay = MessageBox.Show(
                $"{model.SeasonName} isimli mevsimi silmek istediğinize emin misiniz?",
                "Silme Onayı",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    SeasonService service = new SeasonService();
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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            SeasonService service = new SeasonService();
            try
            {
                Season search = new Season { SeasonName = txtsearch.Text };
                List<Season> list = service.GetSearch(search);

                if (list != null)
                {

                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("Tires"))
                    {
                        dtgwList.Columns["Tires"].Visible = false;
                    }
                    dtgwList.Columns["SeasonId"].ReadOnly = true;
                    dtgwList.Columns["SeasonId"].DisplayIndex = 0;
                    dtgwList.Columns["SeasonName"].DisplayIndex = 1;

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

        private void dtgwList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dtgwList.Columns["SeasonId"].ReadOnly = true;
            if (dtgwList.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var item = (Season)dtgwList.Rows[e.RowIndex].DataBoundItem;
                    SeasonService service = new SeasonService();

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
    }
}
