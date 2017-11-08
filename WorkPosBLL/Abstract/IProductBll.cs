using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;


namespace WorkPosBLL.Abstract
{
    public interface IProductBll
    {
        void AddProduct(object product, object stocks, object productUnit, object priceStandart);

        void DelProduct(int productId);


    }
}
