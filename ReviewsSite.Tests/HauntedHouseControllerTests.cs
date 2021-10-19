using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using ReviewsSite.Controllers;
using ReviewsSite.Models;
using ReviewsSite.Repositories;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;

namespace ReviewsSite.Tests
{
    public class HauntedHouseControllerTests
    {
        HauntedHouseController sut;
        IRepository<HauntedHouse> HauntedHouseRepo;

        public HauntedHouseControllerTests()
        {
            HauntedHouseRepo = Substitute.For<IRepository<HauntedHouse>>();
            sut = new HauntedHouseController(HauntedHouseRepo);

        }
        [Fact] //passes
        public void Index_Returns_A_View()
        {
            //Arrange

            //Act
            var Result = sut.Index();


            //Assert
            Assert.IsType<ViewResult>(Result);
        }

        [Fact] //passes
        public void Edit_Displays_HauntedHouse_to_Edit()
        {
            //Arrange
            var HauntedHouse = new HauntedHouse(1, "test house");

            //Act
            var Result = sut.EditHauntedHouse(HauntedHouse.Id);


            //Assert
            Assert.IsType<RedirectToActionResult>(Result);

        }
    }


}
