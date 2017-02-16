using Xunit;
using FlickrClone.Models;

namespace Tests.ControllerTests
{
    public class PhotoTest
    {
        public void GetTitleTest()
        {
            var photo = new Photo("Name", "Description", null , "9d55808f-f5b8-4495-88eb-1ad0073bd20e");
            var result = photo.PhotoName;
            Assert.Equal(result, "Name");
        }
    }
}
