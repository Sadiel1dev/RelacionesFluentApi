using System.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Infraestructura.Data;
using Core.Entidades;
using Microsoft.EntityFrameworkCore;
using API.Dtos;
using AutoMapper;


namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TiendaController : ControllerBase
    {
        public readonly Contexto contexto;
        public readonly IMapper Mapper;
        public TiendaController(Contexto contexto,IMapper mapper)
        {
            this.Mapper = mapper;
            this.contexto = contexto;
            
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<Cliente>>> GetAll(){
            
            return await contexto.Clientes.ToListAsync();
        }

        [HttpGet("id")]
        public async Task<ActionResult<Cliente>> Get(int id){
            
            return await contexto.Clientes.FirstAsync(x=>x.Id == id);
        }

        [HttpPost]
        public async Task<ActionResult<Cliente>> Crear(ClienteCreateDto cliente){
            
            var modelo=Mapper.Map<Cliente>(cliente);
            await contexto.Clientes.AddAsync(modelo);
            await contexto.SaveChangesAsync();
            return Ok(modelo);
        }

        [HttpPut("id")]
        public async Task<ActionResult<Cliente>> Put(Cliente cliente){
           
            contexto.Clientes.Update(cliente);
            await contexto.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("id")]
        public async Task<ActionResult<Cliente>> Delete(Cliente cliente){
           
            contexto.Clientes.Remove(cliente);
            await contexto.SaveChangesAsync();
            return NoContent();
        }
    }
}