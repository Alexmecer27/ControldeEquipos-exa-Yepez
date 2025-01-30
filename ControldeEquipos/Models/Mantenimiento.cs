public class Mantenimiento
{
    public int ID_Mantenimiento { get; set; }
    public int Equipo_ID { get; set; }
    public DateTime Fecha_Mantenimiento { get; set; }
    public string Descripcion { get; set; }
    public string Tecnico { get; set; }
    public Equipo Equipo { get; set; }
}