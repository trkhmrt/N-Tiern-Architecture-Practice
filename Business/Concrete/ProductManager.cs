using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {   //Dependency injection yaptık
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {   //Bu şekilde IProductdal içindeki getAll metoduna ulaşabildik.
            return _productDal.GetAll();
        }
    }
}
