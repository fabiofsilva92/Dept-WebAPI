using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Dept.Repository;
using Dept.Domain;

namespace Dept_WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FuncionarioController : ControllerBase
    {
        public readonly IRepository _repo;
        public FuncionarioController(IRepository repo)
        {
            _repo = repo;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var results = await _repo.GetAllFuncionarioAsync();
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
                var results = await _repo.GetAllFuncionarioAsyncById(id);
                return Ok(results);
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falhou");
            }  
            
        }

        [HttpPost]
        public async Task<IActionResult> Post(Funcionario model)
        {
            try
            {
                _repo.Add(model);

                if(await _repo.SaveChangesAsync())
                {
                    return Created($"/api/funcionario/{model.Id}", model);
                }
                
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falhou");
            }      

            return BadRequest();
        }

        [HttpPut]
        public async Task<IActionResult> Put(int FuncionaioId, Funcionario model)
        {
            try
            {
                var funcionario = await _repo.GetAllFuncionarioAsyncById(FuncionaioId);

                if(funcionario == null) return NotFound();

                _repo.Update(model);

                if(await _repo.SaveChangesAsync()){
                    return Created($"/api/funcionario/{model.Id}", model);
                }
                
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falhou");
            }      

            return BadRequest();
        }        

        [HttpDelete]
        public async Task<IActionResult> Delete(int FuncionaioId)
        {
            try
            {
                var funcionario = await _repo.GetAllFuncionarioAsyncById(FuncionaioId);

                if(funcionario == null) return NotFound();

                _repo.Delete(funcionario);

                if(await _repo.SaveChangesAsync()){
                    return Ok();
                }
                
            }
            catch (System.Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "BD falhou");
            }      

            return BadRequest();
        }            
    }
}
