using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FlickrClone.Controllers;
using FlickrClone.Models;
using Xunit;

namespace Tests.ControllerTests
{
    public class PhotosControllerTest
    {
        [Fact]
        public void GetModel_List_Index_Test()
        {
            HomeController controller = new HomeController();
            IActionResult actionResult = controller.Index();
            ViewResult indexView = controller.Index() as ViewResult;

            var result = indexView.ViewData.Model;

            Assert.IsType<List<Photo>>(result);
         }

        [Fact]
        public void Account_Index_Test()
        {
            HomeController controller = new HomeController();

            var result = controller.Create(null, "Name", "Description", "9d55808f-f5b8-4495-88eb-1ad0073bd20e");

            Assert.IsType<RedirectToActionResult>(result);
        }

    }
}
