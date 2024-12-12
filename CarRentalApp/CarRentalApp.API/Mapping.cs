using AutoMapper;
using CarRentalApp.API.DTO;
using CarRentalApp.Domain;

namespace CarRentalApp.API;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<Car, CarDTO>().ReverseMap();
        CreateMap<Client, ClientDTO>().ReverseMap();
        CreateMap<RentalPlace, RentalPlaceDTO>().ReverseMap();
        CreateMap<RentedCar, RentedCarDTO>().ReverseMap();
    }
}
