using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlogApi.Src.Modelos
{
    /// <summary>
    /// <para>Resumo: Classe responsavel por representar tb_temas no banco.</para>
    /// <para>Criado por: Generation</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 17/07/2022</para>
    /// </summary>
    [Table("tb_temas")]
    public class Tema
    {
        #region Atributos
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descricao { get; set; }
        [JsonIgnore, InverseProperty("Tema")]
        public List<Postagem> PostagensRelacionadas { get; set; }
        #endregion
    }
}
