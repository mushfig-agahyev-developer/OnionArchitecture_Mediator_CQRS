using AutoMapper;
using MediatR;
using ProductApp.Application.Dto;
using ProductApp.Application.Interfaces;
using ProductApp.Application.Wrappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductApp.Application.Features.Commands
{
    public class GetProductById : IRequest<ServiceResponse<ProductViewDto>> 
    {
        public Guid Id { get; set; }
    }

    public class GetProductByIdHandler : IRequestHandler<GetProductById, ServiceResponse<ProductViewDto>>
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public GetProductByIdHandler(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }

        public async Task<ServiceResponse<ProductViewDto>> Handle(GetProductById request, CancellationToken cancellationToken)
        {
            var product = await productRepository.GetByidAsync(request.Id);
            var dto = mapper.Map<ProductViewDto>(product);
            var _result = new ServiceResponse<ProductViewDto>(dto);
            _result.Message = "Succes data operation";
            _result.Success = true;
            _result.ResponseTime = DateTime.Now.ToString("dd-MM-yyyy HH:mm:sss");

            return _result;
        }
    }
}
