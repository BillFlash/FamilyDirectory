using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;
using data;
using data.models;

namespace FamilyDirectory.web
{
    public static class Seeder
    {
            public static void Seed(ApplicationDbContext context, bool createPerson = true, bool createFamily = true)
            {
                if(createFamily)
                {
                    CreateFamily(context);
                }
                if(createPerson) 
                {
                    CreatePerson(context);
                }
            }
        private static void CreatePerson(ApplicationDbContext context)
        {
            context.People.AddOrUpdate(p => p.FirstName,
                new Person { FirstName = "John Jacob",              LastName = "Bender",    Birthday = "August 17, 1954",    Picture = "https://scontent-b-sjc.xx.fbcdn.net/hphotos-xpa1/t1.0-9/58143_1438811127037_1217511_n.jpg",          Bio = "John Jacob Bender Jr was the first of nine children and first of 5 boys to Alice Rafferty Bender and John Jacob Bender. John who is better known as Jack has been married to Laurie for a long time and has 3 kids and 3 grandchildren of his own.  Jack is a great dad to his children and is the only Bender besides his dad to retire in which he spent 22 years in the service protecting our country.  Jack's last held job was working as a CFO for Hazlett Homes Inc. and is currently retired spending most of his time hanging out with his family and spending time in the great outdoors with his friends hunting, fishing and relaxing." },
                new Person { FirstName = "Samuel Martin",           LastName = "Bender",    Birthday = "April 9th, 1987",    Picture = "https://scontent-a-sjc.xx.fbcdn.net/hphotos-xap1/t1.0-9/1380641_10100171015146512_1700133377_n.jpg", Bio = "Samuel Martin Bender is the son of Jack and Laurie Bender, the twin of Alexander Robert Bender and the brother of Kristine Bender Mahoney.  Sam is currently working as a Software Engineer and enjoys surfing, programming, spending time with his wife Nicole, son Samuel, playing lacrosse and reading.  Sam is an active member of the society and often spends time coaching youth league players in lacrosse." },
                new Person { FirstName = "Alexander Robert",        LastName = "Bender",    Birthday = "April 9th 1987",     Picture = "https://fbcdn-sphotos-c-a.akamaihd.net/hphotos-ak-xpa1/t1.0-9/10399541_1098160769971_3721_n.jpg",    Bio = "Alex enjoys music, drawing and rollerblading.  Alex was an outstanding wrestler while in highshool and always had a penchant for pinning his opponent in a shortest amount of time.  Alex has a new found ardor for staying out of trouble and following the rules." },
                new Person { FirstName = "Kritine (Emilia) Bender", LastName = "Mahoney",   Birthday = "August 7, 1982",     Picture = "https://scontent-b-sjc.xx.fbcdn.net/hphotos-xaf1/t1.0-9/4573_915091726749_547199_n.jpg",             Bio = "Kristine is married to James Mahoney, has 2 kids, a Bachelors and Masters in Education from the University of North Carolina Charlotte, loves music, yoga and fun." },
                new Person { FirstName = "Laurie Robin",            LastName = "Bender",    Birthday = "June 25th, 1957",    Picture = "https://scontent-a-sjc.xx.fbcdn.net/hphotos-xaf1/t1.0-9/26810_100502293327531_5469351_n.jpg",        Bio = "Laurie Robin Bender is mother to three children, Kristine, Alex and Sam. She is a Bubbie to Samuel Jacob, Sara Anne and Kayla.  Laurie was born in Buffalo, NY, loves music, the great outdoors, is a wine connoisseur and a great cook.  When Laurie is not working she likes to spend time with her family, relax at the beach or lie in her hammock while reading a book." },
                new Person { FirstName = "Samuel Jacob",            LastName = "Bender",    Birthday = "September 7th, 2012",Picture = "https://scontent-b-sjc.xx.fbcdn.net/hphotos-xpa1/t1.0-9/1382867_10153314072750201_1309677349_n.jpg", Bio = "Samuel Jacob Bender is the son of Mr. and Mrs. Samuel Martin Bender, loves to play with his cars, his trucks, his letters, loves to read and play sports.  Samuel is a very good eater and hasn’t found something he doesn’t like.  Samuel is currently above average in height, weight, intellect and love." },
                new Person { FirstName = "Nora",                    LastName = "Bender",    Birthday = "IDK",                Picture = "https://fbcdn-sphotos-c-a.akamaihd.net/hphotos-ak-xfa1/t1.0-9/1893_1074744384576_5673_n.jpg",        Bio = "Aunt Nora has 8 brothers and sisters and several nieces and nephews.  Aunt Nora is a Physical Education teacher is the third best athlete in the family (behind Sam Bender and her younger sister Aunt Susie).  Aunt Nora is all about having a good time is very optimistic and loves to play golf much like her brother Uncle Jimmy." },
                new Person { FirstName = "James(Jimmy)",            LastName = "Bender",    Birthday = "IDK",                Picture = "https://scontent-b-iad.xx.fbcdn.net/hphotos-xap1/l/t1.0-9/1918012_551280777182_4303741_n.jpg",       Bio = "Jim Bender is a salesman by trade, dilettante singer and a proponent of cranberry vodkas.  Uncle Jim is an exceptional golfer in which he was Division 1 athlete while at UB and is always looking to stir the pot which allows for constant fun or turmoil depending on your POV.  Uncle Jim has several original catch phrases which includes but is not limited to: IIIIII am a mannnn of constant sorrow, COFFEE CAKE!!!!, how many, how many, how many is that?,  JESUS CHRIST, Make me a drink chink, etc." },
                new Person { FirstName = "Susie Bender",            LastName = "Szymendera",Birthday = "??",                 Picture = "https://fbcdn-sphotos-h-a.akamaihd.net/hphotos-ak-xpa1/t1.0-9/1914263_1144874818946_2346518_n.jpg",  Bio = "Aunt Sue is currently on the only family member in the hall of fame but is in the hall of shame when she plays me in battleship.  Aunt Sue has 3 kids, Allie, Ryan, and Sean. Aunt Sue is married to my Uncle Paul who is decent at best when it comes to battleship.  Aunt Sue is the youngest child of Alice and John Bender Sr." },
                new Person { FirstName = "Alice Rafferty",          LastName = "Bender",    Birthday = "December 31st??",    Picture = "https://fbcdn-sphotos-d-a.akamaihd.net/hphotos-ak-xfa1/t31.0-8/219803_10200809033523898_213697232_o.jpg", Bio = "Grams is a Saint and model of longevity. She preaches doing the right thing and treating others with kindness. Alice has 9 children, several grandchildren and 8 great grand children" },
                new Person { FirstName = "John J",                  LastName = "Bender",    Birthday = "August 25th???",     Picture = "https://fbcdn-sphotos-e-a.akamaihd.net/hphotos-ak-xaf1/t1.0-9/263949_1795805491806_7918182_n.jpg",   Bio = "John Jacob Bender Sr AKA Grandpa was a very intellegent man in which he graduated from an Ivy league University.  Grandpa was very funny, could do crossword puzzles using a pen and was frat brothers with Theo Lesig AKS Dr. Seuss" },
                new Person { FirstName = "Thomas Edwin",            LastName = "Bender",    Birthday = "IDK",                Picture = "https://scontent-b-iad.xx.fbcdn.net/hphotos-xpa1/t1.0-9/40929_1544436486585_5411299_n.jpg",          Bio = "Uncle Tom was an avid sports watcher, enjoyed watching cheers and gilligans island with me a kid.  Uncle Tom liked to play card games and his favorite basketball player was Bob McAdoo of the Buffalo Braves" },
                new Person { FirstName = "Katherine Bender",        LastName = "Hazlett",   Birthday = "IDK",                Picture = "https://scontent-a-iad.xx.fbcdn.net/hphotos-xfp1/t1.0-9/47105_1544436166577_5771061_n.jpg",          Bio = "Aunt Katie has 3 kids, 1 grandchild and is married to Tom Hazlett.  Aunt Katie likes to have a good time and loves her family." },

                new Person { FirstName = "Nicole Adrienne",         LastName = "Bender",    Birthday = "November 30th 1985", Picture = "https://scontent-a-sjc.xx.fbcdn.net/hphotos-xfp1/t1.0-9/189945_10150455489965201_2545351_n.jpg",     Bio = "Nicole loves to dance, tan, talk to friends and stay abreast on her celebrity gossip.  Nicole’s favorite color is pink and she grew up in Asheville, NC.  Nicole is very loving, extremely thoughtful, is a wonderful mother and companion.  Nicole has outstanding intuition and is gregarious in nature." }
                );
            context.SaveChanges();
        }
        private static void CreateFamily(ApplicationDbContext context)
        {
            context.Families.AddOrUpdate(f => f.NameOfFamily,
                new Family { NameOfFamily = "Bender",  FamilyCrest = "http://www.thetreemaker.com/coats/Bender-Germany.jpg" },
                new Family { NameOfFamily = "Mahoney", FamilyCrest = "http://www.thetreemaker.com/coats/Mahoney-Ireland.jpg" }
                );
            context.SaveChanges();
        }
    }
}
