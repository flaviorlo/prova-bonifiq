using Microsoft.AspNetCore.Mvc;
using ProvaPub.Models;
using ProvaPub.Repository;
using ProvaPub.Services;
using ProvaPub.Services.IServices;

namespace ProvaPub.Controllers
{
	
	[ApiController]
	[Route("[controller]")]
	public class Parte2Controller :  ControllerBase
	{
        private IProductService _prodSrv { get;  }
        private ICustomerService _customerSrv { get; }
        /// <summary>
        /// Precisamos fazer algumas alterações:
        /// 1 - Não importa qual page é informada, sempre são retornados os mesmos resultados. Faça a correção.
        /// 2 - Altere os códigos abaixo para evitar o uso de "new", como em "new ProductService()". Utilize a Injeção de Dependência para resolver esse problema
        /// 3 - Dê uma olhada nos arquivos /Models/CustomerList e /Models/ProductList. Veja que há uma estrutura que se repete. 
        /// Como você faria pra criar uma estrutura melhor, com menos repetição de código? E quanto ao CustomerService/ProductService. Você acha que seria possível evitar a repetição de código?
        /// 
        /// </summary>
        //TestDbContext _ctx;
        public Parte2Controller(IProductService prodSrv, ICustomerService customerSrv)
		{
            _prodSrv = prodSrv;
            _customerSrv= customerSrv;

        }
	
		[HttpGet("products")]
		public ItemsList ListProducts(int page)
		{			
			return _prodSrv.ListProducts(page);
		}

		[HttpGet("customers")]
		public ItemsList ListCustomers(int page)
		{			
			return _customerSrv.ListCustomers(page);			
		}
	}
}
