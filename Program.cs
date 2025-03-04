using System.Diagnostics;
using System.Globalization;
using System.Net;

namespace C_study20250222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///*변수의 선언, 변수형*/
            //Console.WriteLine("Hello world!!");
            //int age = 26;
            //Console.WriteLine(age);
            ///*int, short, long, byte 정수형
            //string 문자열
            //char 문자
            //변수에는 데이터(값)이 하나만 저장할 수 있다.*/
            //string name = "Hello";
            //short age1 = 26;
            //long age2 = 26;
            //byte age3 = 26;
            //Console.WriteLine(name);
            //Console.WriteLine(age1);
            //Console.WriteLine(age2);
            //Console.WriteLine(age3);

            ///*
            //부동 소수점(실수)
            //소수의 범위를 정함으로서 실수를 근사적으로 표현
            //소수점의 위치가 고정x, 수의 범위와 정밀도에 따라 변할 수 있음
            //컴퓨터에서 수를 저장할때 정수 부분과 소수 부분을 나누어 저장//(정수).(소수)
            //*/
            //double a;//4byte(6~7자리)
            //float b;//8byte(15~16자리)
            //decimal c;//16byte(28~29자리)
            //a = 5.78;//double {*.**(d)}
            //b = 3.57f;//float {*.**f(F)}
            //c = 2.4567m;//decimal {*.**m(M)}
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            ///*
            // 불리언 데이터
            // 참/거짓(true/false)을 나타내는데 사용
            // 1/0                                  
            //*/
            //bool isCsharp = false;
            //bool isSunday = true;
            ///*
            // 문자/문자열
            //char(문자)//2byte
            //string(문자열)//최대 2048byte
            //*/
            //char mychar = 'c';
            //char hanguel = '한';
            //string mystring = "mystring";
            //string mystring2 = "한글";
            //Console.WriteLine(mystring);
            //Console.WriteLine(hanguel);
            //Console.WriteLine(mychar);
            //Console.WriteLine(mystring2);
            ///*문자열 포멧팅
            // * 복잡한 데이터를 보기 좋게 표현
            // * 코드의 가시성 상승=> 코드짜기 편하다
            // * $기호화 []를 사용
            //*/
            //int a1 = 1;
            //int b1 = 3;
            //string format1 = $"3 * {a1} = {b1}";
            //Console.WriteLine(format1);
            ///*문자열+문자열*/

            //mystring2 = mystring2 + "입니다.";
            //Console.WriteLine(mystring2);
            ///*연산자
            // +, -, /, *, %
            //*/
            //int int1 = (10 - 4) * 3;
            //Console.WriteLine(int1);
            //int1 = int1 + 3;
            //Console.WriteLine(int1);
            //int1 += 3;
            //Console.WriteLine(int1);
            //int1 -= 3;
            //Console.WriteLine(int1);
            //int1 *= 3;
            //Console.WriteLine(int1);
            //int1 /= 3;
            //Console.WriteLine(int1);

            ///*비교 연산자
            // ==, !=, <, <=, >, >=
            // */
            //bool isequal = (21 == a1);
            //bool isnotequal = (21 != a1);
            //Console.WriteLine($"Is Equal:{isequal}");
            //Console.WriteLine($"Is not Equal:{isnotequal}");

            ///*논리 연산자
            // AND, OR, NOT, NOR, NAND
            // */
            //bool And = (isequal && isnotequal);
            //Console.WriteLine($"AND:{And}");
            //bool Or = (isequal || isnotequal);
            //Console.WriteLine($"OR:{Or}");
            //bool Not = !Or;
            //Console.WriteLine($"NOT:{Not}");
            //bool isMan = true;
            //bool isStudent = true;
            //bool isMonday = false;
            //if (isMan && isStudent && !isMonday)
            //{
            //    Console.WriteLine("Man and Student,Not Monday");
            //}
            //Console.WriteLine(isMan || isMonday);

            ///*증감 연산자
            // 값을 1씩 증가, 감소 시키는 연산자
            //++, --
            //a++ 이 코드가 실행되고 나서 1을 증가시킨다.
            //++a 이 코드를 실행되기 전에 1을 증가시킨다.
            // */
            //int a3 = 0;
            //for (int i = 0; i < int1; i++)
            //{
            //    Console.WriteLine(a3);
            //    a3++;
            //}
            ///*증감 연산자를 같은 줄의 코드에 사용될때 주의점*/
            //int a2 = 10;
            //Console.WriteLine(a2++);//a2(10)를 먼저 출력 후 +1(후위)
            //Console.WriteLine(++a2);//a2(11)에 +1 후에 a2(12)를 출력(전위)

            ///*캐스팅
            // 데이터 타입을 변환하는 방법
            //1. 암시적 캐스팅
            //변환되는 데이터가 원본 데이터보다 더 큰 범위를 가질때, 더 많은 정보를 저장할때 발생
            //2. 명시적 캐스팅
            //변환되는 데이터가 원본 데이터버다 더 작은 범위를 가질때, 더 적은 정보를 저장할때 발생
            //*/
            //int a4 = 1000000000;
            //long b4 = a4;//암시적

            //long b5 = 1000000000;
            //int a5 = (int)b5;//명시적, long은 int 보다 더 큰 범위를 가지기 때문에 int데이터에 long을암시적을로 넣을 수 없다.따라서 명시적으로 (int)c 형식으로 선언하여 데이터 타입의 전환을 강제할 수 있다.이때 데이터 범위가 작아지기 때문에 데이터 손실잉 발생할 수 있다.

            //float a6 = 14.25f;
            //int b6 = (int)a6;
            //Console.WriteLine(b6);
            //int result = 10 / 3;
            //Console.WriteLine(result);
            //float Fresult = 10 / 3.0f;
            //Console.WriteLine(Fresult);
            //int num1 = 10;
            //int num2 = 3;
            //float op = num1 / (float)num2;
            //Console.WriteLine(op);

            ///*조건문
            // if(조건->true, false/비교, 논리, bool){
            //        if문의 조건이 true일때 실행될 코드
            //    }
            //else{
            //        if문의 조건이 false일때 실행될 코드//기본적으로는 선언 하지 않아도 된다.
            //        else문은 if문 바로 뒤에 사용되어야 한다. 중간에 다른 코드가 들어갈 ㅅ후 ㅇ벗다
            //    }
            // */
            //if (10>5) 
            //{
            //    Console.WriteLine("10은 5보다 크다");
            //    if (10>9) {
            //        Console.WriteLine("10은 9보다도 크다.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("10은 5보다 크지 않다.");
            //}

            //int grade = 7;
            //string tear;
            //if (grade >= 90)
            //{
            //    tear = "A";
            //}
            //else if (grade >= 80)
            //{
            //    tear = "B";
            //}
            //else if(grade >= 70)
            //{
            //    tear = "C";
            //}
            //else if (grade >= 60)
            //{
            //    tear = "D";
            //}
            //else
            //{
            //    tear = "F";
            //}
            //if(grade%10>=5 && tear != "F")
            //{
            //    tear += "+";
            //}

            //Console.WriteLine(tear);

            //int grade1 = 94;
            //string tear1;
            //switch (grade1/10)
            //{
            //    case 10:   
            //    case 9:
            //        {
            //            tear1 = "A";
            //        }
            //        break;
            //    case 8:
            //        {
            //            tear1 = "B";
            //        }
            //        break;
            //    case 7:
            //        {
            //            tear1 = "C";
            //        }
            //        break;
            //    case 6:
            //        {
            //            tear1 = "D";
            //        }
            //        break;
            //    default:
            //        {
            //            tear1 = "F";
            //        }
            //        break;
            //}
            //if (grade1 % 10 > 5 && tear1!="F" || grade1==100)
            //    tear1 += "+";

            //Console.WriteLine(tear1);

            ///*콘솔창에서 입력 받기
            // Console.Readline();
            // */
            //Console.WriteLine("**데이터값 입력**");
            //string input = Console.ReadLine();//기본적으로 string 값/문자열로만 받는다. 숫자로 변환하고 싶을 때
            //Console.WriteLine($"입력 받은 값 : {input}");

            /*문제) 사용자로부터 날씨를 입력 받고, 해당하는 메세지 출력*/
            //맑음 => "오늘의 날씨가 좋네요"
            //비 => "우산을 챙기세요"
            //눈 => "따뜻하게 입으세요"
            //나머지 => "날씨 정보를 알 수 없습니다."

            //Console.Write("오늘의 날씨를 입력하세요(맑음/비/눈) : ");
            //string weather=Console.ReadLine();
            //switch (weather)
            //{
            //    case "맑음":
            //        Console.WriteLine("오늘의 날씨가 좋네요.");
            //        break;
            //    case "비":
            //        Console.WriteLine("우산을 챙기세요.");
            //        break;
            //    case "눈":
            //        Console.WriteLine("따뜻하게 입으세요.");
            //        break;
            //    default:
            //        Console.WriteLine("날씨 정보를 알 수 없습니다.");
            //        break;
            //}

            /*Parse
            문자열 데이터를 다른 데이터 타입으로 변환하는 기능
            */
            //Console.Write("숫자를 입력해 주세요 : ");
            //string input =Console.ReadLine();
            //int value = int.Parse(input);
            //Console.Write(value);
            /*문제)놀이동산 입장권
             * 사용자로부터 나이, 군인할인, 연간 회원 여부를 입력받아서 입장요금을 계산
             * 1.무료입장 조건: 나이가 3세이하 65세이상, 연간 회원
             * 2.할인 적용: 군인 30%할인
             * 3.일반 요금:성인(19~64세)10,000원, 청소년(13~18세)8,000원, 어린이(4~12세)5,000원
             * 
             * 나이를 입력하세요:(나이)
             * 군인인가요?(네/아니요):
             * 연산 회원인가요?(네/아니요):
             * 입장료는 000입니다./무료 입장입니다.
             */

            Console.Write("나이를 입력하세요 : ");
            string age = Console.ReadLine();
            int age1= int.Parse(age);
            Console.Write("군인인가요?(네/아니요) : ");
            string isSol = Console.ReadLine();
            Console.Write("연간 회원인가요?(네/아니요) : ");
            string isMem = Console.ReadLine();

            double price=0;

            if (age1 >= 65 || isMem == "네")
            {
                Console.WriteLine("무료 입장입니다.");
            }
            else
            {
                if (age1 <= 64 && age1 >= 19)
                    price = 10000;
                else if (age1 <= 18 && age1 >= 13)
                    price = 8000;
                else if (age1 <= 12 && age1 >= 4)
                    price = 5000;
                if (isSol == "네")
                    price *= 0.7;
            }

            Console.WriteLine($"입장료는 {price}입니다.");
        }
    }
}
