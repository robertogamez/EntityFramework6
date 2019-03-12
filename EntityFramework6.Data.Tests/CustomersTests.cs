using System;
using System.Linq;
using Data;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EntityFramework6.Data.Tests
{
    [TestClass]
    public class CustomersTests
    {
        [TestMethod]

        public void Customer_Is_Empty_Collection()
        {
            // Arrange
            Context context = new Context();

            // Act
            var customers = context.Customers.ToList();

            // Assert
            customers.Count.Should().Be(0);

        }
    }
}
