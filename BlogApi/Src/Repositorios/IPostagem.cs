using BlogApi.Src.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogApi.Src.Repositorios
{
    /// <summary>
    /// <para>Resumo: Responsavel por representar ações de CRUD de postagem</para>
    /// <para>Criado por: Generation</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 08/08/2022</para>
    /// </summary>
    public interface IPostagem
    {
        Task<List<Postagem>> PegarTodosPostagensAsync();
        Task<Postagem> PegarPostagemPeloIdAsync(int id);
        Task NovoPostagemAsync(Postagem postagem);
        Task AtualizarPostagemAsync(Postagem postagem);
        Task DeletarPostagemAsync(int id);
    }
}
