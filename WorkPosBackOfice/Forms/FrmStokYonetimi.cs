using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraNavBar;
using System.Data.Entity;
using WorkPosBackOfice.Modules;

namespace WorkPosBackOfice.Forms
{
    public partial class FrmStokYonetimi : XtraForm
    {
        private ModelProduct modelProduct;
        public FrmStokYonetimi()
        {
            InitializeComponent();

            modelProduct = new ModelProduct();
            Init();


        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //gridControl1.DataSource = CompanyProductList.GetSampleData();
            //companyProductListBindingSource.DataSource = CompanyProductList.GetSampleData();
            //companyProductBindingSource.DataSource = CompanyProductList.GetSampleData();
        }
        void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            gridProductListControl.MainView.PopulateColumns();
            (gridProductListControl.MainView as GridView).BestFitColumns();
        }
        void StokIslemer(NavBarItemLink navBarItemLink)
        {; //  if(navBarItemLink.ItemName==)
        }

        private void navBarItemStokEkle_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
           
        }

        void Init()
        {
            bindingSource1.DataSource = modelProduct.GetStockAll2();
            gridProductListControl.DataSource = bindingSource1;
        }

        private void navBarÜrünGorntule_LinkClicked(object sender, NavBarLinkEventArgs e)
        {

            if (gridProductListView.GetFocusedRow() != null)
            {
                var viewProduct = gridProductListView.GetFocusedRow() as ModelProduct.ViewStock;

                var stokDetay = new FrmStokDetay(viewProduct);
                if (stokDetay.ShowDialog() == DialogResult.OK)
                {
                    Init();
                }
            }
            else
            {
                MessageBox.Show("Listeden ürün seçiniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void navBarItemUrunEkle_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            var stokDetay = new FrmStokDetay();
            if (stokDetay.ShowDialog() == DialogResult.OK)
            {
                Init();
            }
        }
    }
    
}
