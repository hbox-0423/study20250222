﻿using System.Diagnostics;
using System.Dynamic;
using System.Globalization;
using System.Net;

namespace C_study20250222
{
    internal class Program
    {
        //빼기,나누기,나머지,곱하기 기능을 하는 메서드들을 만든다.
        //value값을 초기화 해주는 함수를 만든다 ==>Init(int amount)함수를 만든다.
        //출력 결과
        //계산기에 오신걸 환영합니다.
        //초기 값을 입력해주세요 : 10
        //계산형 방식을 정해주세요 1)더하기 2)빼기 3)곱하기 4)나누기 5)나머지 :1
        //얼만큼 더할건지 알려주세요 : 50
        //계산된 결과값은 60 입니다.
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();

            Console.WriteLine("계산기에 오신걸 환영합니다.");

            Console.Write("초기값을 입력해 주세요. : ");
            calculate.Init(int.Parse(Console.ReadLine()));

            Console.Write("계산할 방식을 정해주세요. 1)더하기, 2)빼기, 3)곱하기, 4)나누기, 5)나머지 : ");
            string method= Console.ReadLine();

            switch (method)
            {
                case "1":
                    Console.Write("얼만큼 더할건지 알려주세요. : ");
                    Console.WriteLine($"계산된 결과 값은 {calculate.Add(int.Parse(Console.ReadLine()))}입니다.");
                    break;
                case "2":
                    Console.Write("얼만큼 뺄건지 알려주세요. : ");
                    Console.WriteLine($"계산된 결과 값은 {calculate.Sub(int.Parse(Console.ReadLine()))}입니다.");
                    break;
                case "3":
                    Console.Write("얼만큼 곱할지 알려주세요. : ");
                    Console.WriteLine($"계산된 결과 값은 {calculate.Mul(int.Parse(Console.ReadLine()))}입니다.");
                    break; 
                case "4":
                    Console.Write("얼마로 나눌지 알려주세요. : ");
                    Console.WriteLine($"계산된 결과 값은 {calculate.Div(int.Parse(Console.ReadLine()))}입니다.");
                    break;
                case "5":
                    Console.Write("얼마로 나눌지 알려주세요. : ");
                    Console.WriteLine($"계산된 결과 값은 {calculate.Rem(int.Parse(Console.ReadLine()))}입니다.");
                    break;
            }
        }
        class Calculate
        {
            private int value;
            public void Init(int amount)
            {
                value = amount;
            }

            public int Add(int amount)
            {
                return value + amount;
            }
            public int Sub(int amount)
            {
                return value - amount;
            }
            public int Div(int amount)
            {
                if (amount == 0)
                    return value;
                return value / amount;
            }
            public int Mul(int amount)
            {
                return value * amount;
            }
            public int Rem(int amount)
            {
                if (amount == 0)
                    return value;
                return value % amount;
            }
        }
    }
}
