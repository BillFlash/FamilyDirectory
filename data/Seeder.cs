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
                new Person { FirstName = "John Jacob",              LastName = "Bender",  Birthday = "August 17, 1954",             Picture = "https://scontent-b-sjc.xx.fbcdn.net/hphotos-xpa1/t1.0-9/58143_1438811127037_1217511_n.jpg", Bio = "John Jacob Bender Jr was the first of nine children and first of 5 boys to Alice Rafferty Bender and John Jacob Bender. John who is better known as Jack has been married to Laurie for a long time and has 3 kids and 3 grandchildren of his own.  Jack is a great dad to his children and is the only bender besides his dad to retire in which he spent 22 years in the service protecting our country.  Jack's last held job was working as a CFO for Hazlett Homes Inc. and is currently retired spending most of his time hanging out with his family and spending time in the great outdoors with his friends hunting, fishing and relaxing." },
                new Person { FirstName = "Samuel Martin",           LastName = "Bender",  Birthday = "April 9th, 1987",             Picture = "https://scontent-a-sjc.xx.fbcdn.net/hphotos-xap1/t1.0-9/1380641_10100171015146512_1700133377_n.jpg", Bio = "Sam Bender is the son of Jack and Laurie Bender and the twin of Alexander Robert Bender and the brother of Krisitine Mahoney.  Sam is currently working as a Software Engineer and enjoys to surf, program, spend time with his wife Nicole, son Samuel, play lacrosee and read.  Sam is an active member of the society and oftern spends time coaching youth league players in Lacrosse. " },
                new Person { FirstName = "Alexander Robert",        LastName = "Bender",  Birthday = "April 9th 1987",              Picture = "https://scontent-b-sjc.xx.fbcdn.net/hphotos-xpa1/t1.0-9/58143_1438811127037_1217511_n.jpg", Bio = "write later" },
                new Person { FirstName = "Kritine (Emilia) Bender", LastName = "Mahoney", Birthday = "August 7, 1982",              Picture = "https://scontent-b-sjc.xx.fbcdn.net/hphotos-xaf1/t1.0-9/4573_915091726749_547199_n.jpg", Bio = "Married to James Mahoney, has 2 kids, Bachelors and Masters from ion education from University of North Carolina Charlotte, loves music, yoga and fun." },
                new Person { FirstName = "Laurie Robin",            LastName = "Bender",  Birthday = "June 25th, 1957",             Picture = "https://scontent-a-sjc.xx.fbcdn.net/hphotos-xaf1/t1.0-9/26810_100502293327531_5469351_n.jpg", Bio = "My mom, add more later" },
                new Person { FirstName = "Samuel Jacob",            LastName = "Bender",  Birthday = "September 7th, 2012",         Picture = "https://scontent-b-sjc.xx.fbcdn.net/hphotos-xpa1/t1.0-9/1382867_10153314072750201_1309677349_n.jpg", Bio = "Samuel Jacob Bender is the son of Mr. amd Mrs. Samuel Martin Bender, loves to play with his cars, his letters, loves to read and play sports.  Samuel is a very good eater and hasnt found something he doesnt like. " },
                new Person { FirstName = "Nicole Adrienne",         LastName = "Bender",  Birthday = "November 30th 1985",          Picture = "https://scontent-a-sjc.xx.fbcdn.net/hphotos-xfp1/t1.0-9/189945_10150455489965201_2545351_n.jpg", Bio = "Nicole loves to dance, tan, talk to friends and stay abreast on her celebrity gossip.  Nicoles favorite color is pink and grew up in Asheville, NC.  Add more later." }
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
