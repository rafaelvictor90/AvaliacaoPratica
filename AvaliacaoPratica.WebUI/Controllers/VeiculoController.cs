using AvaliacaoPratica.Application.DTOs;
using AvaliacaoPratica.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace AvaliacaoPratica.WebUI.Controllers
{
    public class VeiculoController : Controller
    {
        private readonly IVeiculoService _veiculoService;
        private readonly IStatusService _statusService;
        private readonly IMarcaService _marcaService;
        private readonly IProprietarioService _proprietarioService;

        public VeiculoController(IVeiculoService veiculoService
            , IStatusService statusService
            , IMarcaService marcaService
            , IProprietarioService proprietarioService)
        {
            _veiculoService = veiculoService;
            _statusService = statusService;
            _marcaService = marcaService;
            _proprietarioService = proprietarioService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var veiculo = await _veiculoService.GetVeiculos();
            return View(veiculo);
        }

        [HttpGet()]
        public async Task<IActionResult> Create()
        {
            ViewBag.MarcasList = await _marcaService.GetMarcasAtivas();
            ViewBag.ProprietariosList = await _proprietarioService.GetProprietariosAtivos();

            return View();
        }

        [HttpPost()]
        public async Task<IActionResult> Create(VeiculoDTO veiculoDTO)
        {
            if (ModelState.IsValid)
            {
                if (await _veiculoService.GetByRenavam(veiculoDTO.Renavam) == null)
                {
                    await _veiculoService.Add(veiculoDTO);
                    return RedirectToAction(nameof(Index));
                }
            }

            return View(veiculoDTO);
        }

        [HttpGet()]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var veiculoDTO = await _veiculoService.GetById(id);

            if (veiculoDTO == null) return NotFound();

            ViewBag.StatusList = await _statusService.GetStatus();

            return View(veiculoDTO);
        }

        [HttpPost()]
        public async Task<IActionResult> Edit(VeiculoDTO veiculoDTO)
        {
            if(ModelState.IsValid)
            {
                await _veiculoService.Update(veiculoDTO);
                return RedirectToAction(nameof(Index));
            }

            return View(veiculoDTO);
        }
    }
}
