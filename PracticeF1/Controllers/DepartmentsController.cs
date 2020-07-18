using Microsoft.AspNetCore.Mvc;
using PracticeF1.DataAccess;
using PracticeF1.Models;
using System;
using System.Collections.Generic;

namespace PracticeF1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IDataAccessProvider _dataAccessProvider;

        public DepartmentsController(IDataAccessProvider dataAccessProvider)
        {
            _dataAccessProvider = dataAccessProvider;
        }

        [HttpGet]
        public IEnumerable<Departments> Get()
        {
            return _dataAccessProvider.GetDepartmentsRecords();
        }



        [HttpPost]
        public IActionResult Create([FromBody] Departments departments)
        {
            if (ModelState.IsValid)
            {

                _dataAccessProvider.AddDepartmentsRecord(departments);

                return Ok();
            }
            return BadRequest();
        }

        [HttpGet("{id}")]
        public Departments Details(int id)
        {
            return _dataAccessProvider.GetDepartmentsSingleRecord(id);
        }

        [HttpPut("{id}")]
        public IActionResult Edit([FromBody] Departments departments)
        {
            if (ModelState.IsValid)
            {
                _dataAccessProvider.UpdateDepartmentsRecord(departments);
                return Ok();
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteConfirmed(int id)
        {
            var data = _dataAccessProvider.GetDepartmentsSingleRecord(id);
            if (data == null)
            {
                return NotFound();
            }
            _dataAccessProvider.DeleteDepartmentsRecord(id);
            return Ok();
        }
    }
}
