using System;
using System.Collections.Generic;

namespace Office.Web.DAL.Entities;

public  class UserEntity : BaseEntity
{
 
    public string NameUser { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;
}
