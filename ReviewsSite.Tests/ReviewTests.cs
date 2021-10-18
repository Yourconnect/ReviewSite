using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewsSite.Models;
using Xunit;

namespace ReviewsSite.Tests
{
    public class ReviewTests
    {
        Review sut;

        [Fact] //passes
        public void Review_Id_Sets_Id_On_Review()
        {

            //Arrange

            //Act
            sut = new Review();
            sut.Id = 3;

            //Assert
            Assert.Equal("3", sut.Id.ToString());
        }

        [Fact] //passes
        public void Review_Author_Sets_Author_On_Review()
        {
            //Arrange

            //Act
            sut = new Review();
            sut.Author = "Freddy Krueger";

            //Assert
            Assert.Equal("Freddy Krueger", sut.Author);
        }
    }
}
