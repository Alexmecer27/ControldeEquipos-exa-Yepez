using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Departamento
{
    [Key]
    public int ID_Departamento { get; set; }
    public string Nombre_Departamento { get; set; }
    public ICollection<Equipo> Equipos { get; set; }
}