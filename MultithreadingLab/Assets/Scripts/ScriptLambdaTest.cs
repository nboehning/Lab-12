﻿using UnityEngine;
using System.Collections;

public class ScriptLambdaTest : MonoBehaviour
{
    private delegate bool isTeenager(Student student);


    // Use this for initialization
    private void Start()
    {
        Student student1 = new Student(5);
        Student student2 = new Student(10);
        Student student3 = new Student(15);
        Student student4 = new Student(20);

        Debug.Log("Function student1 teenager? : " + funcIsATeen(student1));
        Debug.Log("Function student2 teenager? : " + funcIsATeen(student2));
        Debug.Log("Function student3 teenager? : " + funcIsATeen(student3));
        Debug.Log("Function student4 teenager? : " + funcIsATeen(student4));

        isTeenager isATeen = s => s.age > 12 && s.age < 20;

        Debug.Log("Lambda student1 teenager? : " + isATeen(student1));
        Debug.Log("Lambda student2 teenager? : " + isATeen(student2));
        Debug.Log("Lambda student3 teenager? : " + isATeen(student3));
        Debug.Log("Lambda student4 teenager? : " + isATeen(student4));
    }

    private bool funcIsATeen(Student curStudent)
    {
        return (curStudent.age > 12 && curStudent.age < 20);
    }

private class Student
    {
        public int age;

        public Student()
        {
            age = 10;
        }

        public Student(int age)
        {
            this.age = age;
        }
}
}