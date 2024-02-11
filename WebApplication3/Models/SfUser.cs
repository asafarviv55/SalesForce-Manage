namespace WebApplication3.Models
{
    public class SfUser
    {
        public int Id { get; set; }
        public int IdInClock { get; set; }
        public string? IdInSF { get; set; }
        public string? SHIFT { get; set; }
        public bool IsWorking { get; set; }
        public bool IsWorkingNow { get; set; }


    }
}
