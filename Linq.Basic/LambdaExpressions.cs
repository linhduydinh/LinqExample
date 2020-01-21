using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Basic
{
    public class LambdaExpressions
    {

        string[] cities = new string[]
        {
            "Linq",
            ".NET"
        };


        public void Test()
        {
            IEnumerable<string> filter = cities.Where(delegate(string s)
            {
                return s.StartsWith("L");
            });



            TestDelegate lambda = s => Console.WriteLine(s);

            var studentList = new List<Student>();

            //Thứ đẹp đẽ ngắn gọn này là lambda expression
            var students = studentList.Where(stu => stu.Age > 20);

            //Nếu không có nó, ta phải viết cái thứ vừa dài dòng vừa gớm ghiếc như sau
            var student = studentList.Where(delegate (Student stu) { return stu.Age > 20; });

        }

        public delegate void TestDelegate(string s);

        public bool StartWithLTest(string name, decimal test)
        {
            return name.StartsWith("L");
        }

        public bool StartWithL(string name)
        {
            return name.StartsWith("L");
        }
    }
}
