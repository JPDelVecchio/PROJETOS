using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReqMateriaisRmTotvs.Models
{
    public class Usuario
    {
        [DisplayName("Usuário"), Required]
        public string usuario { get; set; }
        [Range(1,30)]
        public string senha { get; set;  }
        [Required(ErrorMessage ="Informe o e-mail ou informe e-mail corretamente")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Email inválido.")]
        public string email { get; set; }
        
        public Usuario()
        {
            this.usuario = "";
            this.senha = null;
            this.email = "teste@exemple.com.br";
        }
    }
}