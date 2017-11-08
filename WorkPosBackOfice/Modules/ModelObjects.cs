using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using EfBusiness;
using EfBusiness.UnitOfWork;
using WorkPosDal.EntityFrameWork;

namespace WorkPosBackOfice.Modules
{
    public class ModelObjects
    {

        public string Connstring { get; set; }
        private readonly WorkPosDbContext _dbproductContext;private IUnitOfWork _uow;
        private readonly IRepository<PRODUCT_BRANDS> _repositoryBrand;
        private IRepository<SETUP_UNIT> _repositoryUnit;
        private IRepository<PRODUCT_BRANDS_MODEL> _repositoryModel;
        private IRepository<PRODUCT_CAT> _repositoryPCat;
            DataSet ds;
        public ModelObjects(string connstring)
        {
            this.Connstring = connstring;
            _dbproductContext = new WorkPosDbContext();
            _uow=new UnitOfWork(_dbproductContext);
            _repositoryBrand = new Repository<PRODUCT_BRANDS>(_dbproductContext);
            _repositoryModel = new Repository<PRODUCT_BRANDS_MODEL>(_dbproductContext);
            _repositoryUnit = new Repository<SETUP_UNIT>(_dbproductContext);
            _repositoryPCat = new Repository<PRODUCT_CAT>(_dbproductContext);
        }

        public void ObjeIslemler(ObjectEnum objectEnum,ObjectIslem objectIslem,object obje,int iliskiliObjeId,GridControl gridControl)
        {

            switch (objectEnum)
            {
                case ObjectEnum.Marka:
                    var brand = (DataRowView) obje;
                    PRODUCT_BRANDS productBrand;
                    switch (objectIslem)
                            {  
                                case ObjectIslem.Ekle:
                                           productBrand = new PRODUCT_BRANDS
                                           {
                                               BRAND_NAME = (string) brand["Marka"]
                                            };
                                           _repositoryBrand.Add(productBrand);
                                           _uow.SaveChanges();break;
                                case ObjectIslem.Guncelle:
                                    int id = (int) brand["Id"];
                                    productBrand = _repositoryBrand.Get(b => b.BRAND_ID == id);// _dbproductContext.PRODUCT_BRANDS.FirstOrDefault(b => b.BRAND_ID ==id );
                                        productBrand.BRAND_NAME = brand["Marka"].ToString();
                                        _repositoryBrand.Update(productBrand);
                                         _uow.SaveChanges();
                                        break;
                                    case ObjectIslem.Listele:
                                        List<MyGridView> objeList = (from pbs in _repositoryBrand.GetAll()
                                                                      select new MyGridView()
                                                                 {
                                                                     Id= pbs.BRAND_ID,
                                                                     Deger = pbs.BRAND_NAME,
                                                                     kolonAdi = ObjectEnum.Marka.ToString()
                                                                 }
                                           ).ToList();
                                     ds = new DataSet();
                                     ds.Tables.Add(GetDataSource(objeList, ObjectEnum.Marka.ToString()));
                                      gridControl.DataSource = ds.Tables[0];
                                    break;
                            }
                    break;case ObjectEnum.Model:
                    var model = (DataRowView)obje;
                    PRODUCT_BRANDS_MODEL productBrandsModel;switch (objectIslem)
                            {

                                case ObjectIslem.Ekle:
                                    productBrandsModel = new PRODUCT_BRANDS_MODEL { BRAND_ID = iliskiliObjeId,MODEL_NAME =(string)model[objectEnum.ToString()]};
                                    _repositoryModel.Add(productBrandsModel);
                                    _uow.SaveChanges();break;
                                case ObjectIslem.Guncelle:
                                    int id = (int)model["Id"];
                                    productBrandsModel =_repositoryModel.Get(b => b.MODEL_ID == id);
                                    productBrandsModel.MODEL_NAME = model[objectEnum.ToString()].ToString();
                                    _repositoryModel.Update(productBrandsModel);
                                    _uow.SaveChanges();
                                    break;
                                case ObjectIslem.Listele:
                                    List<MyGridView> objeList = (from pbs in _repositoryModel.GetAllList()select new MyGridView()
                                                             {
                                                                // Id = pbs.BRAND_ID,
                                                                 Id = pbs.MODEL_ID,
                                                                 Deger = pbs.MODEL_NAME,
                                                                 kolonAdi = objectEnum.ToString()
                                                             }
                                       ).ToList();
                                       ds = new DataSet();
                                      ds.Tables.Add(GetDataSource(objeList, objectEnum.ToString()));
                                    gridControl.DataSource = ds.Tables[0];
                                    break;
                    }
                    break;
                case ObjectEnum.Birim:
                    var birim = (DataRowView)obje;
                    SETUP_UNIT setupUnit;
                            switch (objectIslem)
                            {

                                case ObjectIslem.Ekle:
                                    setupUnit = new SETUP_UNIT {UNIT =(string)birim[objectEnum.ToString()]};
                                    _repositoryUnit.Add(setupUnit);
                                    _uow.SaveChanges();
                                    break;
                                case ObjectIslem.Guncelle:
                                    int id = (int)birim["Id"];
                                    setupUnit = _repositoryUnit.Get(b => b.UNIT_ID == id);
                                    setupUnit.UNIT = birim[objectEnum.ToString()].ToString();
                                    _repositoryUnit.Update(setupUnit);
                                    _uow.SaveChanges();
                                    break;
                                case ObjectIslem.Listele:
                                    List<MyGridView> objeList = (from pbs in _repositoryUnit.GetAllList()
                                                                 select new MyGridView()
                                                             {
                                                                 Id = pbs.UNIT_ID,
                                                                 Deger = pbs.UNIT,
                                                                 kolonAdi = objectEnum.ToString()
                                                             }
                                       ).ToList();
                                   ds = new DataSet();
                                      ds.Tables.Add(GetDataSource(objeList, objectEnum.ToString()));
                                    gridControl.DataSource = ds.Tables[0];
                                    break;
                    }
                    break;
                case ObjectEnum.UrunKategori:
                    var productCat_ = (DataRowView)obje;
                    PRODUCT_CAT productCat;
                    switch (objectIslem)
                    {

                        case ObjectIslem.Ekle:
                            productCat = new PRODUCT_CAT { PRODUCT_CAT1 = (string)productCat_[objectEnum.ToString()], HIERARCHY = "" };
                            _repositoryPCat.Add(productCat);
                            _uow.SaveChanges();
                            break;
                        case ObjectIslem.Guncelle:
                            int id = (int)productCat_["Id"];
                            productCat = _repositoryPCat.Get(b => b.PRODUCT_CATID == id);
                            productCat.PRODUCT_CAT1 = productCat_[objectEnum.ToString()].ToString();
                            productCat.HIERARCHY = "";
                            _repositoryPCat.Update(productCat);
                            _uow.SaveChanges();
                            break;
                        case ObjectIslem.Listele:
                            List<MyGridView> objeList = (from pbs in _repositoryPCat.GetAllList()
                                                         select new MyGridView()
                                                         {
                                                             Id = pbs.PRODUCT_CATID,
                                                             Deger = pbs.PRODUCT_CAT1,
                                                             kolonAdi = objectEnum.ToString()
                                                         }
                               ).ToList();
                             ds = new DataSet();
                                      ds.Tables.Add(GetDataSource(objeList, objectEnum.ToString()));
                                    gridControl.DataSource = ds.Tables[0];
                            break;
                    }
                    break;
                    
            }

          
        }

