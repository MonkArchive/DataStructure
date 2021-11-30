using System;

namespace Hashing
{
    class Program
    {
        static void Main(string[] args)
        {
            IHashTable<string, Student> hashTable = new ChainedHashTable<string, Student>(10);

            hashTable.Store("123", new Student("Abc", "123"));
            hashTable.Store("456", new Student("Def", "456"));
            hashTable.Store("789", new Student("Ghi", "789"));
            hashTable.Store("321", new Student("Jkl", "321"));
            hashTable.Store("323", new Student("Mno", "323"));
            hashTable.Store("423", new Student("Pqr", "423"));

            Console.WriteLine($"123 Exists in The Table: {hashTable.Exists("123")}");
            Console.WriteLine($"345 Exists in The Table: {hashTable.Exists("345")}");

            hashTable.Remove("323");

        }
    }

    class Student
    {
        string Name;
        string Mobile;

        public Student(string name, string mobile)
        {
            Name = name;
            Mobile = mobile;
        }
    }
}
