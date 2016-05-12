CREATE DATABASE  IF NOT EXISTS `theatre` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `theatre`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win32 (AMD64)
--
-- Host: localhost    Database: theatre
-- ------------------------------------------------------
-- Server version	5.7.12-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `show`
--

DROP TABLE IF EXISTS `show`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `show` (
  `showId` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(255) NOT NULL,
  `subTitle` varchar(255) NOT NULL,
  `director` varchar(255) NOT NULL,
  `showDate` varchar(255) NOT NULL,
  `description` varchar(10000) NOT NULL,
  `imageUrl` varchar(255) NOT NULL,
  `archive` int(1) NOT NULL,
  PRIMARY KEY (`showId`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `show`
--

LOCK TABLES `show` WRITE;
/*!40000 ALTER TABLE `show` DISABLE KEYS */;
INSERT INTO `show` VALUES (1,'Royal Tyler The 39 Steps','Adapted by Patrick Barlow','Cristina Alicea','October 1-3 & 8-10 @ 7:30 PM October 3 & 11 @ 2PM','Based on a classic novel and a hit film by Alfred Hitchcock The 39 Steps is a suspenseful romantic comedy that features 4 actors portraying over 100 characters. Winner of 2 Tony and Drama Desk Awards this delightful screwball comedy is part spy mystery and part Monty Python. You wonÃ­t be able to catch your breath as the mild mannered protagonist navigates his way through a maze of murder and espionage entanglements and death defying spectacles. The 39 Steps is a love letter to the magic of theatre!','http://www.uvmtheatre.org/images/UVM_Poster_39Steps_150824final.jpg',0),(2,'Marat/Sade','By Peter Weiss','Gregory Ramos','November 5-7 & 12-14 @ 7:30PM November 7 & 15 @ 2PM','The evocative and extraordinary play Marat/Sade is an exploration of class, madness, sexuality, violence and revolution (just to name a few.) The play tells the story of a group of inmates in post-revolutionary France who perform a narrative of the revolutionÃ³filled with grizzly violence and biting truth. Through the lens of theatre, and both its transformative and destructive powers, this gripping story unfolds. Both poignant and heartfelt Marat/Sade is experimental, entertaining and totally immersive theatre.','http://www.uvmtheatre.org/images/UVM_Poster_MaratSade_150821a.jpg',0),(3,'THE TOYS TAKE OVER CHRISTMAS','by Patricia Clapp','Celebrating 25 Years at the Royall Tyler!','December 5 & 6, 2015 - Performances at 10AM, 2PM & 6PM','The Toys Take Over Christmas by Patricia Clapp is a Vermont holiday tradition celebrating 24 years at the Royall Tyler. A magical performance for adults and children alike and, after the show your kids will have the chance to meet the toys and toymaker along with a very special visitor from the North Pole! Tickets go FAST, so purchase early! The seasonal favorite follows the adventures of Sunny, a cheerful, inquisitive rag doll brought to life by the Toymaker, whose toyshop is filled with living toys. The selfish Toymaker refuses to sell or give the toys away, preferring to keep his creations to himself. Then Sunny makes an astonishing discovery that divides the loyalties of her newfound friends and jeopardizes the Toymaker\'s claim to be the \\\"Greatest Toymaker in the World!\\\" A Toy drive to benefit Toys For Kids of VT will be happening at the Royall Tyler Theatre during performances on Saturday December 5th and Sunday, December 6th. Please bring a new unwrapped toy to the box office in the lobby at the Royall Tyler. A red barrel will be in the lobby provided by the Marine Corps League. Thank you for helping us to support a worthy local cause!','http://www.uvmtheatre.org/images/UVM_TOYSPOSTER.png',0),(4,'Noises Off','By Micheal Frayn','Sarah Carleton','February 24 & 28 @ 7:30PM February 27 & 28 @ 2PM','Full of surprises and laugh out loud humor Noises Off is the classic show-within-a-show tale. The Opening Night performance of the farceâ€ Nothing Onâ€ is just hours away, and as the cast stumbles through their final dress rehearsal, things couldn\'t be going any worse.â€ With lines being forgotten, love triangles unraveling and sardines flying everywhere, itÃ­s complete pandemoniumÃ–and we havenÃ­t even reached intermission! Can the cast pull their act together on the stage even if they can\'t behind the scenes?','http://www.uvmtheatre.org/images/UVM_Poster_NoisesOff_150821a.jpg',0),(5,'A Grand Night for Singing','Music by Richard Rodgers Lyrics by Oscar Hammerstein II','Craig Wells','2014/2015 ','Taste and imagination abound in this fresh take on the Rodgers and Hammerstein canon. Nominated for two Tony Awards (including Best Musical) A Grand Night for Singing features memorable songs from such shows as State Fair, Carousel, Oklahoma, The King and I and The Sound of Music. With innovative arrangements A Grand Night for Singing leaves no question about how terrifically up to date the remarkable songs of Rodgers and Hammerstein are','AGrandNightforSinging.jpg',1),(6,'Our Town','By Thornton Wilder','Sarah Carleton','2014/2015 ','The tiny town of Grover’s Corners comes to life on the Royall Tyler stage in Thornton Wilder’s Pulitzer Prize winning masterpiece Our Town. George Gibbs and Emily Webb fall in love, marry and live out their lives as one New England town becomes a microcosm of everyday life. Our Town uniquely captures the universal experience of being alive, by showing us that life is both precious and ordinary, and that these two fundamental truths are ultimately connected.','OurTown.jpg',1),(7,'Much Ado About Nothing','By William Shakespeare	','Mark Alan Gordon','2014/2015 ','Honor and desire collide as laughter and love unfold in Shakespeare’s spirited comedy. This tale of the sparring lovers Beatrice and Benedick offers a humorous, dark and, at times, hilariously absurd view of the intricate game that is love. Passionate, sexy and funny Much Ado About Nothing will make you laugh, break your heart – and then magically put it back together again. Reveling in joy and wallowing in despair the bard’s timeless tale will resonate with anyone who has been betrayed, deceived, maligned or in love!','MuchAdoAboutNothing.jpg',1),(8,'The Moustrap','By Agatha Christie','Sarah Carleton','2013/2014 ','Five guests arrive at a rural hotel in England and are soon completely snowed in. A policeman arrives to warn the guests there’s a murderer on the run in the area and everyone is in danger. Who is the killer? Mysterious twists, spellbinding turns, and a clever plot by one of the greatest mystery writers of all time. Fun and sophisticated,','Mousetrap.jpg',1),(9,'Little Women','Adapted by Marisha Chamberlain','Peter Jack Tkatch','2013/2014 ','The March sisters: Jo, Meg, Beth, and Amy learn the importance of friendship and family strength against the backdrop of The American Civil War in the inspired stage adaptation of Louisa May Alcott’s classic coming of age novel. This heartwarming tale of loyalty and love is told with humor, grace, and theatricality.','LittleWomen.jpg',1),(10,'Urinetown','Music and Lyrics by Mark Hollmann	Book and Lyrics by Greg Kotis','Gregory Ramos','2013/2014 ','Urinetown is an earnest tale of love, greed, and revolution! Set in a town plagued by a 20-year drought, where water has become so scarce that private toilets have become unthinkable, a hero rises to lead his fellow citizens against a tyrannical regime. Drawing from West Side Story, Chicago, and Les Misérables, and others, the show irreverently pays witty homage to the great American musical theatre tradition. Hilariously funny and touchingly honest, Urinetown sets the standard for today’s great American musical.','Urinetown.jpg',1),(11,'How I Learned to Drive ','By Paula Vogel','Gregory Ramos','2012/2013','Fasten your seat belts for this funny, harrowing and provocative play that traces a woman\'s path from adolescence to adulthood, a journey shaped by the charged relationship between Li\'l Bit and her Uncle Peck. Using the metaphor of the driving lesson, this memory play unfolds in a series of sharply drawn vignettes, each filled with equal parts anger, gratitude, pain and nostalgia. With both humor and affection Paula Vogel\'s Pulitzer Prize winning play asks us to consider the legacies left to us by our families and our abilities to overcome traumas of the past.','HowILearnedtoDrive.jpg',1),(12,'The Arabian Nights','By Mary Zimmerman','Sarah Carleton','2012/2013','Experience the power of storytelling in Tony award winner Mary Zimmerman\'s brilliant adaptation of one of literature\'s greatest masterpieces, \"One Thousand and One Nights\". The play weaves an imaginative and entertaining tapestry of sight and sound that celebrate theatre\'s ritualistic and narrative ancestry. The young heroine Scheherazade frantically tells stories in order to save her life from the brutal, embittered and ruthless King Shahryar. Will her wiles change the bitterness of the King\'s heart and lead her to freedom or will she meet the same end of all that have come before?','TheArabianNights.jpg',1),(13,'The Heidi Chronicles','By Wendy Wasserstein','JEFF MODEREGER','2012/2013','An enlightening tribute to the generation of women who battled against tradition to have it all -- motherhood and sisterhood, as well as respect at home and at work -- this award winning play explores the ways in which women search for the meaning of success. Written with grace and wit by Wendy Wasserstein, The Heidi Chronicles offers a moving portrait of a time when American women experienced intense and sometimes troubling change. Discover the Pultizer Prize winning play that confirms Wasserstein as some of the most enduring voices in American Theatre.','TheHeidiChronicles.jpg',1);
/*!40000 ALTER TABLE `show` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-12 13:44:37
