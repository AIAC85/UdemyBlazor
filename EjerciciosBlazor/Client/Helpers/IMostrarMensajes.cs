﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjerciciosBlazor.Client.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string mensaje);
    }
}
