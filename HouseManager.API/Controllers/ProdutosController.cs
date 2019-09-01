using HouseManager.Aplicacao.Interfaces.Servicos;
using HouseManager.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        [HttpGet("{id}")]
        public IActionResult Get(string protegido)
        {
            if (protegido == null)
                return BadRequest("Deu errado");

            return Ok("Chamou o id");
        }
    }
}
