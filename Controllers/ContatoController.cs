using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProcessoSeletivoBLUE.Context;
using ProcessoSeletivoBLUE.Models;

namespace ProcessoSeletivoBLUE.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        // recebe o banco de dados através do construtor e atribui à _context
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Read()
        {
            var contatos = _context.Contatos.ToList();
            if (!contatos.Any())
                return NotFound("Não há contatos");
            return Ok(contatos);
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Contatos.Add(contato);
            _context.SaveChanges();
            return Ok(contato);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contato contato)
        {
            var ContatoBanco = _context.Contatos.Find(id);
            
            ContatoBanco.Nome = contato.Nome;
            ContatoBanco.Email = contato.Email;
            ContatoBanco.Numero = contato.Numero;

            _context.Contatos.Update(ContatoBanco);
            _context.SaveChanges();

            return Ok(ContatoBanco);
        }
    }
}