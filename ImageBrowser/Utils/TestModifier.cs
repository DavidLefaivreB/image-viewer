using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ImageBrowser.Utils
{
    [AttributeUsage(AttributeTargets.Property)]
    public class TestModifier : DescriptionAttribute
    {
        public TestModifier(string description)
        {
            
        }
    }
}