        private DataTable GetDataSource(List<MyGridView> markaList,string kolonAdi)
        {
            var dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add(kolonAdi, typeof(string));

                for (int i = 0; i < markaList.Count; i++)
                {
                    dt.Rows.Add(markaList[i].Id, markaList[i].Deger);
                }
          return dt;
        }

       
        public void ComboDoldur(ObjectEnum objectEnum,object obje)
        {
            
        }
       
        public void ErrorMessage(string message,int tip)
        {
            switch (tip)
            {
                case 0:
                    MessageBox.Show(message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show(message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show(message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
            
        }

        public class Brand
        {
            [Key]
            public int MarkaId { get; set; }
            public string Marka { get; set; }
        }

        public class MyGridView
        {
            [Key]
            public int Id { get; set; }
            public string Deger { get; set; }

            public string kolonAdi { get; set; }
        }

        public class Birim
        {
            public int BirimId { get; set; }
            public string BirimAd { get; set; }
        }
     

        public class UrunKategori
        {
            public int KategoriId { get; set; }
            public string Kategori { get; set; }
            public string KategoriKodu { get; set; }
      
            public string Hiyerarsi { get; set; }
        }

      

        public class Model
        {
            public int? MarkaId { get; set; }
            public string ModelName { get; set; }
            public int ModelId { get; set; }
        }

        public enum ObjectEnum
        {
            Marka,
            Model,
            Birim,
            UrunKategori
        }
        public enum ObjectIslem
        {
            Ekle,
            Guncelle,
            Listele
        }



     
    }

    
}
