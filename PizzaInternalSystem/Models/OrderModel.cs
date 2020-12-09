using System;

namespace PizzaDataLibrary.Models
{
    public class OrderModel
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public float Sum { get; set; }
        public DateTime OrderTime { get; set; }
        public int StatusId { get; set; } //TODO: реализовать по-человечески
        public string OrderContents { get; set; }
        public int EmployeeId { get; set; }
    }
}