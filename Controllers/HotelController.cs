using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace api1
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : Controller
    {
        [HttpPost("AddFilial")]
        public void AddFilial([FromBody] MFilial filial)
        {
            using (var context = new DataContext())
            {
                context.Filiais.Add(filial);
                context.SaveChanges();
            }
        }

        [HttpPost("AddQuarto")]
        public void AddQuarto([FromBody] MQuarto quarto)
        {
            using (var context = new DataContext())
            {
                context.Quartos.Add(quarto);
                context.SaveChanges();
            }
        }

        [HttpPost("AddCliente")]
        public void AddCliente([FromBody] MCliente cliente)
        {
            using (var context = new DataContext())
            {
                context.Clientes.Add(cliente);
                context.SaveChanges();
            }
        }

        [HttpGet("GetFiliais")]
        public List<MFilial> GetFiliais()
        {
            using (var context = new DataContext())
            {
                return context.Filiais.ToList();
            }
        }

        [HttpGet("GetQuartos")]
        public List<MQuarto> GetQuartos()
        {
            using (var context = new DataContext())
            {
                return context.Quartos.ToList();
            }
        }

        [HttpGet("GetClientes")]
        public List<MCliente> GetClientes()
        {
            using (var context = new DataContext())
            {
                return context.Clientes.ToList();
            }
        }

        [HttpGet("GetFilial/{id}")]
        public IActionResult GetFilial(int id)
        {
            using (var context = new DataContext())
            {
                var filial = context.Filiais.FirstOrDefault(f => f.FilialID == id);
                if (filial == null)
                {
                    return NotFound();
                }
                return new ObjectResult(filial);
            }
        }

        [HttpGet("GetQuarto/{id}")]
        public IActionResult GetQuarto(int id)
        {
            using (var context = new DataContext())
            {
                var quarto = context.Quartos.FirstOrDefault(q => q.QuartoID == id);
                if (quarto == null)
                {
                    return NotFound();
                }
                return new ObjectResult(quarto);
            }
        }

        [HttpGet("GetCliente/{id}")]
        public IActionResult GetCliente(int id)
        {
            using (var context = new DataContext())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.ClienteID == id);
                if (cliente == null)
                {
                    return NotFound();
                }
                return new ObjectResult(cliente);
            }
        }

        [HttpPut("UpdateFilial/{id}")]
        public void UpdateFilial(int id, [FromBody] MFilial filial)
        {
            using (var context = new DataContext())
            {
                var existingFilial = context.Filiais.FirstOrDefault(f => f.FilialID == id);
                if (existingFilial == null)
                {
                    return;
                }
                context.Entry(existingFilial).CurrentValues.SetValues(filial);
                context.SaveChanges();
            }
        }

        [HttpPut("UpdateQuarto/{id}")]
        public void UpdateQuarto(int id, [FromBody] MQuarto quarto)
        {
            using (var context = new DataContext())
            {
                var existingQuarto = context.Quartos.FirstOrDefault(q => q.QuartoID == id);
                if (existingQuarto == null)
                {
                    return;
                }
                context.Entry(existingQuarto).CurrentValues.SetValues(quarto);
                context.SaveChanges();
            }
        }

        [HttpPut("UpdateCliente/{id}")]
        public void UpdateCliente(int id, [FromBody] MCliente cliente)
        {
            using (var context = new DataContext())
            {
                var existingCliente = context.Clientes.FirstOrDefault(c => c.ClienteID == id);
                if (existingCliente == null)
                {
                    return;
                }
                context.Entry(existingCliente).CurrentValues.SetValues(cliente);
                context.SaveChanges();
            }
        }

        [HttpDelete("DeleteFilial/{id}")]
        public void DeleteFilial(int id)
        {
            using (var context = new DataContext())
            {
                var filial = context.Filiais.FirstOrDefault(f => f.FilialID == id);
                if (filial == null)
                {
                    return;
                }
                context.Filiais.Remove(filial);
                context.SaveChanges();
            }
        }

        [HttpDelete("DeleteQuarto/{id}")]
        public void DeleteQuarto(int id)
        {
            using (var context = new DataContext())
            {
                var quarto = context.Quartos.FirstOrDefault(q => q.QuartoID == id);
                if (quarto == null)
                {
                    return;
                }
                context.Quartos.Remove(quarto);
                context.SaveChanges();
            }
        }

        [HttpDelete("DeleteCliente/{id}")]
        public void DeleteCliente(int id)
        {
            using (var context = new DataContext())
            {
                var cliente = context.Clientes.FirstOrDefault(c => c.ClienteID == id);
                if (cliente == null)
                {
                    return;
                }
                context.Clientes.Remove(cliente);
                context.SaveChanges();
            }
        }
    }
}