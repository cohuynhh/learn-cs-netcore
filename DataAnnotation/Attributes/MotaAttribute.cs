using System;
namespace DataAnnotation.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Method)]
    public class MotaAttribute : Attribute
    {
        public MotaAttribute(string v) => Description = v;
        public  string Description {set; get;}
    }
}