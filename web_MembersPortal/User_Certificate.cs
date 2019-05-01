using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_MembersPortal
{
    public class User_Certificate
    {
        public string Id { get; set; }

        public string username { get; set; }

        public string description { get; set; }

        public double balance { get; set; }

        public string lastActivityDate { get; set; }

        public string interestRate { get; set; }

        public string maturityDate { get; set; }
    }
}