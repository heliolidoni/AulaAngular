using Dominio.Contratos;
using Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Web.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {
        IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            this._usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(); 
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("VerificaUsuario")]
        public ActionResult VerificaUsuario([FromBody] Usuario usuario)
        {
            try
            {
                Usuario user = _usuarioRepositorio.ObterPorEmail(usuario.Email, usuario.Senha);

                if (user != null)
                {
                    return Ok(usuario);
                }
                else
                {
                    return BadRequest("Login e sennha incorretos");
                }
            }
            catch (Exception e)
            {
                return BadRequest("CAindo aqui");
            }
        }
    }
}
