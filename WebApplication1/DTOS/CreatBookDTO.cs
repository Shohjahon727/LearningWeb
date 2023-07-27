using FirstWeb.Models;
using WebApplication1.Models;

namespace FirstWeb.DTOS;

public class CreateBookDTO
{
    public string Name { get; set; }
    public float Price { get; set; }
    public string AuthorName { get; set; }
    public int WriterId { get; set; }
    public List<Genre> Genre { get; set; }
}