using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table ("MovieCommente")]
public class MovieComment
{
    [Key]
    public int Id {get; set;}
    
    [Required]
    public int MovieId {get; set;}
    [ForeignKey("MovieId")]
    public Movie Movie {get; set;}

    [Required]
    public string UserId {get; set;}
    [ForeignKey("UserId")]
    public AppUser User {get; set;}

    [Required]
    [StringLength(1000)]
    public string ComponentText {get; set;}

    [Required]
    public DateTime CommentDate {get; set;}
}
