using api_orcamento.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_orcamento.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MvtController : ControllerBase
  {
    private readonly Context _context;


    public MvtController(Context context)
    {
      _context = context;
    }


    [HttpGet]
    [Route("/mvt")]
    public async Task<ActionResult> Get()
    {
      var query = (from m in _context.MvtVendasEstruturaConsultaMes
                   select new
                   {
                     CodProduto = m.CodProduto,
                     NomeProduto = m.NomeProduto,
                     CustoUni = m.CustoUni,
                     Mes = m.Data,
                     TotalVenda = m.ValorVenda,
                     TotalCusto = m.CustoTotal
                   }).Take(1000);

      return Ok(await query.ToListAsync());
    }

  }
}
