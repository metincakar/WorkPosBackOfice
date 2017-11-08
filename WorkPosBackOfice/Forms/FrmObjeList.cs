using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using WorkPosBackOfice.Modules;
using System.Data.Entity;
using WorkPosBLL.Concrete;
using WorkPosDal.EntityFrameWork;

namespace WorkPosBackOfice.Forms
{
    public partial class FrmObjeList : Form{
        private ModelObjects modelObjects;
        public object secilenObje;
        private ModelObjects.ObjectEnum objectEnum;
        private int iliskiliObjeId = 0;


        //Busines logic layer
        private SetupBll<PRODUCT_BRANDS> _setupBllBrands;
        private SetupBll<PRODUCT_BRANDS_MODEL> _setupBllProductModels;
        private SetupBll<SETUP_UNIT> _setupBllUnits;
        private SetupBll<PRODUCT_CAT> _setupBllProductCats;
        public FrmObjeList(ModelObjects.ObjectEnum objectEnum, int iliskiliObjeId){
            InitializeComponent();
            this.objectEnum = objectEnum;
            iliskiliObjeId = iliskiliObjeId;
            // this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
            this.Load += Form1_Load;

            Init();
        }

        private void Init()
        {
            switch (objectEnum)
            {
                case ModelObjects.ObjectEnum.Marka:
                    _setupBllBrands = new SetupBll<PRODUCT_BRANDS>();
                     gridControl1.DataSource = _setupBllBrands.GetAllToBindingList();
                   
                    break;
                case ModelObjects.ObjectEnum.Model:
                    _setupBllProductModels = new SetupBll<PRODUCT_BRANDS_MODEL>();
                    gridControl1.DataSource = _setupBllProductModels.GetAllToBindingList();
                    break;
                case ModelObjects.ObjectEnum.Birim:
                    _setupBllUnits=new SetupBll<SETUP_UNIT>();
                    gridControl1.DataSource = _setupBllUnits.GetAllToBindingList();
                     break;
                case ModelObjects.ObjectEnum.UrunKategori:
                     _setupBllProductCats = new SetupBll<PRODUCT_CAT>();
                     gridControl1.DataSource = _setupBllProductCats.GetAllToBindingList();
                     break;

            }
            this.Text = objectEnum.ToString();
            labelControl1.Text = string.Format("Yeni {0} ekleyebilir ve {0} seçimi yapabilirsiniz.", objectEnum.ToString());

        }
        private void Update(object o)
        {
            switch (objectEnum)
            {
                case ModelObjects.ObjectEnum.Marka:
                    _setupBllBrands.Update((PRODUCT_BRANDS)o);
                    break;
                case ModelObjects.ObjectEnum.Model:
                    _setupBllProductModels.Update((PRODUCT_BRANDS_MODEL)o);
                    break;
                case ModelObjects.ObjectEnum.Birim:
                    _setupBllUnits.Update((SETUP_UNIT)o);
                    break;
                case ModelObjects.ObjectEnum.UrunKategori:
                    _setupBllProductCats.Update((PRODUCT_CAT)o);
                    break;
            }

        }
        private void Add(object o)
        {
            switch (objectEnum)
            {
                case ModelObjects.ObjectEnum.Marka:
                    _setupBllBrands.Add((PRODUCT_BRANDS)o);
                    break;
                case ModelObjects.ObjectEnum.Model:
                    _setupBllProductModels.Add((PRODUCT_BRANDS_MODEL)o);
                    break;
                case ModelObjects.ObjectEnum.Birim:
                    _setupBllUnits.Add((SETUP_UNIT)o);
                    break;
                case ModelObjects.ObjectEnum.UrunKategori:
                    _setupBllProductCats.Add((PRODUCT_CAT)o);
                    break;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
         
        }

       
        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

            if (!(gridView1.PostEditor() && gridView1.UpdateCurrentRow()))
                return;

            var view = sender as GridView;
            Object obj;
            if (e.RowHandle != GridControl.NewItemRowHandle)
                obj = view.GetRow(view.FocusedRowHandle);
            else
            {
                obj = view.GetRow(view.FocusedRowHandle);
                //obj = e.Row as DataRowView;
                //int i = Convert.ToInt32(((DataRowView)obj)["Id"]);
            }

            if (obj == null)
                return;

            if (view.IsNewItemRow(e.RowHandle))
            {
                Add(obj);
            
               // modelObjects.ObjeIslemler(objectEnum, ModelObjects.ObjectIslem.Ekle, obj, iliskiliObjeId, null);
            }
            else{
                Update(obj);
              //  modelObjects.ObjeIslemler(objectEnum, ModelObjects.ObjectIslem.Guncelle, obj, iliskiliObjeId, null);
            }
           // modelObjects.ObjeIslemler(objectEnum, ModelObjects.ObjectIslem.Listele, obj, iliskiliObjeId, gridControl1);

         
            //kaynak https://www.devexpress.com/Support/Center/Question/Details/T186471
        }

   

        private void btnMarkaSec_Click(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() != null)
                secilenObje = gridView1.GetFocusedRow();
            else
            {
               
                return;
            }
        }

      

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
            {
                int yourLastColumnIndex = gridView1.Columns.Count - 1;
            
            if (keyData == Keys.Enter) 
                if(gridView1.FocusedRowHandle ==gridView1.RowCount - 1)
                    {
                             gridView1.AddNewRow();

                        // we could return true; here to suppress the key
                        // but we really want to move on into the new row..!
                    }

                return base.ProcessCmdKey(ref msg, keyData);
            }

        private void FrmObjeList_Load(object sender, EventArgs e)
        {

        }
       

    }
}
