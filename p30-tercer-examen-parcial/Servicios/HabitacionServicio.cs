using Microsoft.EntityFrameworkCore;

public class HabitacionServicio {
    private readonly ContextoDatos ctx;
    public HabitacionServicio(ContextoDatos contexto) => ctx = contexto;

   public List<Habitacion> ObtenerTodo(string cadenabuscar)
    {
        var _habitaciones = ctx.Habitaciones
            .Include(r => r.Reservas)
            .ThenInclude(c => c.Cliente);
        var habitaciones = from h in _habitaciones select h;

        if (!string.IsNullOrEmpty(cadenabuscar))
        {
            habitaciones = habitaciones.Where(h => h.NoHab.ToString().Contains(cadenabuscar));
        }
        return habitaciones.ToList();
    }
    public bool AgregarActualizar(Habitacion habitacion) {
        try {
            if (habitacion.Id == 0) ctx.Habitaciones.Add(habitacion);
            else ctx.Habitaciones.Update(habitacion);
            ctx.SaveChanges();
            return true;
        }
        catch (Exception ex) { return false; }
    }

    public Habitacion EcontrarPorId(int Id) {
        return ctx.Habitaciones.Find(Id);

    }

    public bool Borrar(int id) {
        try {
            var habitacion = EcontrarPorId(id);
            if(habitacion==null) return false;
            else ctx.Habitaciones.Remove(habitacion);
            ctx.SaveChanges();
            return true;
        } catch (Exception ex) { return false; }
    }

    public double TotIndividual()
    {
        return ctx.Habitaciones.Count(habitacion => habitacion.Tipo == "Individual");
    }

    public double TotDoble()
    {
        return ctx.Habitaciones.Count(habitacion => habitacion.Tipo == "Doble");
    }

    public double TotTriple()
    {
        return ctx.Habitaciones.Count(habitacion => habitacion.Tipo == "Triple");
    }

    public double TotEjecutivo()
    {
        return ctx.Habitaciones.Count(habitacion => habitacion.Tipo == "Ejecutiva");
    }

    public double TotHabitaciones()
    {
        return ctx.Habitaciones.Count();
    }
}