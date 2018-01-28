using System;
using System.Collections.Generic;
using System.Linq;

namespace ListEvenNum
{
    class Program
    {
        static void Main(string[] args)
        {
            //evenNumber();
            // stringBeginEnd();
            // findMaxNumber();
            // sortString();
            findStudent();
        }

        // bai 1: tim so chan qua list number nhap vao
        static void evenNumber()
        {
            List<int> evenNumber = new List<int>();
            System.Console.WriteLine("input numbers: ");
            evenNumber.Add(int.Parse(Console.ReadLine()));
            evenNumber.Add(int.Parse(Console.ReadLine()));
            evenNumber.Add(int.Parse(Console.ReadLine()));
            evenNumber.Add(int.Parse(Console.ReadLine()));
            
            System.Console.Write("even numbers are: ");
            foreach (var item in evenNumber)
            {
                if(item%2==0)
                System.Console.Write(item+", ");
            }
        }

        // bai2: Có 1 tập hợp chuỗi, tìm phần tử bắt đầu và kết thúc với kí tự nhất định
        static void stringBeginEnd()
        {
            List<string> str = new List<string>();
            str.Add("barcelona");
            str.Add("manchester utd");
            str.Add("chelsea");
            str.Add("man city");
            str.Add("bayer munich");
            str.Add("vietnam");
            str.Add("bay arena");

             var result = from element in str 
                            where (element.StartsWith("b")&& element.EndsWith("a"))
                            select element;
            
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }
        }

        // bai 3: Nhận tập hợp List chứa số và in ra n-th số lớn nhất
        static void findMaxNumber()
        {
            List<int> number = new List<int>();
            System.Console.WriteLine("moi ban nhap vao so phan tu trong list ");
            int n = int.Parse(Console.ReadLine());
            System.Console.WriteLine("moi ban nhap vao cac so: ");
            for(int i = 0 ; i<n;i++)
            {
                number.Add(int.Parse(Console.ReadLine()));
            }
            
            System.Console.Write("nhap vao vi tri so lon thu n:");
            int position = int.Parse(Console.ReadLine());
            int result =0;
            number.Sort();// sap xep lai list
            for(int i =1;i<=number.Count;i++)
            {
                 System.Console.Write(number[(i-1)]+" ");
                 result = number[(number.Count-position)];
            }
            System.Console.WriteLine("\n so lon thu {0} la {1}",position,result);
        }

        // bai4: Tạo 1 tập hợp chuỗi và sắp xếp các phần tử riêng biệt theo thứ tự A-Z
        static void sortString()
        {
            List<string> str = new List<string>();
            str.Add("barcelona");
            str.Add("arsenal");
            str.Add("arsenal");
            str.Add("real madrid");
            str.Add("juventus");
            str.Add("mancity");

            var result = from elemnt in str
                            orderby elemnt ascending
                            select elemnt;
            
            foreach (var item in result)
            {
                System.Console.WriteLine(item);
            }

        }

        // bai 6: Cho 1 tập hợp học sinh và điểm, tìm các học sinh có điểm thấp hơn điểm trung bình sử dụng let trong linq
        static void findStudent()
        {
            Student student1 = new Student(){name ="nguyen van a", mark = 8};
            Student student2 = new Student(){name ="tran van b", mark = 3};
            Student student3 = new Student(){name ="le thi c", mark = 6};
            Student student4 = new Student(){name ="pham ba d", mark = 5};
            Student student5 = new Student(){name ="dinh la thang", mark = 4};
            Student student6 = new Student(){name ="nguyen phu trong", mark = 2};
            Student student7 = new Student(){name ="abcdef", mark = 9};
            // cho vao list student
            List<Student> student = new List<Student>(){student1,student2,student3,student4,student5,student6,student7};

            // tinh diem trung binh
            var avgMark = student.Average(element => element.mark);
            System.Console.WriteLine("diem trung binh la: "+avgMark);
            var markUnderAverage = from element in student
                                    where element.mark<avgMark
                                    select element; 
             foreach (var item in markUnderAverage)
             {
                 System.Console.WriteLine(item.name);
             }                        

        }
    }

    public class Student
    {
        public string name{get;set;}
        public int mark{get;set;}
    }
}
