using System;
using System.Collections.Generic;

namespace Office.Web.Domain.Models;

public class UserModel
{
    public int Id { get; set; }

    public string NameUser { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
