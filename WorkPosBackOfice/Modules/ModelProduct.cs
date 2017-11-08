using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using System.ComponentModel;

using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting;
using EfBusiness;
using EfBusiness.UnitOfWork;
using WorkPosDal.EntityFrameWork;

namespace WorkPosBackOfice.Modules{
    public class ModelProduct
    {
        public string Connstring { get; set; }DataSet ds;
        private readonly IRepository<PRODUCT> _repository;
        private readonly IRepository<STOCKS> _repositoryStock;
        private readonly IRepository<PRODUCT_UNIT> _repositoryUnit;
        private readonly IRepository<PRODUCT_CAT> _repositoryProductCat;
        private readonly IRepository<PRICE_STANDART> _repositoryPs;
        readonly IUnitOfWork _uow;
        public ModelProduct()
        {
            var dbContext = new WorkPosDbContext();
            _uow=new UnitOfWork(dbContext);
            _repository = new Repository<PRODUCT>(dbContext);
            _repositoryStock = new Repository<STOCKS>(dbContext);
            _repositoryUnit = new Repository<PRODUCT_UNIT>(dbContext);
            _repositoryProductCat=new Repository<PRODUCT_CAT>(dbContext);
            _repositoryPs = new Repository<PRICE_STANDART>(dbContext);
        }

        public List<ViewStock> GetStockAll2()
        {
            var  viewStocks = (from s in _repositoryStock.GetAll()
                join ps in _repositoryPs.GetAll() on s.PRODUCT_ID equals ps.PRODUCT_ID
                join p in _repository.GetAll() on s.PRODUCT_ID equals p.PRODUCT_ID
                join pcat in _repositoryProductCat.GetAll() on p.PRODUCT_CATID equals pcat.PRODUCT_CATID
                join u in _repositoryUnit.GetAll() on p.PRODUCT_ID equals u.PRODUCT_ID
                join uu in  _repositoryUnit.GetAll() on s.PRODUCT_UNIT_ID equals uu.PRODUCT_UNIT_ID
       where ps.PURCHASESALES==true && u.IS_MAIN==true
                select new ViewStock()
                {
                    StockId = s.STOCK_ID,
                    ProductId = s.PRODUCT_ID,
                    StockCode = s.STOCK_CODE,
                    StockCode2 = s.STOCK_CODE_2,
                    PriceStandartSales = ps.PRICE,
                    StokAd = p.PRODUCT_NAME,
                    Birim = u.MAIN_UNIT,
                    ProductCatId=p.PRODUCT_CATID,
                    ProductCat=pcat.PRODUCT_CAT1,
                    Hierarchy=pcat.HIERARCHY

                }
                ).ToList();
            return viewStocks;
        }


        public void TextBoslukKontrol_DevExpress(DevExpress.XtraBars.Ribbon.RibbonForm winForm, DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider, string warningMessage)
        {
            foreach (DevExpress.XtraBars.Ribbon.RibbonForm formControl in winForm.Controls)
            {
                if (formControl is DevExpress.XtraEditors.TextEdit)
                {
                    if (formControl.Text == string.Empty)
                    {
                        dxErrorProvider.SetError(formControl, warningMessage);
                    }
                    else
                    {
                        dxErrorProvider.ClearErrors();
                    }
                }
            }
        }

        public void AddProduct(PRODUCT product,PRODUCT_UNIT productUnit,STOCKS stocks,PRICE_STANDART priceStandart)
        {
            int pid = 0,unitid=0;

 
            priceStandart.PURCHASESALES = true;
            priceStandart.PRODUCT_ID = pid;

            stocks.PRODUCT_UNIT_ID = unitid;
            stocks.PRODUCT_ID = pid; 
            stocks.STOCK_STATUS = true;
            stocks.STOCK_CODE = product.PRODUCT_CODE;
            stocks.STOCK_CODE_2 = product.PRODUCT_CODE_2;
            stocks.RECORD_DATE = DateTime.Now;
            stocks.RECORD_EMP = 1;
            stocks.BARCOD = "123456";
            stocks.PROPERTY = "";
            stocks.RECORD_IP = "";
            stocks.MANUFACT_CODE = "";
            product.ProductPriceStandarts = new Collection<PRICE_STANDART> {priceStandart};

            product.ProductStocks=new Collection<STOCKS> {stocks};

            product.ProductUnits=new Collection<PRODUCT_UNIT> {productUnit};

            _repository.Add(product);

            _uow.SaveChanges();
        
        }


        public class ViewStock
        {
            [Browsable(false)]
            public int ProductId { get; set; }
              [Browsable(false)]
            public int StockId { get; set; }

            [Browsable(false)]
            public int UnitId { get; set; }
           
            [DisplayName("Stok Adı")]
            public string StokAd { get; set; }
            public string Birim { get; set; }

            [DisplayName("Stok Kodu")]
            public string StockCode { get; set; }

            [DisplayName("Özel Kod")]
            public string StockCode2 { get; set; }

            public string ProductCode { get; set; }

            public string ProductCode2 { get; set; }

            [DisplayName("Kdv")]
            public int Tax { get; set; }

            [DisplayName("Standart Satış Fiyatı")]
            public double? PriceStandartSales { get; set; }

            public double? PriceStandartPurchase { get; set; }

            public string Barcode { get; set; }
            public string ProductCat { get; set; }
            public int ProductCatId { get; set; }
            public string Hierarchy { get; set; }
        }


       
    }
}
