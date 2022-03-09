using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests {
    public class CategoryUnitTest1 {
        [Fact(DisplayName = "Create Category With Valid State")]

        public void CreateCategory_WithValidParameters_ResultObjectValidState() {

            Action action = () => new Category(1, "Category Name");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();

        }

        [Fact]
        public void CreateCategory_NegativeIdValue_DomainExceptionInvalidId() {

            Action action = () => new Category(-1, "Category Name");
            action.Should().Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value.");

        }

        [Fact]
        public void CreateCategory_ShortNameValue_DomainExcpetionShortName() {

            Action action = () => new Category(1, "Ca");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                    .WithMessage("The name must have at least 3 characters");
        }

        [Fact]
        public void CreateCategory_MissingNameValue_DomainExcpetionRequiredName() {

            Action action = () => new Category(1, "");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name.Name is required");
        }

        [Fact]
        public void CreateCategory_WithNullNameValue_DomainExceptionInvalidName() {
            Action action = () => new Category(1, null);
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }


    }
}
