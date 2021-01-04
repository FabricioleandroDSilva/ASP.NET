using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CadastroCliente.Models;
using CadastroClientes.AcessoDados.Interfaces;

namespace CadastroClientes.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClientesController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clienteRepositorio.PegarTodos().ToListAsync());
        }

       
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClienteId,Nome,DataNascimento,Sexo,Cep,Endereço,Numero,Complemento,Bairro,Estado,Cidade")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await _clienteRepositorio.Inserir(cliente);
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        public async Task<IActionResult> Edit(int id)
        {
           
            var cliente = await _clienteRepositorio.PegarPeloId(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClienteId,Nome,DataNascimento,Sexo,Cep,Endereço,Numero,Complemento,Bairro,Estado,Cidade")] Cliente cliente)
        {
            if (id != cliente.ClienteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _clienteRepositorio.Atualizar(cliente);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    
                        return NotFound();   
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cliente);
        }

        [HttpPost]
        public async Task<JsonResult> Delete(int id)
        {
       
            await _clienteRepositorio.Excluir(id);
            return Json("Cliente Excluido");
        }

        public ActionResult SelecionarSexo()
        {

            List<SelectListItem> items = new List<SelectListItem>();

            items.Add(new SelectListItem { Text = "Masculino", Value = "M" });

            items.Add(new SelectListItem { Text = "Feminino", Value = "F", Selected = true });

            ViewBag.Sexos = items;

            return View();

        }
    }
}
