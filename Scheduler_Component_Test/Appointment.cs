namespace Scheduler_Component_Test
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? Text { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int AppointmentOwnerId { get; set; }
        public bool IsDeleted { get; set; }
    }
}
