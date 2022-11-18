namespace FinalAssessmentProject.Model
{
    public class Vehicles
    {
        private int Id { get; set; }
        private string Brand { get; set; } = string.Empty;

        private string Vin { get; set; } = string.Empty;
        private string Color { get; set; } = string.Empty;
        private int Year { get; set; }
        private int OwnerId { get; set; }
    }
}
