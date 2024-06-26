﻿using LixoZero.Model;
using LixoZero.Persistencia;
using Microsoft.AspNetCore.Mvc;

namespace LixoZero.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private readonly ILogger<UsuarioController> _logger;
        private UsuarioPersistencia UsuarioPersistencia { get; set; } = new UsuarioPersistencia();

        public UsuarioController(ILogger<UsuarioController> logger)
        {
            _logger = logger;
        }

        [HttpGet("{login_Email},{senha}")]
        public bool Logar(string login_Email, string senha) => UsuarioPersistencia.Logar(login_Email, senha);

        [HttpPost]
        public bool CriarLogin(Usuario usuario) => UsuarioPersistencia.CriarLogin(usuario);
    }
}
