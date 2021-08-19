using ApplicationApp.Interfaces;
using Domain.Interfaces.InterfaceProduct;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppProduct : InterfaceProductApp
    {
        IProduct _Iproduct;
        IServiceProduct _IServiceProduct;

        public AppProduct(IProduct IProduct, IServiceProduct IServiceProduct)
        {
            _Iproduct = IProduct;

            _IServiceProduct = IServiceProduct;
        }

        public async Task AddProduct(Produto produto)
        {
            await _IServiceProduct.AddProduct(produto);
        }

        public async Task UpdateProduct(Produto produto)
        {
            await _IServiceProduct.UpdateProduct(produto);
        }

        public async Task Add(Produto Objeto)
        {
            await _Iproduct.Add(Objeto);
        }        

        public async Task Delete(Produto Objeto)
        {
            await _Iproduct.Delete(Objeto);
        }

        public async Task<Produto> GetEntityById(int Id)
        {
            return await _Iproduct.GetEntityById(Id);
        }

        public async Task<List<Produto>> List()
        {
            return await _Iproduct.List();
        }

        public async Task Update(Produto Objeto)
        {
            await _Iproduct.Update(Objeto);
        }

        
    }
}
