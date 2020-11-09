using FichaAcademia.AcessoDados;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FichaAcademia.ViewComponents
{
    public class ListaExercicioFichaViewComponent: ViewComponent
    {
        private readonly Contexto _contexto;

       public ListaExercicioFichaViewComponent(Contexto contexto)
        {
            _contexto = contexto;
        }

        public async Task<IViewComponentResult> InvokeAsync(int FichaId)
        {
            return View(await _contexto.ListaExercicios.Include(l=> l.Exercicio).Where(l=> l.FichaId == FichaId).ToListAsync());
        }
    }
}
