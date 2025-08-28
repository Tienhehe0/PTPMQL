using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
   public class Employee : Person
{
    public string Position { get; set; } = string.Empty;
    public double Salary { get; set; }
}

}