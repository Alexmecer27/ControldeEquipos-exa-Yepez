
public class Equipo
{
    public int ID_Equipo { get; set; }
    public string Nombre_Equipo { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Numero_Serial { get; set; }
    public DateTime Fecha_Adquisicion { get; set; }
    public int Departamento_ID { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<Mantenimiento> Mantenimientos { get; set; }
}