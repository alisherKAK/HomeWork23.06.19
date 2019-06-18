namespace HomeWork23_06_19.Models
{
    public class EmailSendTask : TaskEntity
    {
        public string SenderEmail { get; set; }
        public string GetterEmail { get; set; }
        public string Header { get; set; }
        public string MainText { get; set; }
    }
}
