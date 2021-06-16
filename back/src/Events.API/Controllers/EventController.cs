using System;
using System.Collections.Generic;
using Events.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Events.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {

        public EventController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            yield return new Event()
            {
                EventId = 1,
                Local = "Angular 11 and .NET 5",
                DateEvent = DateTime.Now.AddDays(2).ToString(),
                Theme = "1º class",
                QuantityPeople = 250,
                Allotment = "Test",
                ImageURL = "./path/"
            };
        }
    }
}
