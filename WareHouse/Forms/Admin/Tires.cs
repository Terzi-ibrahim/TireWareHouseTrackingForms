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
    public partial class Tires : Form
    {
        public Tires()
        {
            InitializeComponent();
        }
        public void GetAll()
        {
            TireService service = new TireService();
            try
            {
                List<TireDTO> list = service.GetAll();
                dtgwList.DataSource = list;
                if (list != null)
                {

                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("CategoryId"))
                    {
                        dtgwList.Columns["CategoryId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("TireSizeId"))
                    {
                        dtgwList.Columns["TireSizeId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("ModelId"))
                    {
                        dtgwList.Columns["ModelId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("SeasonId"))
                    {
                        dtgwList.Columns["SeasonId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("BrandId"))
                    {
                        dtgwList.Columns["BrandId"].Visible = false;
                    }
                    dtgwList.Columns["TireId"].DisplayIndex = 0;
                    dtgwList.Columns["TireSizeName"].DisplayIndex = 1;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 2;
                    dtgwList.Columns["BrandName"].DisplayIndex = 3;
                    dtgwList.Columns["ModelName"].DisplayIndex = 4;
                    dtgwList.Columns["SeasonName"].DisplayIndex = 5;



                    dtgwList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                }
                else
                {

                    dtgwList.DataSource = null;
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void dtgwList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtgwList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void GetLoad()
        {
            CategoryService ctgry = new CategoryService();
            ModelService mdl = new ModelService();
            TireSizeService trs = new TireSizeService();
            SeasonService mv = new SeasonService();
            BrandService br = new BrandService();
            try
            {
                List<ModelDTO> lm = mdl.GetAll();
                List<WareHouse.Domain.Entity.TireSize> lt = trs.GetAll();
                List<Category> lc = ctgry.GetAll();
                List<Season> mvs = mv.GetAll();
                List<Brand> brn = br.GetAll();

                cmbMarka.DataSource = brn.ToList();
                cmbMarka.DisplayMember = "BrandName";
                cmbMarka.ValueMember = "BrandId";

                cmbgunMarka.DataSource = brn.ToList();
                cmbgunMarka.DisplayMember = "BrandName";
                cmbgunMarka.ValueMember = "BrandId";

                cmbmevsim.DataSource = mvs.ToList();
                cmbmevsim.DisplayMember = "SeasonName";
                cmbmevsim.ValueMember = "SeasonID";


                cmbgunmevsim.DataSource = mvs.ToList();
                cmbgunmevsim.DisplayMember = "SeasonName";
                cmbgunmevsim.ValueMember = "SeasonID";


                cmbcategory.DataSource = lc.ToList();
                cmbcategory.DisplayMember = "CategoryName";
                cmbcategory.ValueMember = "CategoryId";

                cmguncat.DataSource = lc.ToList();
                cmguncat.DisplayMember = "CategoryName";
                cmguncat.ValueMember = "CategoryId";


                cmbtiresize.DataSource = lt.ToList();
                cmbtiresize.DisplayMember = "TireSizeName";
                cmbtiresize.ValueMember = "TireSizeId";

                cmbgunebat.DataSource = lt.ToList();
                cmbgunebat.DisplayMember = "TireSizeName";
                cmbgunebat.ValueMember = "TireSizeId";


                cmbmodel.DataSource = lm.ToList();
                cmbmodel.DisplayMember = "ModelName";
                cmbmodel.ValueMember = "ModelId";

                cmbgunmod.DataSource = lm.ToList();
                cmbgunmod.DisplayMember = "ModelName";
                cmbgunmod.ValueMember = "ModelId";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            int md = (int)cmbmodel.SelectedValue;
            int ct = (int)cmbcategory.SelectedValue;
            int ts = (int)cmbtiresize.SelectedValue;
            int mv = (int)cmbmevsim.SelectedValue;

            if (cmbtiresize.SelectedItem == null && cmbcategory.SelectedItem == null && cmbmodel.SelectedItem == null && cmbmevsim.SelectedItem == null)
            {
                MessageBox.Show("Lütfen tüm seçimleri yapın!");
            }
            TireService service = new TireService();
            try
            {
                TireDTO add = new TireDTO { ModelId = md, CategoryId = ct, TireSizeId = ts, SeasonId = mv };
                service.GetAdd(add);
                GetAll();
                MessageBox.Show("Kayıt Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string name = txtsearch.Text;
            TireService service = new TireService();
            try
            {
                TireDTO search = new TireDTO { TireSizeName = txtsearch.Text };
                List<TireDTO> list = service.GetSearch(search);

                if (list != null)
                {

                    dtgwList.DataSource = list;
                    if (dtgwList.Columns.Contains("CategoryId"))
                    {
                        dtgwList.Columns["CategoryId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("TireSizeId"))
                    {
                        dtgwList.Columns["TireSizeId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("ModelId"))
                    {
                        dtgwList.Columns["ModelId"].Visible = false;
                    }
                    if (dtgwList.Columns.Contains("SeasonId"))
                    {
                        dtgwList.Columns["SeasonId"].Visible = false;
                    }
                    dtgwList.Columns["TireId"].DisplayIndex = 0;
                    dtgwList.Columns["TireSizeName"].DisplayIndex = 1;
                    dtgwList.Columns["CategoryName"].DisplayIndex = 2;
                    dtgwList.Columns["BrandName"].DisplayIndex = 3;
                    dtgwList.Columns["ModelName"].DisplayIndex = 4;
                    dtgwList.Columns["SeasonName"].DisplayIndex = 5;


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

        private void Tires_Load(object sender, EventArgs e)
        {
            GetAll();
            GetLoad();
        }

        private void dtgwList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgwList.Rows[e.RowIndex];


                materialLabel10.Text = row.Cells["TireId"].Value.ToString();

                cmguncat.SelectedIndex = cmguncat.FindStringExact(row.Cells["CategoryName"].Value.ToString());
                cmbgunebat.SelectedIndex = cmbgunebat.FindStringExact(row.Cells["TireSizeName"].Value.ToString());
                cmbgunmod.SelectedIndex = cmbgunmod.FindStringExact(row.Cells["ModelName"].Value.ToString());
                cmbgunmevsim.SelectedIndex = cmbgunmevsim.FindStringExact(row.Cells["SeasonName"].Value.ToString());

                btngun.Enabled = true;
                btndelete.Enabled = true;
                MessageBox.Show("Veriler düzenleme için yukarı taşındı. Düzenleyip 'Güncelle' butonuna basın.");
            }
        }


        private void btngun_Click_1(object sender, EventArgs e)
        {
            TireService service = new TireService();
            try
            {
                TireDTO updateModel = new TireDTO();
                updateModel.TireId = Convert.ToInt32(materialLabel10.Text);
                updateModel.CategoryId = Convert.ToInt32(cmguncat.SelectedValue);
                updateModel.TireSizeId = Convert.ToInt32(cmbgunebat.SelectedValue);
                updateModel.ModelId = Convert.ToInt32(cmbgunmod.SelectedValue);
                updateModel.SeasonId = Convert.ToInt32(cmbgunmevsim.SelectedValue);

                service.Update(updateModel);
                dtgwList.DataSource = service.GetAll();

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

        private void btndelete_Click(object sender, EventArgs e)
        {

            TireService service = new TireService();
            try
            {
                TireDTO updateModel = new TireDTO();
                updateModel.TireId = Convert.ToInt32(materialLabel10.Text);

                service.Delete(updateModel);
                dtgwList.DataSource = service.GetAll();

                MessageBox.Show("Başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMarka.SelectedValue != null && int.TryParse(cmbMarka.SelectedValue.ToString(), out int selectedBrandId))
            {
                ModelService mdl = new ModelService();


                var filteredModels = mdl.GetAll().Where(x => x.BrandId == selectedBrandId).ToList();

                cmbmodel.DataSource = null;
                cmbmodel.DataSource = filteredModels;
                cmbmodel.DisplayMember = "ModelName";
                cmbmodel.ValueMember = "ModelId";
            }
        }

        private void cmbgunMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbgunMarka.SelectedValue != null && int.TryParse(cmbgunMarka.SelectedValue.ToString(), out int selectedBrandId))
            {
                ModelService mdl = new ModelService();


                var filteredModels = mdl.GetAll().Where(x => x.BrandId == selectedBrandId).ToList();

                cmbgunmod.DataSource = null;
                cmbgunmod.DataSource = filteredModels;
                cmbgunmod.DisplayMember = "ModelName";
                cmbgunmod.ValueMember = "ModelId";
            }
        }
    }
}
