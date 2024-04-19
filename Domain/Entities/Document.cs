using System;

namespace Domain.Entities;

public class Document : BaseEntity
{
    public string Type { get; set; }
    public DateTime Date { get; set; }
    public string Status { get; set; }
    public Employee Employee { get; set; }
}
