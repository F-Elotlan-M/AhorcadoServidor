//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Player
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Player()
        {
            this.Lobby = new HashSet<Lobby>();
        }
    
        public int IdPlayer { get; set; }
        public string NamePlayer { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PasswordPlayer { get; set; }
        public string Username { get; set; }
        public int Points { get; set; }
        public int GamesWin { get; set; }
        public Nullable<int> IdAvatar { get; set; }
    
        public virtual Avatar Avatar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lobby> Lobby { get; set; }
    }
}
