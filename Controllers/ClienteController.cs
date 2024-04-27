using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ParcialTicona.Data;
using ParcialTicona.Models;

namespace ParcialTicona.Controllers
{
    public class ClienteController :Controller
    {
        private ClienteContext _context;
        public ClienteController(ClienteContext context)
        {
            _context = context;
        }

        public IActionResult Form() {
            return View();
        }

        [HttpPost]
        public IActionResult Form(Cliente c) {
            if (ModelState.IsValid) {
                
                _context.Add(c);
                _context.SaveChanges();
                
                return RedirectToAction("Lista");
            }
            
            return View(c);
        }

        public IActionResult Lista() {
            var clienteLista = _context.TablaCliente.OrderBy(x => x.Nombre).ToList();
            return View(clienteLista);
        }

     
    }
}