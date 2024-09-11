using System;
using System.Collections.Generic;

namespace EX01.Entities
{
    internal class User
    {
        string Name {  get; set; }
        DateTime Date { get; set; }

        public User(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        public override bool Equals(object? obj)
        {
            if(!(obj is User))
            {
                return false;
            }

            User other = obj as User;

            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
