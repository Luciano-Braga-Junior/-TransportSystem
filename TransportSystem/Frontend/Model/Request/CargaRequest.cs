using System.ComponentModel.DataAnnotations;

namespace Frontend.Model.Request
{
    public class CargaRequest
    {
        [Required(ErrorMessage = "Informar a distância é obrigatório!")]
        public double DistanciaEmKm { get; set; }

        [Required(ErrorMessage = "Informar o peso é obrigatório!")]
        public double PesoEmKg { get; set; }

        [Required(ErrorMessage = "Informar a largura é obrigatório!")]
        public double Largura { get; set; }

        [Required(ErrorMessage = "Informar a altura é obrigatório!")]
        public double Altura { get; set; }

        [Required(ErrorMessage = "Informar o comprimento é obrigatório!")]
        public double Comprimento { get; set; }
    }
}
