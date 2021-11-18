using System;
using AutomapperPoc.Domain.Enumerators;

namespace AutomapperPoc.Domain
{
    public class Person
    {
        public Person(string name, string email, int age)
        {
            Name = name;
            Email = email;
            Age = age;
            Status = PersonStatus.Active;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        protected string _name { get; set; }
        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            _name = name;
        }
        public string Name
        {
            get => _name;
            set => SetName(value);
        }
        
        private string _email { get; set; }
        private void SetEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentNullException(nameof(email));
            }

            _email = email;
        }
        public string Email 
        {
            get => _email;
            set => SetEmail(value);
        }
        
        private int _age { get; set; }
        private void SetAge(int age)
        {
            if (age < 18)
            {
                throw new Exception("Only 18 years old or above");
            }

            _age = age;
        }
        public int Age
        {
            get => _age;
            set => SetAge(value);
        }
        
        private string _status { get; set; }
        private void SetStatus(string status)
        {
            if (string.IsNullOrWhiteSpace(status))
            {
                throw new ArgumentNullException(nameof(status));
            }

            _status = status;
        }
        public string Status 
        {
            get => _status;
            set => SetStatus(value);
        }
        public DateTime CreatedAt { get; protected set; }
        public DateTime UpdatedAt { get; set; }
    }
}
