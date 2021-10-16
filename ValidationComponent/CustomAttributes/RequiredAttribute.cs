using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationComponent.CustomAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter 
     | AttributeTargets.Property, AllowMultiple = false)]
    public class RequiredAttribute:Attribute
    {
        public string ErrorMessage { get; set; }

        public RequiredAttribute()
        {
            ErrorMessage = "You cannot leave field, {0}, empty";
        }
        public RequiredAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }
}
