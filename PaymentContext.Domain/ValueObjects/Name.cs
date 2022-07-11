using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName,3, "Name.FirstName", "Nome deve conter no mínimo 3 catacteres")
                .HasMinLen(LastName,3, "Name.LastName", "Sobrenome deve conter no mínimo 3 catacteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter no máximo 40 catacteres")
                .HasMaxLen(LastName, 40, "Name.LastName", "Sobrenome deve conter no máximo 40 catacteres")
                );
        }

        public string FirstName { get;private set; }
        public string LastName { get; private set; }
    }
}
