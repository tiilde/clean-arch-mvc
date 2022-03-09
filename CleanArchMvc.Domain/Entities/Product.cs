using CleanArchMvc.Domain.Validation;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Product : EntityBase {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Image { get; private set; }

        public Product(string name, string description, decimal price, int stock, string image) {
            ValidateDomain(name, description, price, stock, image);
        }

        public Product(int id, string name, string description, decimal price, int stock, string image) {
            DomainExceptionValidation.When(id < 0, "Invalid Id value.");
            Id = id;
            ValidateDomain(name, description, price, stock, image);
        }

        public void Update(string name, string description, decimal price, int stock, string image, int categoryId) {
            ValidateDomain(name, description, price, stock, image);
            CategoryId = categoryId;
        }

        private void ValidateDomain(string name, string description, decimal price, int stock, string image) {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name),
                "Invalid name. Name is required");

            DomainExceptionValidation.When(name.Length < 3,
                "Invalid name, too short, minimum 3 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description),
                "Invalid description. Description is required");

            DomainExceptionValidation.When(description.Length < 5,
                "Invalid description, too short, minimum 5 characters");

            DomainExceptionValidation.When(price < 0, "Invalid price value.The price must be greater than zero");

            DomainExceptionValidation.When(stock < 0, "Invalid stock value.The stock must be greater than zero");

            // avaliando o valor de image, se for null, o valor ser� null
            //se o valor de image n�o for null, a express�o image?.Length > 250 ser� avaliada
            DomainExceptionValidation.When(image?.Length > 250,
                "Invalid image name, too long, maximum 250 characters");

            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;


        }

        public int CategoryId { get; set; } // propriedade chave estrangeira
        public Category Category { get; set; } // propriedade que relaciona o produto do tipo category
    }
}