using System.ComponentModel.DataAnnotations;

namespace gregslist_api.Models
{
  public class House
  {
    public int Id { get; set; }
    [Required]
    public int Level { get; set; }
    [Required]
    public int Year { get; set; }
    [Required]
    public int Price { get; set; }
    [Required]
    public string ImgUrl { get; set; }

    public string UserId { get; set; }
  }
}