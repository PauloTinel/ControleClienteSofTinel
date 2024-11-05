using Microsoft.AspNetCore.Identity;

namespace ControleClienteSofTinel.Dominio.Identity
{
    public class ApplicationUserClaims : IdentityUserClaim<string>
    {
        //[ForeignKey("Objeto")]
        //[Required(ErrorMessage = "Objeto deve ser informado.")]
        //public int IdObjeto { get; set; }
        //public virtual ObjetoVO Objeto { get; set; }
    }
}
