using System;
using System.Collections.Generic;
using System.Text;

namespace PlannerApp.Shared.Models
{
    public class UserManagerResponse
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
        public string[] Errors { get; set; }
        public UserInfo UserInfo { get; set; }
        public DateTime? ExpireDate { get; set; }
    }

    public class UserInfo
    {
        public string AdditionalProp1 { get; set; }
        public string AdditionalProp2 { get; set; }
        public string AdditionalProp3 { get; set; }
    }
}
