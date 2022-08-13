using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApi.Src.Contextos;
using BlogApi.Src.Modelos;
using BlogApi.Src.Repositorios;
using Microsoft.EntityFrameworkCore;

namespace BlogAPI.Src.Repositorios.Implentacoes
{
    public class UsuarioRepositorio : IUsuario
    {
        #region Atributos
        //contexto está sendo adicionado a classe
        private readonly BlogPessoalContexto _contexto;

        #endregion


        #region Construtores
        //injeção de dependência
        public UsuarioRepositorio(BlogPessoalContexto contexto)
        {
            _contexto = contexto;
        }

        #endregion


        #region Métodos

        /// <summary>
        /// <para>Resumo: Método assíncrono para salvar um novo usuario</para>
        /// </summary>
        /// <param name="usuario">Construtor para cadastrar usuario</param>
        public async Task NovoUsuarioAsync(Usuario usuario)
        {
            await _contexto.Usuarios.AddAsync(new Usuario
            {
                Nome = usuario.Nome,
                Email = usuario.Email,
                Senha = usuario.Senha,
                Foto = usuario.Foto
            });
            await _contexto.SaveChangesAsync();
        }

        /// <summary>
        /// <para>Resumo: Método assíncrono para pegar um usuario pelo email</para>
        /// </summary>
        /// <param name="email">Email do usuario</param>
        /// <return>UsuarioModelo</return>
        public async Task<Usuario> PegarUsuarioPeloEmailAsync(string email)
        {   //async sendo utilizado para busca de email no banco de dados
            return await _contexto.Usuarios.FirstOrDefaultAsync(u => u.Email == email);
        }

        #endregion

    }
}