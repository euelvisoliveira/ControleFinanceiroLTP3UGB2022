using System.ComponentModel;

namespace Academico.Models
{
    public class Instituicao
    {
        [DisplayName("Código")]
        public long? Id { get; set; }
        public string? Nome { get; set; }
        [DisplayName("Endereço")]
        public string? Endereco { get; set; }
    }
}
