using System;

namespace AnimalShelter.Code
{
    public class Response
    {
        public Animal Animal { get; }
        public bool Status { get; private set; }
        public string ErrorMessage { get; private set; }

        public Response(Animal animal, bool status, string errorMessage)
        {
            Animal = animal;
            Status = status;
            ErrorMessage = errorMessage;
        }

        public Response(string errorMessage) : this(null, false, errorMessage)
        {
        }

    }
}


