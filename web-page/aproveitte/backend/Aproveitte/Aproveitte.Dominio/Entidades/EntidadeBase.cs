using System.ComponentModel.DataAnnotations.Schema;

namespace Aproveitte.Dominio.Entidades
{
    public class EntidadeBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}
