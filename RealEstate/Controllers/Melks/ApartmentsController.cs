using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.App.DTos.Melks.Gardens;
using RealEstate.App.Models.Melks;
using RealEstate.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Controllers.Melks
{
    [Route("/api/apartment")]
    [ApiController]
    public class ApartmentsController : ControllerBase
    {
        private readonly DbSet<Apartmant> _apartmants;
        private readonly EFDataContext _context;
        public ApartmentsController()
        {
            _context = new EFDataContext();
            _apartmants = _context.Apartmants;
        }
        
        [HttpPost]
        public void Add([FromBody] AddApartmantDto dto)
        {
            _apartmants.Add(AddApartmant(dto));
            _context.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var apartmant = _apartmants.FirstOrDefault(_ => _.Id == id);
            ApartmantNotFound(apartmant);
            _context.Remove(apartmant);
        }

        [HttpPut("{id}")]
        public void Update(int id, UpdateApartmantDto dto)
        {
            var apartmant = _apartmants.FirstOrDefault(_ => _.Id == id);
            ApartmantNotFound(apartmant);
            apartmant.Title = dto.Title;
            apartmant.Price = dto.Price;
            apartmant.Detail = dto.Detail;
            apartmant.HasParking = dto.HasParking;
            apartmant.HasStoreRoom = dto.HasStoreRoom;
            apartmant.HasElevator = dto.HasElevator;
            _context.SaveChanges();
        }

        [HttpGet]
        public List<GetApartmantDto> GetAll()
        {
            return _apartmants.Where(_ => _.IsDeleted == false).Select(_ => new GetApartmantDto
            {
                Id = _.Id,
                Title = _.Title,
                Price = _.Price,
                Address = new AddAdressDto { Title = _.Address.Title, Latitude = _.Address.Latitude, Longitude = _.Address.Longitude },
                CreateDate = _.CreateDate,
                Age=_.Age,
                HasElevator=_.HasElevator,
                HasParking=_.HasParking,
                RoomCount=_.RoomCount,
                Size=_.Size,
                Floor=_.Floor
            }).ToList();
        }

        private static void ApartmantNotFound(Apartmant apartmant)
        {
            if (apartmant == null)
            {
                throw new Exception("Apartmant Not Found");
            }
        }
        private static Apartmant AddApartmant(AddApartmantDto dto)
        {
            var apartmants = new Apartmant
            {
                Title = dto.Title,
                CreateDate = dto.CreateDate,
                Detail = dto.Detail,
                Price = dto.Price,
                Size = dto.Size,
                Address = new Address
                {
                    Latitude = dto.Address.Latitude,
                    Longitude = dto.Address.Longitude,
                    Title = dto.Address.Title
                },
                IsActive = dto.IsActive,
                HasLoan=dto.HasLoan,
                HasElevator=dto.HasElevator,
                HasParking=dto.HasParking

            };
            return apartmants;
        }
    }
}
