using System;

namespace PizzaBlazorFrontend.Models
{
    public class OrderDisplayModel
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int Sum { get; set; }
        public DateTime OrderTime { get; set; }
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public string OrderContents { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
}