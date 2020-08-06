using Flunt.Validations;
using PaymentContext.Shared.ValueObjects;

namespace PaymentContext.Domain.ValueObjects
{
    public class Address : ValueObject
    {
        public Address(string street, string number, string neighborhood, string city, string state, string zipCode)
        {
            Street = street;
            Number = number;
            Neighborhood = neighborhood;
            City = city;
            State = state;
            ZipCode = zipCode;

            AddNotifications(
                new Contract()
                .Requires()
                .HasMinLen(Street, 3, "Address.Street", "A Rua deve conter pelo menos 3 caracteres")
                .HasMinLen(City, 3, "Address.City", "A Cidade deve conter pelo menos 3 caracteres")
                .HasMinLen(State, 3, "Address.State", "O Estado deve conter pelo menos 3 caracteres")
            );
        }

        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Neighborhood { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string ZipCode { get; private set; }
    }
}