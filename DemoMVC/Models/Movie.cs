using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models;

public class MVC
{
    public int Id { get; set; }
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }
    public string? Genre { get; set; }
    public decimal price { get; set; }
}