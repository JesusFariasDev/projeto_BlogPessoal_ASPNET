using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApi.Src.Modelos
{
    /// <summary>
/// <para>Resumo: Classe responsavel por representar tb_postagens no banco.
///</para>
/// <para>Criado por: Generation</para>
/// <para>Versão: 1.0</para>
/// <para>Data: 17/07/2022</para>
/// </summary>
[Table("tb_postagens")]
    public class Postagem
    {
        #region Atributos
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Foto { get; set; }
        [ForeignKey("fk_usuario")]
        public Usuario Criador { get; set; }
        [ForeignKey("fk_tema")]
        public Tema Tema { get; set; }
        #endregion
    }

}
