using ABPD_05.Model;
using ABPD_05.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ABPD_05.DAL
{
    public interface IDBService
    {

        public int AddProducts(OrderRequest request);
        public IEnumerable<Warehouse> getAllWarehouses();
        public IEnumerable<Product> GetAllProducts();
    }
}
