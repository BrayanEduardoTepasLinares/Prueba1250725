using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Prueba1250725.Models;

public partial class User
{
    public int Id { get; set; }

    [Display(Name = "nombre")]
    public string Name { get; set; } = null!;

    [Display(Name = "correo")]
    public string Email { get; set; } = null!;

    [Display(Name = "contraseña")]
    public string Password { get; set; } = null!;
    [Display(Name = "rol")]
    public int RoleId { get; set; }
    [Display(Name = "rol")]
    public virtual Role? Role { get; set; } = null!;
}
