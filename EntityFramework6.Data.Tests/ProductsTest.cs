using Data;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework6.Data.Tests
{
    [TestClass]
    public class ProductsTest
    {
        [TestMethod]
        public void Products_Is_Empty_Collection()
        {
            // Arrange
            Context context = new Context();

            // Act
            var customers = context.Products.ToList();

            // Assert
            customers.Count.Should().Be(0);

        }
    }
}
