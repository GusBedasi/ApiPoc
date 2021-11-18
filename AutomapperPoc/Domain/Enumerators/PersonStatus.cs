using System.Collections.Generic;

namespace AutomapperPoc.Domain.Enumerators
{
    public static class PersonStatus
    {
        public const string Active = "active";
        public const string Deactivated = "deactivated";
        public const string Deleted = "deleted";

        public static IEnumerable<string> GetValues()
        {
            yield return Active;
            yield return Deactivated;
            yield return Deleted;
        }
    }
}
