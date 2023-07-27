﻿using WebApplication1.Models;

namespace FirstWeb.Models;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public float Price { get; set; }
    public string AuthorName { get; set; }
    public int WriterId { get; set; }
    public List<Genre> Genres { get; set; } = new();
}