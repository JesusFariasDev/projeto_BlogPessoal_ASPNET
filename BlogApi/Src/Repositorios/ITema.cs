using BlogApi.Src.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogApi.Src.Repositorios
{
    public interface ITema
    {
        /// <summary>
        /// <para>Resumo: Responsavel por representar ações de CRUD de tema</para>
        /// <para>Criado por: Generation</para>
        /// <para>Versão: 1.0</para>
        /// <para>Data: 08/08/2022</para>
        /// </summary>
        
        Task<List<ITema>>PegarTodosTemasAsync();
        Task<Tema> PegarTemaPeloIdAsync(int id);
        Task NovoTemaAsync(Tema tema);
        Task AtualizarTemaAsync(Tema tema);
        Task DeletarTemaAsync(int id);
    }
}
