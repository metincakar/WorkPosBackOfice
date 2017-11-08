using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkPosBackOfice.ModulObject;
using WorkPosDb.EntityFrameWork;

namespace WorkPosBackOfice
{
    public partial class FrmStokDetay : Form
    {
        private ModelObjects.Brand _brand;
        private ModelObjects.Model _model;
        private ModelObjects.Birim _birim;
        private ModelObjects.UrunKategori _urunKategori;
        private DataRowView selectedDataGridView;
        public FrmStokDetay()
        {
            InitializeComponent();
            
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ObjeSec(ModelObjects.ObjectEnum.Marka);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditModel_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ObjeSec(ModelObjects.ObjectEnum.Model);
        }

        void ObjeSec(ModelObjects.ObjectEnum objectEnum)
        {
            DialogResult dialogResult;
            FrmObjeList objeSec;
            switch (objectEnum)
            {
                case ModelObjects.ObjectEnum.Marka:
                     objeSec = new FrmObjeList(ModelObjects.ObjectEnum.Marka, 0);
                     dialogResult = objeSec.ShowDialog();
                     if (dialogResult == DialogResult.OK)
                     {
                         _brand=new ModelObjects.Brand();
                         selectedDataGridView = (DataRowView)objeSec.secilenObje;
                         _brand.MarkaId = (int)selectedDataGridView["Id"];
                         _brand.Marka = (string)selectedDataGridView["Marka"];
                         btnEditMarka.Text = _brand.Marka;
                     }
                    break;
                case ModelObjects.ObjectEnum.Model:
                    objeSec = new FrmObjeList(ModelObjects.ObjectEnum.Model, 0);
                    dialogResult = objeSec.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        _model=new ModelObjects.Model();
                        selectedDataGridView = (DataRowView)objeSec.secilenObje;
                        _model.ModelId = (int)selectedDataGridView["Id"];
                        _model.ModelName = (string)selectedDataGridView["Model"];
                         btnEditModel.Text = _model.ModelName;
                    }
                    break;
                case ModelObjects.ObjectEnum.Birim:
                    objeSec = new FrmObjeList(ModelObjects.ObjectEnum.Birim, 0);
                    dialogResult = objeSec.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        _birim = (ModelObjects.Birim)objeSec.secilenObje;
                        btnEditBirim.Text = _birim.BirimAd;
                    }
                    break;
                case ModelObjects.ObjectEnum.UrunKategori:
                    objeSec = new FrmObjeList(ModelObjects.ObjectEnum.UrunKategori, 0);
                    dialogResult = objeSec.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        _urunKategori = (ModelObjects.UrunKategori)objeSec.secilenObje;
                        btnEditKategori.Text = _urunKategori.Kategori;
                    }
                    break;
            }
                
              
                
        }

        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            sayfaIlkAyarlar();
        }

        void sayfaIlkAyarlar()
        {
            
        }

        private void btnEditBirim_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ObjeSec(ModelObjects.ObjectEnum.Birim);
        }

        private void btnEditKategori_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ObjeSec(ModelObjects.ObjectEnum.UrunKategori);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var product=new PRODUCT
            {
                BRAND_ID = _brand.MarkaId,
                PRODUCT_NAME = txtStokAd.Text,
                PRODUCT_CATID = _urunKategori.KategoriId,
                SHORT_CODE_ID = _model.ModelId
            };

            var productUnit = new PRODUCT_UNIT
            {
                ADD_UNIT = _birim.BirimAd,
                MAIN_UNIT = _birim.BirimAd,
                MAIN_UNIT_ID = _birim.BirimId,
                MULTIPLIER = 1,
                IS_MAIN = true,
                PRODUCT_UNIT_STATUS = true
            };
            var priceStandart = new PRICE_STANDART
            {
                PRICE = 1, 
                PRICE_KDV = 1.5, 
                PRICESTANDART_STATUS = true
            };
        }
    }
}
