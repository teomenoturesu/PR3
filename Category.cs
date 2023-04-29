using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    internal class Category
    {
        public string CategoryTitle { get; set; }
        public List<Question> Questions { get; set; }

        public Category(string title, List<Question> questions)
        {
            CategoryTitle = title;
            Questions = questions;
        }
    }
}
