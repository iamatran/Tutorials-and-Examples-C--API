using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Book  
{  
    [Key]  
    public  Guid BookId { get; set; }  
    [Required]  
    [MaxLength(150)]  
    public string Title { get; set; }  
    [MaxLength(200)]  
    public string Description { get; set; }  
  
    [ForeignKey("AuthorId")]  
    public Author Author { get; set; }  
  
    public Guid AuthorId { get; set; }  
  
} 