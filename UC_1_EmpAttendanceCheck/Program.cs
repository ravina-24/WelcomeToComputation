﻿using System;

namespace UC_1_EmpAttendanceCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            //constants
            int IS_FULL_TIME = 1;
            Random random = new Random();
            //computation
            int empCheck = random.Next(0, 2);

            if (empCheck == IS_FULL_TIME)

            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");

            }
        }
    }
}
