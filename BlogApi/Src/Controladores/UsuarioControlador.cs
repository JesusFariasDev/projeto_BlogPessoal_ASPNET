using BlogApi.Src.Modelos;
using BlogApi.Src.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BlogApi.Src.Controladores
{
        [ApiController]
        [Route("api/Usuarios")]
        [Produces("application/json")]
        public class UsuarioControlador : ControllerBase
        {
            #region Atributos

            private readonly IUsuario _repositorio;

            #endregion


            #region Construtores

            public UsuarioControlador(IUsuario repositorio)
            {
                _repositorio = repositorio;
            }

            #endregion


            #region Métodos

            [HttpPost]
            //ActionResult --> Classe que retorna uma resposta ao cliente
            public async Task<ActionResult> NovoUsuarioAsync([FromBody] Usuario usuario)
            {
                await _repositorio.NovoUsuarioAsync(usuario);

                return Created($"api/Usuarios/{usuario.Email}", usuario);
            }
            
            [HttpGet("email/{emailUsuario}")]
            public async Task<ActionResult> PegarUsuarioPeloEmailAsync([FromRoute] string emailUsuario)
            {
                var usuario = await _repositorio.PegarUsuarioPeloEmailAsync(emailUsuario);

                if (usuario == null) return NotFound(new { Mensagem = "Usuario não encontrado" });

                return Ok(usuario);
            }

            #endregion
        }
    
}
