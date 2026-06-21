using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiProdutos.Models;

namespace ApiProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private static List<Produto> produtos = new List<Produto>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(produtos);
        }
        [HttpPost]
        public IActionResult Post(Produto produto)
        {
            produto.Id = produtos.Count + 1;
            produtos.Add(produto);
            return Ok(produto);
        }

    }
}
