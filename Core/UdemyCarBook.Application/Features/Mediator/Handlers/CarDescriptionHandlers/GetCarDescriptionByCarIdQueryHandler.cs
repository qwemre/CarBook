﻿using MediatR;
using UdemyCarBook.Application.Features.Mediator.Queries.CarDescriptionQueries;
using UdemyCarBook.Application.Features.Mediator.Results.CarDescriptionResults;
using UdemyCarBook.Application.Interfaces.CarDescriptionInterfaces;

namespace UdemyCarBook.Application.Features.Mediator.Handlers.CarDescriptionHandlers
{
    public class GetCarDescriptionByCarIdQueryHandler : IRequestHandler<GetCarDescriptionByCarIdQuery, GetCarDescriptionQueryResult>
    {
        private readonly ICarDescriptionRepository _repository;
        public GetCarDescriptionByCarIdQueryHandler(ICarDescriptionRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetCarDescriptionQueryResult> Handle(GetCarDescriptionByCarIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetCarDescription(request.Id);
            return new GetCarDescriptionQueryResult
            {
                CarDescripotionID = values.CarDescripotionID,
                CarID = values.CarID,
                Details = values.Details
            };
        }
    }
}