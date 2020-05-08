namespace Aproveitte.Dominio.Entidades
{
    public class Ingrediente : EntidadeBase
    {
        public string Nome { get; set; }

        public int IdReceita { get; set; }
        public virtual Receita Receita { get; set; }

        public int IdUnidade { get; set; }
        public virtual Unidade Unidade { get; set; }
        
    }
}
