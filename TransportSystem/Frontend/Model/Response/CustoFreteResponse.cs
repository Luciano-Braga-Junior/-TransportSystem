using System.ComponentModel.DataAnnotations;

namespace Frontend.Model.Response
{
    public class CustoFreteResponse
    {
        public double DistanciaEmKm { get; set; }
        public double PesoEmKg { get; set; }
        public double Largura { get; set; }
        public double Altura { get; set; }
        public double Comprimento { get; set; }
        public double CustoFrete { get; set; }
    }
}
