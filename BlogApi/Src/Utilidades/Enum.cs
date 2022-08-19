// criando enumeradores para diferenciar o tipo de usuário do sistema
using System.Text.Json.Serialization;

namespace BlogApi.Src.Utilidades
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TipoUsuario
    {
        NORMAL,
        ADMINISTRADOR
    }
}
