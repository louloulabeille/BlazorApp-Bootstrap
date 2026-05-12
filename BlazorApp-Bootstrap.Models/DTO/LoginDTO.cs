using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp_Bootstrap.Models.DTO
{
    public enum Prenom
    {
        Hanna,
        Lily,
        Eva
    }

    public enum RangeMinMax
    {
        Min=0,
        Max=100
    }

    public class LoginDTO
    {
        [Required(ErrorMessage ="Email est obligatoire pour se connecter.")]
        public string LoginEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = "Le mot de passe est obligatoire pour se connecter."),StringLength(20,MinimumLength = 8,ErrorMessage = "Le mot de passe doit avoir 8 caractères minimun et 20 caractères maximun.")]
        public string Password { get; set; } = string.Empty;
        public bool CheckMe { get; set; }

        [Required(ErrorMessage = "Le texte aréa est obligatoire.")]
        public string TextArea { get; set; } = string.Empty;
        public string Selection { get; set; } = string.Empty;


        // - checkbox
        public bool CheckOption { get; set; } = false;
        public bool CheckView { get; set; } = false;

        // - radiobutton
        public Prenom Nickname { get; set; }

        // - input range
        public int Range { get; set; } = 12;

    }
}
