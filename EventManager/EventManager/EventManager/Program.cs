using System;
using EventApp;
using EventApp.Models;

public class Program
{

    public static void Main(string[] args)
    {

        Guest guest1 = new Guest("Milan", "Dvorak", 69);
        Guest guest2 = new Guest("Thinh", "Leduc", 18);
        Guest guest3 = new Guest("Adolf", "Putin", 13);
        Guest guest4 = new Guest("Mike", "Wazowski", 94);

        Performer performer1 = new Performer("Nikki", "Sixx", 64, "baskytara");
        Performer performer2 = new Performer("Tommy", "Lee", 61, "bubny");
        Performer performer3 = new Performer("Mick", "Mars", 72, "kytara");
        Performer performer4 = new Performer("Vince", "Neil", 62, "zpěv");

        Event event1 = new Event("SVATBA", "Wintersss");

        event1.AddAtendee(guest1);
        event1.AddAtendee(guest2);
        event1.AddAtendee(guest3);
        event1.AddAtendee(guest4);

        event1.AddAtendee(performer1);
        event1.AddAtendee(performer2);
        event1.AddAtendee(performer3);
        event1.AddAtendee(performer4);

        guest1.processInvitation(true);
        guest2.processInvitation(false);

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
        Console.WriteLine("");

        event1.RemoveAtendee("Milan", "Dvorak");

        event1.DisplayPerformers();
        Console.WriteLine("");
        event1.DisplayGuests();
    }

}