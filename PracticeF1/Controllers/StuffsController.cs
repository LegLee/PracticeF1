using Microsoft.AspNetCore.Mvc;
using PracticeF1.DataAccess;
using PracticeF1.Models;
using System;
using System.Collections.Generic;

namespace PracticeF1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StuffController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public StuffController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Stuff> Get()
        {
            return _dataAccessProvider.GetStuffRecords();
        }



        [HttpPost]
        public IActionResult Create([FromBody] Stuff stuff)
        {
            if (ModelState.IsValid)
            {

                _dataAccessProvider.AddStuffRecord(stuff);

                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Stuff Details(int id)
        {
            return _dataAccessProvider.GetStuffSingleRecord(id);
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromBody] Stuff stuff)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateStuffRecord(stuff);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _dataAccessProvider.GetStuffSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteStuffRecord(id);
            return Ok();
        }
    }
}
