using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyWithManyFieldsApp
{
    class PropertyWithManyFields
    {
        private string text = "Dept. of Computer Engineering";
        private bool isModified = false;
        public string Text
        {
            get { return text; }
            set { text = value; isModified = true; }
            //many field set
        }
        public void PrintStatus()
        {
            Console.WriteLine("text is \"" + text + "\", and " +
                (isModified ? "is" : "not") + " modified.");//그냥 class안에 정의된 field 사용한것
        }
    }
    class Program
    {
        public static void Main()
        {
            PropertyWithManyFields obj = new PropertyWithManyFields();
            obj.PrintStatus();
            obj.Text = "Programming Language Lab";//set호출됨
            obj.PrintStatus();
        }
    }
}
