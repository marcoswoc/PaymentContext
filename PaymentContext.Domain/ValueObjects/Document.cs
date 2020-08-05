using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.ValueObjects
{
    public class Document
    {
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }
        public string Number { get; set; }   
        public EDocumentType Type { get; set; }    
    }
}