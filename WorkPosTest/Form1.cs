using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkPosBLL.Concrete;
using WorkPosDal.EntityFrameWork;

namespace WorkPosTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

           

            Init();
        }

        private void Init()
        {var setupBll = new SetupBll<PRODUCT_CAT>();
        treeListLookUpEdit1.Properties.DataSource = setupBll.GetAllList();
            treeListLookUpEdit1.Properties.DisplayMember = "PRODUCT_CAT1";
            treeListLookUpEdit1.Properties.ValueMember = "PRODUCT_CAT1";
            treeListLookUpEdit1.Properties.TreeList = treeListLookUpEdit1TreeList;
            treeListLookUpEdit1TreeList.KeyFieldName = "PRODUCT_CATID";
            treeListLookUpEdit1TreeList.ParentFieldName = "HIERARCHY";
            treeListLookUpEdit1TreeList.DataSource = setupBll.GetAllList();
        
        }
    }
}
