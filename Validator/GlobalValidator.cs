using System.Text.RegularExpressions;

namespace Validator
{
    public class GlobalValidator<T>
    {
        public static readonly Predicate<string> IsNotNullOrEmpty = (d) => !string.IsNullOrEmpty(d);
        public static readonly Predicate<string> IsNumber = (d) => d == null || new Regex(@"^\d+$").IsMatch(d);

        public static readonly Predicate<string> IsCodigoModular = (d) => d != null && d.Length == 7 && IsNumber(d);
        public static readonly Predicate<string> IsAnexo = (d) => d != null && d.Length == 1 && IsNumber(d);

        public static readonly Predicate<short?> IsValidAnioAcademico = (d) => d != null && d >= 2022 && d <= (short)DateTime.Now.Year + 1;

        public static readonly Predicate<int?> IsIntPositive = (d) => d != null && d.HasValue && d > 0;
        public static readonly Predicate<int?> IsIntUnoDos = (d) => d != null && d.HasValue && (d == 1 || d == 2);
        public static readonly Predicate<int?> IsIntNotNull = (d) => d != null && d.HasValue;

        public static readonly Predicate<string> IsGrado = (d) => d != null && d.Length == 2 && IsNumber(d);
        public static readonly Predicate<string> IsModalidad = (d) => d != null && d.Length == 2 && IsNumber(d);

        public static readonly Predicate<string> IsNivel = (d) => d != null && new Regex(@"^[A-Z]{1}[\d]{1}$").IsMatch(d);
        public static readonly Predicate<string> IsPeriodo = (d) => d != null && d.Length == 2;
        public static readonly Predicate<int?> IsNotNullInt = (d) => d != null && d.HasValue;
        public static readonly Predicate<int?> IsMayorQueCeroInt = (d) => d != null && d.Value > 0;
        public static readonly Predicate<string> IsRol = (d) => d != null && IsNumber(d) && d.Length == 3;
        public static readonly Predicate<string> IsSeccionFase = (d) => d != null && d.Length > 0 && IsNumber(d) && int.Parse(d) > 0;
        public static readonly Predicate<string> IsSeccion = (d) => d != null && d.Length == 2;

        public static readonly Predicate<string> IsLetterOneNumberOne = (d) => d != null && new Regex(@"^[A-Z]{1}[\d]{1}$").IsMatch(d);

        public static bool IsValidLength(string value, short min = 1, short max = 100)
        {
            if (value == null) return false;
            return value.Length >= min && value.Length <= max;
        }

        private static bool IsValidDate(string value)
        {
            DateTime date;
            return DateTime.TryParse(value, out date);
        }

        public static bool IsValidRangeDate(DateTime value, DateTime? min = null, DateTime? max = null)
        {
            if (min == null) return value.Date <= max?.Date;
            if (max == null) return value.Date >= min?.Date;
            return value.Date >= min?.Date && value.Date <= max?.Date;
        }

        public static readonly Predicate<string> IsNroResolucion = (d) => d != null && new Regex(@"^[-a-zA-ZñÑäÄëËïÏöÖüÜáéíóúÁÉÍÓÚ(º°,/;_'*""“´.:¡!¿?)\d\s]+$").IsMatch(d);
        public static readonly Predicate<string> IsNivelIdPermitidoEBR = (d) => d != null && new Regex(@"\b(A1|A2|A3|A5|B0|F0)\b").IsMatch(d);
    }
}