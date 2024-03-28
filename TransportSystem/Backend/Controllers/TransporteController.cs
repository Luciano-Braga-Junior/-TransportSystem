using Backend.Models.Request;
using Backend.Models.Response;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
        [ApiController]
        [Route("[controller]")]
        public class TransporteController : ControllerBase
        {
            [HttpGet]
            [Route("calcular")]
            public IActionResult CalcularFrete([FromBody] CargaRequest cargaRequest)
            {
                try
                {
                    double custoDoFrete = CalcularCustoDoFrete(cargaRequest);

                    var custoFreteResponse = new CustoFreteResponse
                    {
                        DistanciaEmKm = cargaRequest.DistanciaEmKm,
                        PesoEmKg = cargaRequest.PesoEmKg,
                        Largura = cargaRequest.Largura,
                        Altura = cargaRequest.Altura,
                        Comprimento = cargaRequest.Comprimento,
                        CustoFrete = custoDoFrete
                    };

                    return Ok(custoFreteResponse);
                }
                catch (Exception ex)
                {
                    return StatusCode(500, $"Erro ao calcular o custo do frete: {ex.Message}");
                }
            }
            private double CalcularCustoDoFrete(CargaRequest cargaRequest)
            {
                double valorFixoPorKm = 0.50;
                double adicionalPorQuilo = 1.00;
                double adicionalPorMetroCubico = 2.00;
                double custoDoFrete = (cargaRequest.DistanciaEmKm * valorFixoPorKm) +
                                      (cargaRequest.PesoEmKg * adicionalPorQuilo) +
                                      (cargaRequest.Largura * cargaRequest.Altura * adicionalPorMetroCubico);

                return custoDoFrete;
            }
        }
    }