﻿using System;
using System.Collections.Generic;

namespace webpractica.Models;

public partial class Usuario
{
    public int UsuarioId { get; set; }

    public string? Nombre { get; set; }

    public string? Documento { get; set; }

    public string? Tipo { get; set; }

    public string? Carnet { get; set; }

    public int? CarreraId { get; set; }
}
