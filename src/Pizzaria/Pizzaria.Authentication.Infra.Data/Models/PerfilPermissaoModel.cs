using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Authentication.Infra.Data.Models
{
    public class PerfilPermissaoModel
    {
        public int Id { get; set; }
        public int PerfilId { get; set; }
        public virtual PerfilModel Perfil { get; set; }
        public int PermissaoId { get; set; }
        public virtual PermissaoModel Permissao { get; set; }
    }
}
