using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AvaliacaoPratica.WebUI.Controllers
{
    public class ProprietarioController : Controller
    {
        private readonly IProprietarioService _proprietarioService;

        public ProprietarioController(IProprietarioService proprietarioService)
        {
            _proprietarioService = proprietarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var proprietario = await _proprietarioService.GetProprietarios();
            return View(proprietario);
        }


        [HttpGet()]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost()]
        public async Task<IActionResult> Create(ProprietarioDTO proprietarioDTO)
        {
            if (await _proprietarioService.GetByDocumento(proprietarioDTO.Documento) == null)
            {
                proprietarioDTO.Status = true;
                await _proprietarioService.Add(proprietarioDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(proprietarioDTO);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var proprietarioDTO = await _proprietarioService.GetById(id);

            if (proprietarioDTO == null) return NotFound();

            return View(proprietarioDTO);
        }

        [HttpPost()]
        public async Task<IActionResult> Edit(ProprietarioDTO proprietarioDTO)
        {
            try
            {
                await _proprietarioService.Update(proprietarioDTO);
            }
            catch (System.Exception)
            {
                throw;
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
