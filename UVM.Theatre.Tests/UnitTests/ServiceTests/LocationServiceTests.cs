using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using UVM.Theatre.Domain.Models;
using UVM.Theatre.Repositories;
using UVM.Theatre.Services;

namespace UVM.Theatre.Tests.UnitTests.ServiceTests
{
    internal class LocationServiceTests
    {
        private Mock<ILocationsRepository> _locationsRepositoryMock;

        private LocationsService _locationsService;

        [SetUp]
        public void SetupTest()
        {
            _locationsRepositoryMock = new Mock<ILocationsRepository>();
            _locationsService = new LocationsService(_locationsRepositoryMock.Object);
        }

        [Test]
        public void GetLocations_ReturnsLocations()
        {
            //arrange
            var locations = GetLocations();
            const int locationsCount = 2;
            _locationsRepositoryMock.Setup(r => r.GetLocations()).Returns(locations);

            //act
            var result = _locationsService.GetLocations();

            //assert
            Assert.IsInstanceOf<IEnumerable<Location>>(result);
            Assert.AreEqual(locationsCount, result.Count());
        }

        private IEnumerable<Location> GetLocations()
        {
            return new List<Location>
            {
                new Location
                {
                    LocationId = 1,
                    Title = "Royal Tyler Theatre",
                    ImageUrl = "http://nagel.w3.uvm.edu/theatre/imgs/miniIndex.png",
                    GoogleMap =
                        "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2846.842781987515!2d-73.20017288444936!3d44.4773952791016!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4cca7af821ccf30f%3A0x6241990581cd1c83!2sRoyall+Tyler+Theatre!5e0!3m2!1sen!2sus!4v1455080944332",
                    Description =
                        "orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                },
                new Location
                {
                    LocationId = 2,
                    Title = "Parking",
                    ImageUrl = "http://nagel.w3.uvm.edu/theatre/imgs/miniIndex.png",
                    GoogleMap =
                        "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d488.92096269882876!2d-73.20239032881418!3d44.47832539849981!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4cca7a5beeaf827f%3A0x7ffeed5fea2eed3b!2sWaterman+Bldg%2C+85+S+Prospect+St%2C+Burlington%2C+VT+05401!5e0!3m2!1sen!2sus!4v1460957780688",
                    Description =
                        "orem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."
                }
            };
        }
    }
}
