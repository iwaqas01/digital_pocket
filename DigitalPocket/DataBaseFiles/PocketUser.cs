//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalPocket.DataBaseFiles
{
    using System;
    using System.Collections.Generic;
    
    public partial class PocketUser
    {
        public PocketUser()
        {
            this.Transaction = new HashSet<Transaction>();
            this.UWallet = new HashSet<UWallet>();
        }
    
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Image { get; set; }
    
        public virtual ICollection<Transaction> Transaction { get; set; }
        public virtual ICollection<UWallet> UWallet { get; set; }
    }
}