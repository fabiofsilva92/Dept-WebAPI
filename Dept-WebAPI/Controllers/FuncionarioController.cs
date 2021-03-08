using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Dept_WebAPI.Models;
using Dept_WebAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Dept_WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public readonly DataContext _context;
        public FuncionarioController(DataContext context)
        {
            _context = context;

        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _context.Funcionarios.ToListAsync();
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falhou");
            }      
        }


        //GET COM PARAMETRO
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var results = await _context.Funcionarios.FirstOrDefaultAsync(x => x.FuncionarioId == id);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falhou");
            }  
            
        }
    }
}
