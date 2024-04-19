﻿namespace Domain.Entities;

public class Department : BaseEntity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public Employee Manager { get; set; }
    public ICollection<Employee> Employees { get; set; }
}
