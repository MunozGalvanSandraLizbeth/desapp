using System.ComponentModel.DataAnnotations;
public class Articulo {
    [Key]
    public int Id {get; set;}
    [Required]
    [MinLength(3, ErrorMessage="Mínimo 3 dígitos"), MaxLength(25, ErrorMessage="Máximo 35 dígitos")]
    public string Descripcion {get; set;}
    [Range(typeof(DateTime), "01/01/2023", "31/12/2024", ErrorMessage="Fecha fuera de rango de edad")]
    public DateTime FechaAlta {get; set;}
    [Range(1,100, ErrorMessage="Haz superado el límite de productos")]
    public int Cantidad {get; set;}
    [Range(1,2500, ErrorMessage="Haz superado el límite de precio")]
    public double Precio {get; set;}
    public string UdeMedida {get; set;}
}