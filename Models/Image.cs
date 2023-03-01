using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppRazorTrainingSite.Models;

public class Image
{

    public int Id { get; set; }

    public string Name { get; set; }

    public string Path { get; set; }

    [NotMapped]//not created in DB
    [Display(Name ="Image")]//Showed as Image in Front
    public IFormFile File { get; set; }//représente le fichier envoyé sur le serveur

    public int FruitId { get; set; }

    public virtual Fruit Fruit { get; set; }
}
