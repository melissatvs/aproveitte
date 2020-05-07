using Aproveitte.Aplicacao.DTO;
using Aproveitte.Dominio.Entidades;
using AutoMapper;

namespace Aproveitte.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Receita, ReceitaDTO>();
            CreateMap<ReceitaDTO, Receita>();

            CreateMap<Ingrediente, IngredienteDTO>();
            CreateMap<IngredienteDTO, Ingrediente>();
            
            CreateMap<Unidade, UnidadeDTO>();
            CreateMap<UnidadeDTO, Unidade> ();
        }
    }
}
