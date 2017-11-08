using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraGrid.Views.Grid;
using WorkPosBackOfice.Forms;
using WorkPosBackOfice.Modules;
namespace WorkPosBackOfice
{
    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
       
        private ModelObjects modelObjects;
        public ModelObjects.Model secilenItem;
        public FrmMain()
        {

            InitializeComponent();

            this.ribbonControl1.MdiMergeStyle = RibbonMdiMergeStyle.OnlyWhenMaximized;

        }

        private void gridControl1_ControlAdded(object sender, ControlEventArgs e)
        {
       
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

          
        }

        private void FrmModel_Load(object sender, EventArgs e)
        {

        }

        private void barBtnStokYonetim_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frmStokYonetimi=new FrmStokYonetimi ();
            yavruform(frmStokYonetimi);
        }
        void yavruform(Form yavru){bool durum = false;
            foreach (Form eleman in this.MdiChildren)
            {
                if (eleman.Text == yavru.Text)
                {
                    durum = true;
                    eleman.Activate();
                }
                else
                {
                    eleman.Close();
                }
            }
            if (durum == false)
            {
                yavru.MdiParent = this;
                yavru.Show();
            }
        }
       
    }
}
