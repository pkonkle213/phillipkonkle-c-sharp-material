using System;
namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            
            int totalRaccoons = 3;
            int leavingRaccoons = 2;
            int raccoonsLeft = totalRaccoons - leavingRaccoons;

            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */

            int totalBees = 3;
            int totalFlowers = 5;
            int differenceFlowersBees = totalFlowers - totalBees;

            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */

            int breadcrumbPigeon = 1;
            int hungryPigeon = 1;
            int totalPigeons = breadcrumbPigeon + hungryPigeon;


            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */

            int initialOwls = 3;
            int friendlyOwls = 2;
            int totalOwls = initialOwls + friendlyOwls;

            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */

            int initialBeavers = 2;
            int slackerBeavers = 1;
            int totalBeavers = initialBeavers - slackerBeavers;

            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */

            int initialToucans = 2;
            int toucanSam = 1;
            int totalToucans = initialToucans + toucanSam;

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */

            int totalSquirrels = 4;
            int totalNuts = 2;
            int differenceSquirrelsNuts = totalSquirrels - totalNuts;

            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */

            decimal quarter = .25M;
            decimal dime = .1M;
            decimal nickel = .05M;
            int numNickel = 2;

            decimal totalMoney = quarter + dime + nickel * numNickel;

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */

            int muffinsBrier = 18;
            int muffinsMacAdams = 20;
            int muffinsFlannery = 17;
            int totalMuffins = muffinsBrier + muffinsFlannery + muffinsMacAdams;

            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */

            decimal priceYoyo = .24M;
            decimal priceWhistle = .14M;
            decimal totalBill = priceYoyo + priceWhistle;

            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */

            int largeMarshmallows = 8;
            int miniMarshmallows = 10;

            int marshmallowsPerTreat = largeMarshmallows + miniMarshmallows; 
            
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */

            int inchesHiltHouse = 29;
            int inchesSchool = 17;
            int differenceHiltSchool = inchesHiltHouse - inchesSchool;

            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */

            decimal totalMoneyTruckPencil = 10M;
            decimal priceTruck = 3M;
            decimal pricePencilCase = 2M;

            decimal finalPriceTruckPencil = totalMoneyTruckPencil - priceTruck - pricePencilCase;

            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */

            int totalMarbles = 16;
            int lostMarbles = 7; // Thankfully it's not all of them

            int leftMarbles = totalMarbles - lostMarbles;

            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */

            int initialSeashells = 19;
            int totalSeashells = 25;

            int findSeashells = totalSeashells - initialSeashells;

            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */

            int totalBalloons = 17;
            int totalBalloonsRed = 8; // Though the song goes 99 red balloons...

            int totalBalloonsGreen = totalBalloons - totalBalloonsRed;

            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */

            int initialBooks = 38;
            int booksMarta = 10;

            int totalBooks = initialBooks + booksMarta;

            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */

            int legsPerBee = 6;
            int numBees = 8;

            int totalLegs = legsPerBee * numBees;

            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */

            decimal priceIceCreamCone = .99M;
            int numbIceCreamCones = 2;

            decimal totalPriceCones = priceIceCreamCone * numbIceCreamCones;

            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */

            int totalRocks = 125;
            int haveRocks = 64;

            int needRocks = totalRocks - haveRocks;

            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */

            int totalHiltMarbles = 38;
            int lostHiltMarbles = 15;
            int leftHiltMarbles = totalHiltMarbles - lostHiltMarbles;

            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */

            int lengthMilesConcert = 78;
            int lengthMilesTraveled = 32;

            int lengthMilesToGo = lengthMilesConcert - lengthMilesTraveled;

            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */

            int hourToMin = 60;
            int timeHourMorning = 1;
            int timeMinMorning = 30;
            int timeMinAfternoon = 45;

            int totalTimeShoveling = timeHourMorning * hourToMin + timeMinMorning + timeMinAfternoon;

            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */

            decimal costHotDog = .5M;
            decimal numHotDog = 6.0M;
            decimal totalCostHotDog = costHotDog * numHotDog;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */

            int totalMoneyHilt = 50;
            int costPencil = 7;
            int numPencilBought = totalMoneyHilt / costPencil;

            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */

            int totalButterflies = 33;
            int orangeButterflies = 20;
            int redButterflies = totalButterflies - orangeButterflies;

            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */

            decimal moneyKate = 1.0M;
            decimal costCandy = .54M;
            decimal change = moneyKate - costCandy;

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */

            int initialTrees = 13;
            int treesToPlant = 12;
            int totalTrees = initialTrees + treesToPlant; // Not as many as Mark Rober

            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */

            int numDays = 2;
            int hoursInDays = 24;
            int totalTime = numDays * hoursInDays;

            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */

            int numCousins = 4;
            int giftGum = 5;
            int totalAmountGum = numCousins * giftGum;

            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */

            decimal doughDan = 3.00M;
            decimal doughCandyBar = 1.00M;
            decimal doughLeft = doughDan - doughCandyBar;
            
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */

            int totalBoats = 5;
            int peoplePerBoat = 3;
            int totalPeople = totalBoats * peoplePerBoat;

            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */

            int totalLegos = 380;
            int lostLegos = 57; // And they're all on the floor

            int leftLegos = totalLegos - lostLegos;

            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */

            int muffinsDone = 35;
            int muffinsNeeded = 83;

            int muffinsToBake = muffinsNeeded - muffinsDone;

            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */

            int willyCrayons = 1400;
            int lucyCrayons = 290;

            int differenceCrayons = willyCrayons - lucyCrayons;

            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */

            int stickersPerPage = 10;
            int numPages = 22;

            int totalStickers = stickersPerPage * numPages;

            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */

            double totalCupcakes = 96;
            double numChildren = 8;

            double evenSplitCupcakes = totalCupcakes / numChildren;

            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */

            int totalCookies = 47;
            int evenSplitCookies = 6;

            int cookiesLeftOver = totalCookies % evenSplitCookies;

            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */

            int totalCroissants = 59;
            int numNeighbors = 8;

            int leftoverCroissants = totalCroissants % numNeighbors;

            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */

            int totalMarianCookies = 276;
            int cookiesPerTray = 12;

            int totalTrays = totalMarianCookies / cookiesPerTray;

            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */

            int servingSize = 12;
            int totalPretzles = 480;

            int numServings = totalPretzles / servingSize;

            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */

            int numCupcakes = 53;
            int leftCupcakes = 2;
            int numPerBox = 3;

            int cupcakesGiven = numCupcakes - leftCupcakes;
            int numBox = cupcakesGiven / numPerBox;

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */

            int numCarrots = 74;
            int numPeople = 12;

            int leftoverCarrots = numCarrots % numPeople;

            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */

            int totalBears = 98;
            int bearPerShelf = 7;

            int totalShelves = totalBears / bearPerShelf;

            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */

            int totalPictures = 480;
            int picsPerAlbum = 20;

            int totalAlbum = totalPictures / picsPerAlbum;

            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */

            int totalCards = 94;
            int cardsPerBox = 8;

            int fullBoxes = totalCards / cardsPerBox;   // Full boxes
            int leftoverCards = totalCards % cardsPerBox; // Cards in the unfilled box

            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */

            int totalBooksSusie = 210;
            int totalShelvesSusie = 10;

            int booksPerShelf = totalBooksSusie / totalShelvesSusie;

            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */

            double totalCroissantsCristina = 17.0;
            double guestsChristina = 7.0;

            double guestsEvenlyServed = totalCroissantsCristina / guestsChristina;
       
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */

            int roomHeight = 12;
            int roomWidth = 14;
            int roomArea = roomHeight * roomWidth;

            double timeBill = 2.15;
            double timeJill = 1.90; // Slacker

            double rateBill = roomArea / timeBill;
            double rateJill = roomArea / timeJill;
            double totalRate = rateBill + rateJill;

            int totalRooms = 5;
            int totalArea = totalRooms * roomArea;
            double howLongForAll = totalArea / totalRate;

            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */

            string lastName = "Hopper";
            string firstName = "Grace";
            string middleInitial = "B";

            string fullName = lastName + ", " + firstName + " " + middleInitial + ".";

            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */

            int distanceTotal = 800;
            int distanceTraveled = 537;

            int percentageTraveled = (distanceTraveled * 100) / distanceTotal;
            
        }
    }
}
