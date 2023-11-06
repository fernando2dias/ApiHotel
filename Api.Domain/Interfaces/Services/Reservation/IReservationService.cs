using Domain.Dtos.Customer;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Services.Reservation;

public interface IReservationService
{
    Task<ReservationEntity> Get(Guid id);
    Task<IEnumerable<ReservationEntity>> GetAll();
    Task<IEnumerable<ReservationEntity>> GetAllByCustomer(Guid customerId);
    Task<IEnumerable<ReservationEntity>> GetAllByHotel(Guid hotelId);
    Task<ReservationEntity> Post(Reservation reservation);
    Task<ReservationEntity> Put(Reservation reservation);
    Task<ReservationEntity> CheckIn(Guid id);
    Task<ReservationEntity> CheckOut(Guid id);



    Task<bool> Delete(Guid id);
}

public record Reservation
    (
    Guid? Id,
    DateTime ReservationDateInit,
    DateTime ReservationDateEnd,
    DateTime Checkin,
    DateTime Checkout,
    CustomerEntity Customer,
    RoomEntity Room
    );
