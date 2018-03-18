using System;
using System.Collections.Generic;

class Student : IComparable {
	string name;
	uint score;
		
	public Student(string name, uint score){
		this.name = name;
		this.score = score;
	}
	
	public override string ToString(){
		return name + ": " + score;
	}
	
	public int CompareTo(Object obj){
		Student sobj = (Student)obj;
		if(sobj == null || sobj.score < score)
			return -1;
			
		if(score > sobj.score)
			return 1;
			
		return 0;
	}
}

class EasySort {
	public static void Main(string[] args){
		List<Student> students = new List<Student>();
		students.Add(new Student("Bob", 20));
		students.Add(new Student("Joe", 21));
		students.Add(new Student("Mary", 25));
		students.Add(new Student("Paul", 13));
		
		foreach(Student student in students)
			Console.WriteLine(student.ToString());
			
		students.Sort();
		
		Console.WriteLine("\nAfter sorting:");
		
		foreach(Student student in students)
			Console.WriteLine(student.ToString());
	}
}
