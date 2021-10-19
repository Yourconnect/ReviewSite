using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReviewsSite.Models;
using Xunit;


namespace ReviewsSite.Tests
{
    public class HauntedHouseTests
    {
        HauntedHouse sut;

        [Fact] //passes
        public void HauntedHouse_Id_Sets_Id_On_HauntedHouse()
        {
            //Arrange

            //Act
            sut = new HauntedHouse();
            sut.Id = 12;

            //Assert
            Assert.Equal("12", sut.Id.ToString());
        }
        [Fact] //passes
        public void HauntedHouse_Name_Sets_Name_On_HauntedHouse()
        {
            //Arrange

            //Act
            sut = new HauntedHouse();
            sut.Name = "Mansfield Reformatory";

            //Assert
            Assert.Equal("Mansfield Reformatory", sut.Name);

        }

        
        
    }
}
