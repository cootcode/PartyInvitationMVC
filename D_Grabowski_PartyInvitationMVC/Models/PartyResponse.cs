using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace D_Grabowski_PartyInvitationMVC.Models
{
    public class PartyResponse
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool CanMakeIt { get; set; }
    }
}