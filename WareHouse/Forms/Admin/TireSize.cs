using System;
using System.Collections.Generic;
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
        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            TireSizeService service = new TireSizeService();
            try
            {
                WareHouse.Domain.Entity.TireSize aranansize = new WareHouse.Domain.Entity.TireSize { TireSizeName = txtsearch.Text };
                List<WareHouse.Domain.Entity.TireSize> tiresizelist = service.GetTireSize(aranansize);

                if (tiresizelist != null)
                {

                    dtgwTiresize.DataSource = tiresizelist;

                    if (dtgwTiresize.Columns.Contains("Tires"))
                    {
                        dtgwTiresize.Columns["Tires"].Visible = false;
                    }
                    dtgwTiresize.Columns["TireSizeId"].ReadOnly = true;
                }
                else
                {

                    dtgwTiresize.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!mskadd.MaskFull)
            {
                MessageBox.Show("Lütfen formatı eksiksiz doldurunuz! (Örn: 205-55-16)");
                mskadd.Focus();
                return;
            }
            string add = mskadd.Text;
            TireSizeService service = new TireSizeService();
            try
            {
                WareHouse.Domain.Entity.TireSize tire = new Domain.Entity.TireSize
                {
                    TireSizeName = add
                };
                service.Add(tire);
                GetAllTireSize();
                MessageBox.Show("Ebat Başarılı İle Eklendi");
                mskadd.Text = "";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void dtgwTiresize_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                var size = (WareHouse.Domain.Entity.TireSize)dtgwTiresize.Rows[e.RowIndex].DataBoundItem;

                var onay = MessageBox.Show($"{size.TireSizeName} isimli ebat silmek istiyor musunuz?",
                                           "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    TireSizeService service = new TireSizeService();
                    int silinenId = service.Delete(size);

                    if (silinenId > 0)
                    {
                        MessageBox.Show("Ebat başarıyla silindi.");

                        btnsearch_Click(null, null);
                    }
                }
            }
        }
        private void dtgwTiresize_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dtgwTiresize.Columns["TireSizeId"].ReadOnly = true;
            if (dtgwTiresize.DataSource != null && e.RowIndex >= 0)
            {
                try
                {
                    var size = (WareHouse.Domain.Entity.TireSize)dtgwTiresize.Rows[e.RowIndex].DataBoundItem;
                    TireSizeService service = new TireSizeService();

                    service.Update(size);

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
        private void GetAllTireSize()
        {
            TireSizeService service = new TireSizeService();
            try
            {

                List<WareHouse.Domain.Entity.TireSize> tiresizelist = service.GetAll();

                if (tiresizelist != null)
                {

                    dtgwTiresize.DataSource = tiresizelist;

                    if (dtgwTiresize.Columns.Contains("Tires"))
                    {
                        dtgwTiresize.Columns["Tires"].Visible = false;
                    }
                    dtgwTiresize.Columns["TireSizeId"].ReadOnly = true;

                }
                else
                {

                    dtgwTiresize.DataSource = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void TireSize_Load(object sender, EventArgs e)
        {
            GetAllTireSize();
        }
    }
}
