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
    [Route("/GetByYear")]
    public async Task<ActionResult> GetByYear(int ano)
    {
      var query = _context.MvtVendasEstruturaConsultaMes
        .Where(d => d.Data.Year == ano)
        .Select(d => new
        {
          CodProduto = d.CodProduto,
          NomeProduto = d.NomeProduto,
          CustoUni = d.CustoUni,
          Data = d.Data,
          ValorVenda = d.ValorVenda,
          CustoTotal = d.CustoTotal
        }).Take(1000);

      return Ok(await query.ToListAsync());

      //var sqlCommand = $"select top 100 codProduto, nomeProduto, month(data) as mes, sum(valorVenda),  sum(custoTotal), custoUni  FROM MvtVendasEstruturaConsultaMes WHERE YEAR(data) = " + ano + " GROUP BY codProduto, nomeProduto, month(data), custoUni";
      //var executeSQL = await _context.MvtVendasEstruturaConsultaMes.FromSqlRaw(sqlCommand).ToListAsync();
      //return Ok(executeSQL);
    }

    [HttpGet]
    [Route("/Get")]
    public async Task<ActionResult> Get(int ano)
    {
      var query = _context.MvtVendasEstruturaConsultaMes
         .Where(d => d.Data.Year == ano)
         .Select(d => new
         {
           CodProduto = d.CodProduto,
           NomeProduto = d.NomeProduto,
           Mes = d.Data,
           ValorVenda = d.ValorVenda,
         }).Take(1000);

      return Ok(await query.ToListAsync());
    }


    [HttpGet]
    [Route("/GetCountRecord")]
    public  int GetCountRecord(int ano)
    {
      int count = _context.MvtVendasEstruturaConsultaMes
        .Where(d => d.Data.Year == ano)
        .Select(d => d.CodProduto).Distinct().Count();

      return count;
    }
  }
}
