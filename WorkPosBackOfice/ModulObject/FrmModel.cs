using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace WorkPosBackOfice.ModulObject
{
    public partial class FrmModel : Form
    {
       
        private ModelObjects modelObjects;
        public ModelObjects.Model secilenItem;
        public FrmModel()
        {

            InitializeComponent();

           

        }

        private void gridControl1_ControlAdded(object sender, ControlEventArgs e)
        {
       
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {

          
        }
    }
}
