using BlogApi.Src.Modelos;
using System.Threading.Tasks;

namespace BlogApi.Src.Repositorios
{
    public interface IUsuario
    {
        /// <summary>
        /// <para>Resumo: Responsavel por representar ações de CRUD de usuario</para>
        /// <para>Criado por: Generation</para>
        /// <para>Versão: 1.0</para>
        /// <para>Data: 29/04/2022</para>
        /// </summary>
        //Task vai fazer o código esperar a resposta do servidor, assim como o await
        Task<Usuario> PegarUsuarioPeloEmailAsync(string email);
        Task NovoUsuarioAsync(Usuario usuario);
    }
}
