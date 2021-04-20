﻿namespace ConsoleUI
{
    class Student : Person
    {
        //fields
        private string _program;
        private int _year;
        private double _fee;

        //properties
        public string Program
        {
            get { return _program; }
            set { _program = value; }
        }
        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
        public double Fee
        {
            get { return _fee; }
            set { _fee = value; }
        }

        //constructor
        public Student(string name, string address, string program, int year, double fee) : base (name, address)
        {
            this._program = program;
            this._year = year;
            this._fee = fee;
        }

        public Student()
        {

        }

        //Method
        public override string ToString()
        {
            string output = base.ToString();
            return $"{ output }, program: { this._program }, Year: { this._year }, Fee: { this._fee }";
        }
    }
}
