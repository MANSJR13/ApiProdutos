using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiProdutos.Models;
using Microsoft.AspNetCore.Identity;
using ApiProdutos.Data;
using Microsoft.EntityFrameworkCore;

namespace ApiProdutos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var produtos = await _context.Produtos.ToListAsync();
            return Ok(produtos);
        }
        [HttpPost]
        public async Task<IActionResult> Post(Produto produto)
        {
            
            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();
            return Ok(produto);
        }

    }
}
