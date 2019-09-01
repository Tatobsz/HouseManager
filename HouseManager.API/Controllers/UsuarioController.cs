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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServico usuarioServico;
        public UsuarioController(IUsuarioServico usuarioServico)
        {
            this.usuarioServico = usuarioServico;
        }

        [HttpGet]
        public Usuario Get()
        {
            return usuarioServico.Get();
        }
    }
}