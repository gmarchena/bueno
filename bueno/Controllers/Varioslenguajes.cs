using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace bueno.Controllers
{
    public class VarioslenguajesController
    {
        private static Dictionary<string, string> _Lenguajes = new Dictionary<string, string>();

        [HttpPost("saludar/{idioma}")]
        public string Post(string idioma, [FromBody]string sound)
        {
            _Lenguajes[idioma] = sound;

            return String.Format("{0} Saludo Agregado !", idioma);
        }

        [HttpGet("saludar/{idioma}")]
        public string Get(string idioma)
        {
            if (!_Lenguajes.ContainsKey(idioma))
            {
                return "Idioma no  encontrado.";
            }

            return _Lenguajes[idioma];
        }

        [HttpPatch("saludar/{idioma}")]
        public string Patch(string idioma, [FromBody]string sound)
        {
            if (!_Lenguajes.ContainsKey(idioma))
            {
                return "idioma no encontrado.";
            }

            _Lenguajes[idioma] = sound;
            return "Saludo actualizado.";
        }

        [HttpDelete("saludar/{idioma}")]
        public string Delete(string idioma)
        {
            if (!_Lenguajes.ContainsKey(idioma))
            {
                return "idioma no encontrado.";
            }

            _Lenguajes.Remove(idioma);

            return "Idioma borrado.";
        }
    }
}
