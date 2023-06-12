using System.ComponentModel.DataAnnotations;
namespace Survey1.Models;
public class Survey
{
    [Required(ErrorMessage ="Name Required")]
    [MinLength(2, ErrorMessage = "Minimum Length is 2")]
    public string Name {get;set;}
    [Required(ErrorMessage = "Location Needed")]
    public string? Location {get;set;}
    [Required(ErrorMessage = "Language Needed")]
    public string? Language {get;set;}
    [MinLength(20, ErrorMessage = "Minimum Length is 20")]
    public string? Comment {get;set;}
}