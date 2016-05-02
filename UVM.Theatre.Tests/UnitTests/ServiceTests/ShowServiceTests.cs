﻿using System.Collections.Generic;
using System.Linq;
using Moq;
using NUnit.Framework;
using UVM.Theatre.Domain.Models;
using UVM.Theatre.Repositories;
using UVM.Theatre.Services;

namespace UVM.Theatre.Tests.UnitTests.ServiceTests
{
    internal class ShowServiceTests
    {
        private Mock<IShowRepository> _showRepositoryMock;

        private ShowService _showService;

        [SetUp]
        public void SetupTest()
        {
            _showRepositoryMock = new Mock<IShowRepository>();
            _showService = new ShowService(_showRepositoryMock.Object);
        }

        [Test]
        public void GetShows_ReturnShows()
        {
            //assert
            var shows = GetShows();
            const int showsCount = 4;
            _showRepositoryMock.Setup(r => r.GetCurrentShows()).Returns(shows);

            //act
            var result = _showService.GetAllActiveShows();

            //assert
            Assert.IsInstanceOf<IEnumerable<Show>>(result);
            Assert.AreEqual(showsCount, result.Count());
        }

        private IEnumerable<Show> GetShows()
        {
            return new List<Show>
            {
              new Show
              {
                ShowId = 1,
                Title = "The 39 Steps",
                SubTitle = "Adapted by Patrick Barlow",
                Director = "Cristina Alicea",
                ShowDates = "October 1-3 & 8-10 @ 7:30 PM October 3 & 11 @ 2PM",
                Description = "Based on a classic novel and a hit film by Alfred Hitchcock The 39 Steps is a suspenseful romantic comedy that features 4 actors portraying over 100 characters. Winner of 2 Tony and Drama Desk Awards this delightful screwball comedy is part spy mystery and part Monty Python. You wonÃ­t be able to catch your breath as the mild mannered protagonist navigates his way through a maze of murder and espionage entanglements and death defying spectacles. The 39 Steps is a love letter to the magic of theatre!",
                Image = "http://www.uvmtheatre.org/images/UVM_Poster_39Steps_150824final.jpg"
              },
              new Show
              {
                ShowId = 2,
                Title = "Marat/Sade",
                SubTitle = "By Peter Weiss",
                Director = "Gregory Ramos",
                ShowDates = "November 5-7 & 12-14 @ 7:30PM November 7 & 15 @ 2PM",
                Description = "The evocative and extraordinary play Marat/Sade is an exploration of class, madness, sexuality, violence and revolution (just to name a few.) The play tells the story of a group of inmates in post-revolutionary France who perform a narrative of the revolutionÃ³filled with grizzly violence and biting truth. Through the lens of theatre, and both its transformative and destructive powers, this gripping story unfolds. Both poignant and heartfelt Marat/Sade is experimental, entertaining and totally immersive theatre.",
                Image = "http://www.uvmtheatre.org/images/UVM_Poster_MaratSade_150821a.jpg"
              },
              new Show
              {
                ShowId = 3,
                Title = "THE TOYS TAKE OVER CHRISTMAS",
                SubTitle = "by Patricia Clapp",
                Director = "Celebrating 25 Years at the Royall Tyler!",
                ShowDates = "December 5 & 6, 2015 - Performances at 10AM, 2PM & 6PM",
                Description = "The Toys Take Over Christmas by Patricia Clapp is a Vermont holiday tradition celebrating 24 years at the Royall Tyler. A magical performance for adults and children alike and, after the show your kids will have the chance to meet the toys and toymaker along with a very special visitor from the North Pole! Tickets go FAST, so purchase early! The seasonal favorite follows the adventures of Sunny, a cheerful, inquisitive rag doll brought to life by the Toymaker, whose toyshop is filled with living toys. The selfish Toymaker refuses to sell or give the toys away, preferring to keep his creations to himself. Then Sunny makes an astonishing discovery that divides the loyalties of her newfound friends and jeopardizes the Toymaker's claim to be the \"Greatest Toymaker in the World!\" A Toy drive to benefit Toys For Kids of VT will be happening at the Royall Tyler Theatre during performances on Saturday December 5th and Sunday, December 6th. Please bring a new unwrapped toy to the box office in the lobby at the Royall Tyler. A red barrel will be in the lobby provided by the Marine Corps League. Thank you for helping us to support a worthy local cause!",
                Image = "http://www.uvmtheatre.org/images/UVM_TOYSPOSTER.png"
              },
              new Show
              {
                ShowId = 4,
                Title = "Noises Off",
                SubTitle = "By Micheal Frayn",
                Director = "Sarah Carleton",
                ShowDates = "February 24 Ã± 28 @ 7:30PM February 27 & 28 @ 2PM",
                Description = "Full of surprises and laugh out loud humor Noises Off is the classic show-within-a-show tale. The Opening Night performance of the farceâ€ Nothing Onâ€ is just hours away, and as the cast stumbles through their final dress rehearsal, things couldn't be going any worse.â€ With lines being forgotten, love triangles unraveling and sardines flying everywhere, itÃ­s complete pandemoniumÃ–and we havenÃ­t even reached intermission! Can the cast pull their act together on the stage even if they can't behind the scenes?",
                Image = "http://www.uvmtheatre.org/images/UVM_Poster_NoisesOff_150821a.jpg"
              }
            };
        }
    }
}
