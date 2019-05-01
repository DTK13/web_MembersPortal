using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_MembersPortal
{
    public class User_Loan
    {
        public string Id { get; set; }

        public string username { get; set; }

        public string description { get; set; }

        public double balance { get; set; }

        public string lastActivityDate { get; set; }

        public string paymentDueDate { get; set; }

        public double minimumAmountDue { get; set; }
    }
}