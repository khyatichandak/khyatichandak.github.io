//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace S1G6_PVFAPP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblNotificationQueue
    {
        public int ID { get; set; }
        public int NotificationType_ID { get; set; }
        public Nullable<int> Version_ID { get; set; }
        public Nullable<int> Model_ID { get; set; }
        public Nullable<int> Entity_ID { get; set; }
        public Nullable<int> Member_ID { get; set; }
        public Nullable<byte> MemberType_ID { get; set; }
        public string Message { get; set; }
        public Nullable<int> BRBusinessRule_ID { get; set; }
        public string PriorityRank { get; set; }
        public System.DateTime EnterDTM { get; set; }
        public int EnterUserID { get; set; }
        public Nullable<System.DateTime> DueDTM { get; set; }
        public Nullable<System.DateTime> SentDTM { get; set; }
    
        public virtual tblModel tblModel { get; set; }
        public virtual tblModelVersion tblModelVersion { get; set; }
    }
}
