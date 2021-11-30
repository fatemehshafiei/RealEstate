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
    [Route("/api/gardens")]
    [ApiController]
    public class GardensController : ControllerBase
    {
        private readonly EFDataContext _context;
        private readonly DbSet<Garden> _gardens;

        public GardensController()
        {
            _context = new EFDataContext();
            _gardens = _context.Gardens;
        }
        [HttpPost]
        public void Add([FromBody] AddGardenDto dto)
        {
            _gardens.Add(AddGarden(dto));
            _context.SaveChanges();
        }

        private static Garden AddGarden(AddGardenDto dto)
        {
            var garden = new Garden
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
                IsActive = dto.IsActive
            };
            return garden;
        }
        [HttpGet]
        public List<GetGardenDto> GetAll()
        {
            return _gardens.Where(_=>_.IsDeleted==false).Select(_ => new GetGardenDto
            {
                Id = _.Id,
                Title = _.Title,
                Price = _.Price,
                Address = new AddAdressDto { Title = _.Address.Title, Latitude = _.Address.Latitude, Longitude = _.Address.Longitude },
                CreateDate = _.CreateDate
            }).ToList();
        }
    }
}
