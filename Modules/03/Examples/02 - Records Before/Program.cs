﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Album album = new Album
        {
            Artist = "Depeche Mode",
            AlbumName = "Violator",
            ReleaseDate = new DateTime(1990, 03, 19)
        };
        Console.WriteLine(album.Age);

        //album.Artist = "Somebody Else";
    }
}

public record Person(string FirstName, string LastName);

public class Album
{
    public string Artist { get; init; }
    public string AlbumName { get; init; }
    public DateTime ReleaseDate { get; init; }

    public int Age
    {
        get
        {
            DateTime today = DateTime.Now;
            return today.Year - ReleaseDate.Year - (ReleaseDate.DayOfYear < today.DayOfYear ? 0 : 1);
        }
    }
}