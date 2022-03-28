using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AvaliacaoPratica.WebUI.Controllers
{
    public class MarcaController : Controller
    {
        private readonly IMarcaService _marcaService;

        public MarcaController(IMarcaService marcaService)
        {
            _marcaService = marcaService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var marcas = await _marcaService.GetMarcas();
            return View(marcas);
        }

        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public async Task<IActionResult> Create(MarcaDTO marcaDTO)
        {
            if (ModelState.IsValid)
            {
                if (await _marcaService.GetByNome(marcaDTO.Nome) == null)
                {
                    marcaDTO.Status = true;
                    await _marcaService.Add(marcaDTO);
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(marcaDTO);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var marcasDto = await _marcaService.GetById(id);

            if (marcasDto == null) return NotFound();

            return View(marcasDto);
        }

        [HttpPost()]
        public async Task<IActionResult> Edit(MarcaDTO marcaDTO)
        {
            try
            {
                await _marcaService.Update(marcaDTO);
            }
            catch (System.Exception)
            {
                throw;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
