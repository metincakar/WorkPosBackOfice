using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.PLinq.Helpers;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using WorkPosBackOfice.Forms;
using WorkPosBackOfice.Modules;
using WorkPosBLL.Concrete;
using WorkPosDal.EntityFrameWork;

namespace WorkPosBackOfice
{
    public partial class FrmStokDetay : RibbonForm
    {
        private PRODUCT_BRANDS _brand;
        private PRODUCT_BRANDS_MODEL _model;
        private SETUP_UNIT _birim;
        private PRODUCT_CAT _urunKategori;
        private DataRowView selectedDataGridView;

        private SetupBll<SETUP_MONEY> setupBllMoney;
        private MoneyBll moneyBll;

        private ModelProduct.ViewStock _viewProduct;
        public FrmStokDetay()
        {
            InitializeComponent();
            Init();

        }
        public FrmStokDetay(ModelProduct.ViewStock viewProduct)
        {
            InitializeComponent();
            this._viewProduct = viewProduct;
            Init();

        }
        private void toastNotificationsManager1_Activated(object sender, DevExpress.XtraBars.ToastNotifications.ToastNotificationEventArgs e)
        {
            switch (e.NotificationID.ToString())
            {
                case "3b7fcd8b-a1e0-4ff5-83ce-023cdf6be24b":
                    MessageBox.Show("Notification #1 Clicked");
                    break;
                case "66501f90-ac6b-440d-bf73-483c5ab22143":
                    MessageBox.Show("Notification #2 Clicked");
                    break;
            }
        }
        private void Init()
        {
           moneyBll=new MoneyBll();
            lookUpEditPbAlis.Properties.DataSource = moneyBll.GetMoneyIEnumerable();
            lookUpEditPbAlis.Properties.DisplayMember = "Money";
            lookUpEditPbAlis.Properties.ValueMember = "MoneyId";
            lookUpEditPbAlis.Properties.PopulateColumns();
            lookUpEditPbAlis.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(lookUpEditPbAlis.Properties.DisplayMember));
            lookUpEditPbAlis.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(lookUpEditPbAlis.Properties.ValueMember));
            lookUpEditPbAlis.Properties.Columns[lookUpEditPbAlis.Properties.ValueMember].Visible = false;
            lookUpEditPbAlis.EditValue = 1;


            lookUpEditPbSatis.Properties.DataSource = moneyBll.GetMoneyIEnumerable();
            lookUpEditPbSatis.Properties.DisplayMember = "Money";
            lookUpEditPbSatis.Properties.ValueMember = "MoneyId";
            lookUpEditPbSatis.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(lookUpEditPbSatis.Properties.DisplayMember));
            lookUpEditPbSatis.Properties.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo(lookUpEditPbSatis.Properties.ValueMember));
            lookUpEditPbSatis.Properties.Columns[lookUpEditPbSatis.Properties.ValueMember].Visible = false;
            lookUpEditPbSatis.EditValue = 1;

            // lookUpEdit1.Properties.Columns["MoneyId"].Visible = false;
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
                         _brand =(PRODUCT_BRANDS)objeSec.secilenObje;
                         btnEditMarka.Text = _brand.BRAND_NAME;
                     }
                    break;
                case ModelObjects.ObjectEnum.Model:
                    objeSec = new FrmObjeList(ModelObjects.ObjectEnum.Model, 0);
                    dialogResult = objeSec.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        _model = (PRODUCT_BRANDS_MODEL)objeSec.secilenObje;
                        btnEditModel.Text = _model.MODEL_NAME;
                    }
                    break;
                case ModelObjects.ObjectEnum.Birim:
                    objeSec = new FrmObjeList(ModelObjects.ObjectEnum.Birim, 0);
                    dialogResult = objeSec.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        _birim = (SETUP_UNIT)objeSec.secilenObje;
                        btnEditBirim.Text = _birim.UNIT;
                    }
                    break;
                case ModelObjects.ObjectEnum.UrunKategori:
                    objeSec = new FrmObjeList(ModelObjects.ObjectEnum.UrunKategori, 0);
                    dialogResult = objeSec.ShowDialog();
                    if (dialogResult == DialogResult.OK)
                    {
                        _urunKategori = (PRODUCT_CAT)objeSec.secilenObje;
                        btnEditKategori.Text = _urunKategori.PRODUCT_CAT1;
                    }
                    break;
            }
                
              
                
        }

        private void FrmStokDetay_Load(object sender, EventArgs e)
        {
            SayfaIlkAyarlar();
        }

        void SayfaIlkAyarlar()
        {
            if (_viewProduct != null)
            {
                _birim=new SETUP_UNIT {UNIT_ID = _viewProduct.UnitId, UNIT = _viewProduct.Birim};
                _urunKategori = new PRODUCT_CAT
                {
                    PRODUCT_CATID = _viewProduct.ProductCatId,
                    PRODUCT_CAT1 = _viewProduct.ProductCat,
                    HIERARCHY = _viewProduct.Hierarchy
                };
                txtUrunAd.Text = _viewProduct.StokAd;
                btnEditBirim.Text = _birim.UNIT;
                btnEditKategori.Text = _urunKategori.PRODUCT_CAT1;
                
            }
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
            var modelProduct=new ModelProduct();

            string message = string.Empty;

           // modelProduct.TextBoslukKontrol_DevExpress(t,dxErrorProvider1,"Stok adı alanı boş olmaz!");

            if (!dxValidationProvider1.Validate())
            {
            
                return;
            }
            int pid = 0;
            var product=new PRODUCT
            {
                BRAND_ID = _brand.BRAND_ID,
                PRODUCT_NAME = txtUrunAd.Text,
                PRODUCT_CATID = _urunKategori.PRODUCT_CATID,
                SHORT_CODE_ID = _model.MODEL_ID,
                PRODUCT_CODE = "123456",
                PRODUCT_CODE_2 = "1234567",
                PRODUCT_STATUS =true
            };

            var productUnit = new PRODUCT_UNIT
            {
                ADD_UNIT = _birim.UNIT,
                MAIN_UNIT = _birim.UNIT,
                MAIN_UNIT_ID = _birim.UNIT_ID,
                MULTIPLIER = 1,
                IS_MAIN = true,
                PRODUCT_UNIT_STATUS = true
            };
            var priceStandart = new PRICE_STANDART
            {
                PRICE =double.Parse(txtStandartSatis.Text),
                PRICE_KDV = double.Parse(txtStandartSatis.Text), 
                PRICESTANDART_STATUS = true
            };

       
            modelProduct.AddProduct(product, productUnit, new STOCKS(), priceStandart);

                  toastNotificationsManager1.ShowNotification(toastNotificationsManager1.Notifications[1]);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
