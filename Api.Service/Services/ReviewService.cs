using Api.Domain.Interfaces;
using AutoMapper;
using Domain.Dtos.Hotel;
using Domain.Dtos.Review;
using Domain.Entities;
using Domain.Interfaces.Services.Review;
using Domain.Models;
using Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ReviewService : IReviewService
    {

        private IReviewRepository _repository;
        private readonly IMapper _mapper;

        public ReviewService(IReviewRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ReviewDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ReviewDto>(entity) ?? new ReviewDto();
        }

        public async Task<IEnumerable<ReviewDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ReviewDto>>(listEntity);
        }


        public async Task<IEnumerable<ReviewDto>> GetAllByHotel(Guid hotelId)
        {
            var listEntity = await _repository.FindByHotel(hotelId); ;
            return _mapper.Map<IEnumerable<ReviewDto>>(listEntity);
        }

        public async Task<ReviewDtoCreateResult> Post(ReviewDtoCreate review)
        {
            ReviewModel reviewModel = new ReviewModel()
            {
                HotelId = review.HotelId,
                CustomerId = review.CustomerId,
                Comment = review.Comment,
                EvaluationStars = review.EvaluationStars
            };
            var entity = _mapper.Map<ReviewEntity>(reviewModel);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ReviewDtoCreateResult>(result);
        }

        public async Task<ReviewDtoUpdateResult> Put(ReviewDtoUpdate review)
        {
            ReviewModel reviewModel = new ReviewModel()
            {
                Id = review.Id,
                HotelId = review.HotelId,
                CustomerId = review.CustomerId,
                Comment = review.Comment,
                EvaluationStars = review.EvaluationStars
            }; 
            var entity = _mapper.Map<ReviewEntity>(reviewModel);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ReviewDtoUpdateResult>(result);
        }

       

        public async Task<IEnumerable<ReviewDto>> GetAllByCustomer(Guid customerId)
        {
            var listEntity = await _repository.FindByCustomer(customerId);
            return _mapper.Map<IEnumerable<ReviewDto>>(listEntity);
        }
    }
}
