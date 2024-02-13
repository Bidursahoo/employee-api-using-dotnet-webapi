using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using api.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Context
{
    [Route("api/employee")]
    [ApiController]
    public class EmployeeContext : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public EmployeeContext(ApplicationDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            try
            {
                int a = 0;
                // int b = 0;
                var emps = _context.Employees
                    .FromSql($"EXECUTE dbo.SP_SELECT_EMPLOYEE @DEPT_ID = 0 , @YEAR='0', @EMP_ID = 0 , @NAME=''")
                    .ToList();

                return Ok(emps);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while fetching employees: {ex.Message}");
            }
        }

    }
}