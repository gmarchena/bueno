using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bueno.Controllers
{
    public class SaludoController
    {
        [HttpGet("saludan/{idioma}")]
        public String Saludo(string idioma)
        {
            switch (idioma)
            {
                case "espa":
                    return "Hola l";
                case "english":
                    return "Hello h";
            }
            return String.Empty;
        }
    }
}
