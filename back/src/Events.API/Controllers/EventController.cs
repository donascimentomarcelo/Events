using System;
using System.Collections.Generic;
using System.Linq;
using Events.API.Data;
using Events.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Events.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly DataContext _context;

        public EventController(DataContext context)
        {
            this._context = context;

        }

        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _context.Events;
        }

        [HttpGet("{id}")]
        public Event GetById(int id) 
        {
            return _context.Events.FirstOrDefault(ev => ev.EventId == id);
        }
    }
}
