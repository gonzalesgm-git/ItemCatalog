using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ItemAPI.Models;

public class Item
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName="nvarchar(100)")]
    public string Name { get; set; } = string.Empty;

    [Column(TypeName = "int")]
    public int Quantity { get; set; } = 0;

    [Column(TypeName = "numeric(10,2)")]
    public double Price { get; set; } = 0.0;

    [Column(TypeName = "nvarchar(100)")]
    public string Manufacturer { get; set; } = string.Empty;
}

