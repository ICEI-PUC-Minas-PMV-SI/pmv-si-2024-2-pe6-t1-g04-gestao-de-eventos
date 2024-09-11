using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoEventos.Models;

[Table("Usuarios")]
public class Usuario
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Nome { get; set; }
    
    [Required]
    public int CodigoPessoa { get; set; }

    [Required]
    public string Email { get; set; }

    [Required]
    public string Telefone { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public Perfil Perfil { get; set; }

}

public enum Perfil
{
    [Display(Name = "Administrador")]
    Aluno,
    [Display(Name = "Professor")]
    Professor,
    [Display(Name = "Funcionario")]
    Funcionario
}

