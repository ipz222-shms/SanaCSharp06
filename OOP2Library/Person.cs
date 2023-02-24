﻿namespace OOP2Library
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Person()
            : this(string.Empty, string.Empty) { }
        public Person(string firstName, string lastName) 
            : this(firstName, lastName, DateTime.Today) { }
        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public override string ToString()
        {
            return $"{LastName} {FirstName}";
        }

        public virtual string ShowInfo()
        {
            return $"{this}:\n\tДата народження: {Birthday:d}";
        }
    }
}