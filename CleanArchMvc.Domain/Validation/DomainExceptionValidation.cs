using System;

namespace CleanArchMvc.Domain.Validation {

    // classe de validação de exceções de domínio
    public class DomainExceptionValidation : Exception{
        public DomainExceptionValidation(string error) : base(error) {

        }
        public static void When(bool hasError, string error) {
            if(hasError)
                throw new DomainExceptionValidation(error);
        }
    }
}