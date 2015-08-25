using System;
using System.Collections.Generic;

namespace Server.Models
{
    public partial class webpages_Users
    {
        public webpages_Users()
        {
            this.tbLogAcessoUsuarios = new List<tbLogAcessoUsuario>();
            this.grupo_empresa1 = new List<grupo_empresa>();
            this.ConciliacaoRecebimentoes = new List<ConciliacaoRecebimento>();
            this.LogAcesso1 = new List<LogAcesso1>();
            this.LoginAutenticacaos = new List<LoginAutenticacao>();
        }

        public int id_users { get; set; }
        public string ds_login { get; set; }
        public string ds_email { get; set; }
        public Nullable<int> id_grupo { get; set; }
        public string nu_cnpjEmpresa { get; set; }
        public string nu_cnpjBaseEmpresa { get; set; }
        public Nullable<int> id_pessoa { get; set; }
        public bool fl_ativo { get; set; }
        public virtual ICollection<tbLogAcessoUsuario> tbLogAcessoUsuarios { get; set; }
        public virtual empresa empresa { get; set; }
        public virtual grupo_empresa grupo_empresa { get; set; }
        public virtual ICollection<grupo_empresa> grupo_empresa1 { get; set; }
        public virtual pessoa pessoa { get; set; }
        public virtual webpages_Membership webpages_Membership { get; set; }
        public virtual ICollection<ConciliacaoRecebimento> ConciliacaoRecebimentoes { get; set; }
        public virtual ICollection<LogAcesso1> LogAcesso1 { get; set; }
        public virtual ICollection<LoginAutenticacao> LoginAutenticacaos { get; set; }
    }
}
