using System;
using System.ComponentModel.DataAnnotations;

public class Cliente
{
    public int Id { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "El nombre debe tener 30 caracteres como máximo.")]
    public string Nombre { get; set; }

    [Required]
    [StringLength(30, ErrorMessage = "El apellido debe tener 30 caracteres como máximo.")]
    public string Apeido { get; set; }

    public char Genero { get; set; }

    [DataType(DataType.DateTime, ErrorMessage = "Error de fecha")]
    public DateTime FechaCumple { get; set; }

    [EmailAddress(ErrorMessage = "El correo no es válido.")]
    public string Correo { get; set; }

    [RegularExpression(@"^\d{10}$", ErrorMessage = "El número de teléfono debe contener exactamente 10 dígitos.")]
    [StringLength(10, ErrorMessage = "El número de teléfono debe tener 10 caracteres.", MinimumLength = 10)]
    public string Telefono { get; set; }

    [Display(Name = "Nombre Completo")]
    public string NombreCompleto
    {
        get { return Nombre + " " + Apeido; }
    }

    public ICollection<Reserva> Reservas { get; set; }
}