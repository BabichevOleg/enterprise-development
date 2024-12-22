using AutoMapper;
using CarRentalApp.API.Dto;
using CarRentalApp.Domain;

namespace CarRentalApp.API;

public class Mapping : Profile
{
    public Mapping()
    {
        CreateMap<Car, CarDto>().ReverseMap();
        CreateMap<Client, ClientDto>().ReverseMap();
        CreateMap<RentalPlace, RentalPlaceDto>().ReverseMap();
        CreateMap<RentedCar, RentedCarDto>().ReverseMap();
    }
}
