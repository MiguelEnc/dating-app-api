using System;

namespace api.Entities;

public class User
{
    public int Id { get; set; }
    public required string UserName { get; set; }
}
