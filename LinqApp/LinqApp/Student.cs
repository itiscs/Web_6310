using System;
using System.Collections.Generic;
using System.Text;

namespace LinqApp
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GroupId { get; set; }
        public int Age { get; set; }
        public List<int> Marks { get; set; } = new List<int>();

        public override string ToString()
        {
            return $"Student - {Name} {Age} {Id} {Marks.Average()}";
        }

        public static List<Student> GetStudents()
        {
            var lst = new List<Student>
            {
                new Student { Id = 1,   Name = "Алексей",  GroupId=1,    Age = 20, Marks = new List<int> { 85, 90, 78, 92, 88 } },
                new Student { Id = 2,  Name = "Борис", GroupId=1,      Age = 22, Marks = new List<int> { 75, 80, 68, 72, 70 } },
                new Student { Id = 3,  Name = "Виталий", GroupId=1,    Age = 19, Marks = new List<int> { 95, 88, 91, 90, 93 } },
                new Student { Id = 4,  Name = "Галина", GroupId=1,     Age = 21, Marks = new List<int> { 82, 84,  85, 81 } },
                new Student { Id = 5,  Name = "Дарья", GroupId=1,      Age = 18, Marks = new List<int> { 90, 92, 89, 94, 91 } },
                new Student { Id = 6,  Name = "Егор", GroupId=1,       Age = 23, Marks = new List<int> { 68, 72, 70, 65, 74 } },
                new Student { Id = 7,  Name = "Жанна", GroupId=2,      Age = 20, Marks = new List<int> { 88, 86, 90, 87, 85 } },
                new Student { Id = 8,  Name = "Иван",  GroupId=2,      Age = 19, Marks = new List<int> { 77, 79, 75, 80, 78 } },
                new Student { Id = 9,  Name = "Константин", GroupId=2, Age = 24, Marks = new List<int> { 83, 85, 81, 84, 82 } },
                new Student { Id = 10, Name = "Лариса", GroupId=2,     Age = 21, Marks = new List<int> { 91, 89, 92, 90, 88 } },
                new Student { Id = 11, Name = "Мария",  GroupId=2,     Age = 18, Marks = new List<int> { 95, 94, 96, 93, 97,51 } },
                new Student { Id = 12, Name = "Никита", GroupId=2,     Age = 22, Marks = new List<int> { 70, 72, 68, 73, 71 } },
                new Student { Id = 13, Name = "Олег",  GroupId=3,      Age = 20, Marks = new List<int> { 80, 82, 78, 79, 81 } },
                new Student { Id = 14, Name = "Полина",  GroupId=3,      Age = 19, Marks = new List<int> { 86, 88, 85, 87, 89 } },
                new Student { Id = 15, Name = "Роман",  GroupId=3,      Age = 23, Marks = new List<int> { 74, 76, 72, 75, 73,65 } },
                new Student { Id = 16, Name = "Светлана", GroupId=3,    Age = 21, Marks = new List<int> { 92, 90, 91, 89, 93 } },
                new Student { Id = 17, Name = "Тимур",    GroupId=3,    Age = 18, Marks = new List<int> { 66, 68, 64, 67, 65 } },
                new Student { Id = 18, Name = "Ульяна",  GroupId=3,     Age = 20, Marks = new List<int> { 88, 90, 87, 89, 91 } },
                new Student { Id = 19, Name = "Федор",  GroupId=3,      Age = 24, Marks = new List<int> { 78, 80, 76, 79, 77 } },
                new Student { Id = 20, Name = "Юлия",   GroupId=3,      Age = 22, Marks = new List<int> { 93, 95, 92, 94, 96 } }
            };
            return lst;
        } 



    }
}
