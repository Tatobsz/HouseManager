using HouseManager.Aplicacao.Interfaces.Servicos;
using HouseManager.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HouseManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoServico produtoServico;

        public ProdutosController(IProdutoServico produtoServico)
        {
            this.produtoServico = produtoServico;
        }

        [HttpGet]
        public IActionResult ListAll()
        {
            return Ok(produtoServico.ListAll());
        }

        [HttpPost]
        public IActionResult Cadastrar([FromBody] Produto produto)
        {
            produtoServico.InserirProduto(produto);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(produtoServico.Get(Guid.Parse(id)));
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(string id)
        {
            produtoServico.Deletar(Guid.Parse(id));
            return Ok();
        }

        [HttpPut]
        public IActionResult Alterar([FromBody]Produto produto)
        {
            try
            {
                produtoServico.Alterar(produto);
                return Ok("Produto alterado com sucesso");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
