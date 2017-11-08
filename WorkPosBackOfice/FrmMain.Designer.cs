namespace WorkPosBackOfice
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnStokYonetim = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnFiyatYonetimi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageModuller = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPgStokYonetim = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPgUyeYonetim = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultBarAndDockingController1 = new DevExpress.XtraBars.DefaultBarAndDockingController(this.components);
            this.applicationMenu1 = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtnStokYonetim,
            this.barButtonItem1,
            this.barBtnFiyatYonetimi,
            this.barButtonItem2,
            this.barButtonItem3});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageModuller});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbonControl1.Size = new System.Drawing.Size(1255, 131);
            // 
            // barBtnStokYonetim
            // 
            this.barBtnStokYonetim.Caption = "Stok Yönetimi";
            this.barBtnStokYonetim.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnStokYonetim.Glyph")));
            this.barBtnStokYonetim.Id = 1;
            this.barBtnStokYonetim.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnStokYonetim.LargeGlyph")));
            this.barBtnStokYonetim.LargeWidth = 70;
            this.barBtnStokYonetim.Name = "barBtnStokYonetim";
            this.barBtnStokYonetim.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnStokYonetim_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Üye yönetimi";
            this.barButtonItem1.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.Glyph")));
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.LargeGlyph")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barBtnFiyatYonetimi
            // 
            this.barBtnFiyatYonetimi.Caption = "Fiyat Yönetimi";
            this.barBtnFiyatYonetimi.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtnFiyatYonetimi.Glyph")));
            this.barBtnFiyatYonetimi.Id = 2;
            this.barBtnFiyatYonetimi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnFiyatYonetimi.LargeGlyph")));
            this.barBtnFiyatYonetimi.Name = "barBtnFiyatYonetimi";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Tanımlamalar";
            this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
            this.barButtonItem2.Id = 3;
            this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Risk Tanımlamaları";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPageModuller
            // 
            this.ribbonPageModuller.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPgStokYonetim,
            this.ribbonPgUyeYonetim});
            this.ribbonPageModuller.Name = "ribbonPageModuller";
            this.ribbonPageModuller.Text = "MODÜLLER";
            // 
            // ribbonPgStokYonetim
            // 
            this.ribbonPgStokYonetim.ItemLinks.Add(this.barBtnStokYonetim);
            this.ribbonPgStokYonetim.ItemLinks.Add(this.barBtnFiyatYonetimi);
            this.ribbonPgStokYonetim.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPgStokYonetim.Name = "ribbonPgStokYonetim";
            this.ribbonPgStokYonetim.Text = "Stok Yönetimi";
            // 
            // ribbonPgUyeYonetim
            // 
            this.ribbonPgUyeYonetim.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPgUyeYonetim.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPgUyeYonetim.Name = "ribbonPgUyeYonetim";
            this.ribbonPgUyeYonetim.Text = "Üye Yönetimi";
            // 
            // defaultBarAndDockingController1
            // 
            this.defaultBarAndDockingController1.Controller.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.defaultBarAndDockingController1.Controller.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // applicationMenu1
            // 
            this.applicationMenu1.Name = "applicationMenu1";
            this.applicationMenu1.Ribbon = this.ribbonControl1;
            // 
            // FrmMain
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 503);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "WorkPos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmModel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.defaultBarAndDockingController1.Controller)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.applicationMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.BarButtonItem barBtnStokYonetim;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageModuller;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPgStokYonetim;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPgUyeYonetim;
        private DevExpress.XtraBars.DefaultBarAndDockingController defaultBarAndDockingController1;
        private DevExpress.XtraBars.Ribbon.ApplicationMenu applicationMenu1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barBtnFiyatYonetimi;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    }
}