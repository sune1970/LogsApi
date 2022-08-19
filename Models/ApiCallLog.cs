namespace Homework.API
{
    public class ApiCallLog
    {
        public string PartitionKey { get; set; }
        public string RowKey { get; set; }
        public DateTime Timetamp { get; set; }
        public string Description { get; set; }
        public string Body { get; set; }
    }
}
