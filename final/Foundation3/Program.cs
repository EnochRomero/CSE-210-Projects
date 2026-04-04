using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Street Ave", "Rexburg", "Idaho", "USA");
        Address address2 = new Address("404 Notfound Street", "Hays", "Kansas", "USA");

        Lecture newLecture = new Lecture("What I've Learned", "A one hour lecture on the meaning of life", "4/4/26", "4 PM", address1, "John Green", 500);

        Outdoor newOutdoor = new Outdoor("Adventure Time", "4 Hours of hiking and fun.", "6/8/30", "3 PM", address2, "Sunny");

        Reception newReception = new Reception("John and Sarah's Receotion", "Dinner and a movie", "1/9/24", "8 PM", address2, "example@gmail.com");

        newLecture.DisplayShort();
        newLecture.DisplayStandard();
        newLecture.DisplayFull();

        newOutdoor.DisplayShort();
        newOutdoor.DisplayStandard();
        newOutdoor.DisplayFull();

        newReception.DisplayShort();
        newReception.DisplayStandard();
        newReception.DisplayFull();








    }
}