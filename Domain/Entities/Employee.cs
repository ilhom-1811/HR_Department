using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Domain.Entities;

public class Employee : BaseEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string ContactInfo { get; set; }
    public DateTime HireDate { get; set; }
    public Position Position { get; set; }
    public Department Department { get; set; }
    public ICollection<Document> Documents { get; set; }
    public EmployeeStatus Status { get; set; }
}
