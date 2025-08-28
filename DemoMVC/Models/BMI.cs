namespace DemoMVC.Models
{
    public class BMI
    {
        public double Height { get; set; } // Chiều cao (m)
        public double Weight { get; set; } // Cân nặng (kg)
        public double Result { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}
