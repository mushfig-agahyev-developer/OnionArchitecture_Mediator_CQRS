using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Domain.Entities.Product, Dto.ProductViewDto>().ReverseMap();
            CreateMap<Features.Commands.CreateProductCommand, Domain.Entities.Product>().ReverseMap();
        }
    }
}
