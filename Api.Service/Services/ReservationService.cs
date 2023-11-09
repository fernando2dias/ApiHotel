using AutoMapper;
using Domain.Entities;
using Domain.Interfaces.Services.Reservation;
using Domain.Models;
using Domain.Repository;

namespace Service.Services
{
    public class ReservationService : IReservationService
    {
        private IReservationRepository _repository;
        private readonly IMapper _mapper;

        public ReservationService(IReservationRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ReservationEntity> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<ReservationEntity>(entity) ?? new ReservationEntity();
        }

        public async Task<IEnumerable<ReservationEntity>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ReservationEntity>>(listEntity);
        }

        public async Task<ReservationEntity> Post(Reservation reservation)
        {
            if (reservation == null)
            {
                throw new ArgumentNullException(nameof(reservation), "Reservation cannot be null.");
            }

            var model = _mapper.Map<ReservationModel>(reservation);
            var entity = _mapper.Map<ReservationEntity>(model);
            var result = await _repository.InsertAsync(entity);

            return _mapper.Map<ReservationEntity>(result);

        }

        public async Task<ReservationEntity> Put(Reservation reservation)
        {
            if (reservation == null)
            {
                throw new ArgumentNullException(nameof(reservation), "Reservation cannot be null.");
            }    

            var model = _mapper.Map<ReservationModel>(reservation);
            var entity = _mapper.Map<ReservationEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ReservationEntity>(result);
        }

        public async Task<ReservationEntity> CheckIn(Guid id)
        {
            var _reservation = await _repository.GetByHotelId(id);
           // ReservationEntity _reservation = await Get(id);
            
            if (_repository is null || _reservation.Room.Status != Status.Reserved)
            {
                return new ReservationEntity();
            }

            _reservation.Checkin = DateTime.Now;

            var model = _mapper.Map<ReservationModel>(_reservation);
            var entity = _mapper.Map<ReservationEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ReservationEntity>(result);

        }

        public async Task<ReservationEntity> CheckOut(Guid id)
        {
            var _reservation = await _repository.GetByHotelId(id);
            // ReservationEntity _reservation = await Get(id);

            if (_repository is null || _reservation.Room.Status != Status.Busy)
            {
                return new ReservationEntity();
            }

            _reservation.Checkout = DateTime.Now;

            var model = _mapper.Map<ReservationModel>(_reservation);
            var entity = _mapper.Map<ReservationEntity>(model);
            var result = await _repository.UpdateAsync(entity);

            return _mapper.Map<ReservationEntity>(result);
        }


        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<ReservationEntity>> GetAllByCustomer(Guid customerId)
        {
            var listEntity = await _repository.ReservationByCustomer(customerId);
            return _mapper.Map<IEnumerable<ReservationEntity>>(listEntity);
        }

        public async Task<IEnumerable<ReservationEntity>> GetAllByHotel(Guid hotelId)
        {
            var listEntity = await _repository.ReservationByHotel(hotelId);
            return _mapper.Map<IEnumerable<ReservationEntity>>(listEntity);
        }
    }
}
