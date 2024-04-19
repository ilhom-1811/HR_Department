using System;
using System.Collections.Generic;

namespace Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; } = Guid.NewGuid();
}