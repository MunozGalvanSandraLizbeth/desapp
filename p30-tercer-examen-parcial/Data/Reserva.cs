using System;
using System.ComponentModel.DataAnnotations;

public class Reserva
{
    public int Id { get; set; }
    public int HabitacionId { get; set; }
    public int ClienteId { get; set; }

    [DataType(DataType.DateTime, ErrorMessage = "Error de fecha")]
    public DateTime InicioReserva { get; set; }

    [DataType(DataType.DateTime, ErrorMessage = "Error de fecha")]
    public DateTime FinReserva { get; set; }

    public int DiasReserva
    {
        get { return (int)(FinReserva - InicioReserva).TotalDays; }
    }

    public Habitacion Habitacion { get; set; }
    public Cliente Cliente { get; set; }
}