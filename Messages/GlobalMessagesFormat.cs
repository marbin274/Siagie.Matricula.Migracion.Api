namespace Messages
{
    public partial class GlobalMessages
    {
        public partial class Format
        {
            public const string Usuario = "El usuario debe tener solo caracteres alfanuméricos.";
            public const string Anexo = "El anexo debe tener 1 dígito.";
            public const string CodigoModular = "El código modular debe tener 7 dígitos.";
            public const string CodigoModularDestino = "El código modular destino debe tener 7 dígitos.";

            public const string Anio = "El año académico debe ser mayor o igual al año 2022 y menor o igual al año actual.";
            public const string PeriodoId = "El período de evaluación es numérico y mayor a cero.";
            public const string IdTab = "El id del Tab es numérico y puede tomar el valor de 1 ó 2.";
            public const string GradoId = "El grado de evaluación es numérico y mayor a cero.";
            public const string RolId = "El rol debe tener 3 dígitos.";

            public const string PeriodoPromocionalId = "El período promocional es numérico y mayor a cero.";
            public const string SeccFasePeriodoPromId = "La seccion fase período promocional es numérico y mayor a cero.";

            public const string IdNivel = "En el nivel educativo el primer caracter deber ser una letra mayúscula seguido de un dígito.";
            public const string IdModalidad = "La modalidad debe tener 2 dígitos.";
            public const string GradoIdLEgacy = "El grado debe tener 2 dígitos.";
            public const string SeccionIdLegacy = "La sección debe tener 2 dígitos.";
            public const string SeccionOrigenIdLEgacy = "La sección origen contiene valores no permitidos.";
            public const string SeccionDestinoIdLEgacy = "La sección destino contiene valores no permitidos.";

            public const string ValueLstGradoItemSame = "Existen valores duplicados en la lista de grados.";
            public const string ValueLstSeccionItemSame = "Existen valores duplicados en la lista de secciones.";

            public const string SeccionFaseId = "La sección es numérico y mayor a cero.";
            public const string PeriodoEvaluacionId = "El período de evaluación debe ser de dos caracter (una letra mayúscula y un dígito).";
            public const string PeriodoEvaluacionEnteroId = "El período de evaluación debe ser numérico y mayor a cero.";

            public const string AccionInformeProgreso = "El tipo de acción es numérico y mayor a cero.";
            public const string EstudianteId = "El id del estudiante es numérico y mayor a cero.";

            public const string ValueLstEstudianteItemSame = "Existen valores duplicados en la lista de estudiantes.";

            public const string Nivel = "El nivel debe ser de dos caracter (una letra mayúscula y un dígito).";
            public const string NivelPermitidoEBR = "Solo se permite nivel educativo correspondiente a la modalidad EBR";
            public const string ValueLstAreaItemSame = "Existen valores duplicados en la lista de areas.";
        }
    }
}