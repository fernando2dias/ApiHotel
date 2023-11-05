using Api.Domain.Interfaces;
using AutoMapper;
using Domain.Dtos.Hotel;
using Domain.Dtos.Review;
using Domain.Entities;
using Domain.Interfaces.Services.Review;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class ReviewService : IReviewService
    {

        private IRepository<ReviewEntity> _repository;
        private readonly IMapper _mapper;

        public ReviewService(IRepository<ReviewEntity> repository, IMapper mapper)
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

        public async Task<IEnumerable<ReviewDto>> GetAllByCustomer(ReviewDto review)
        {
            var listEntity = await _repository.SelectAsync(review.Customer.Id);
            return _mapper.Map<IEnumerable<ReviewDto>>(listEntity);
        }

        public async Task<IEnumerable<ReviewDto>> GetAllByHotel(ReviewDto review)
        {
            var listEntity = await _repository.SelectAsync(review.Hotel.Id);
            return _mapper.Map<IEnumerable<ReviewDto>>(listEntity);
        }

        public async Task<ReviewDtoCreateResult> Post(ReviewDtoCreate review)
        {
            var model = _mapper.Map<ReviewModel>(review);
            var entity = _mapper.Map<ReviewEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ReviewDtoCreateResult>(result);
        }

        public async Task<ReviewDtoUpdateResult> Put(ReviewDtoUpdate review)
        {
            var model = _mapper.Map<ReviewModel>(review);
            var entity = _mapper.Map<ReviewEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ReviewDtoUpdateResult>(result);
        }
    }
}
