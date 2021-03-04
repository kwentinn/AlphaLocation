using System;
using ValueOf;

namespace AlphaLocation.Customers.Domain
{
    public class Birthdate : ValueOf<DateTime, Birthdate>
    {
        public static Birthdate From(DateTime? birthdate)
        {
            if (!birthdate.HasValue)
            {
                return null;
            }
            return ValueOf<DateTime, Birthdate>.From(birthdate.Value);
        }
    }
}