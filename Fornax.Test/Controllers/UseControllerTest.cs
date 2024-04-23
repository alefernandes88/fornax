using FluentAssertions;
using fornax.Controllers;
using fornax.Core.Entities;
using fornax.Usecase.UserCase.Query;
using Fornax.Test.MockData;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Fornax.Test.Controllers
{
    public class UseControllerTest
    {
        [Fact]
        public void getUserReturn200Status() 
        {
            var userGetQuery = new Mock<UserGetQuery>();
            userGetQuery.Setup(_ => _.getUser(It.IsAny<int>())).Returns(UserMockData.getUser()[0]);
            var controller = new UserController();

            var result = (OkObjectResult)controller.GetUser(1);

            result.StatusCode.Should().Be(200);

        }

        [Fact]
        public void getUserReturn400Status()
        {
            var userGetQuery = new Mock<UserGetQuery>();
            userGetQuery.Setup(_ => _.getUser(It.IsAny<int>())).Returns(new User());
            var controller = new UserController();

            var result = (NotFoundResult)controller.GetUser(1);

            result.StatusCode.Should().Be(400);
        }

        [Fact]
        public void getAllReturn200Status()
        {
            var userGetAllQuery = new Mock<UserGetAllQuery>();
            userGetAllQuery.Setup(x => x.getAll()).Returns(UserMockData.getUser());
            var controller = new UserController();

            var result = (OkObjectResult)controller.GetAll();

            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public void getAllReturn404Status()
        {
            var userGetAllQuery = new Mock<UserGetAllQuery>();
            userGetAllQuery.Setup(x => x.getAll()).Returns([]);
            var controller = new UserController();

            var result = (NotFoundResult)controller.GetAll();

            result.StatusCode.Should().Be(404);
        }
    }
}
