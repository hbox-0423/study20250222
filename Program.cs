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

            ///*Parse
            // *문자열 데이터를 다른 데이터 타입으로 변환하는 기능
            // */
            //Console.Write("숫자를 입력해 주세요 : ");
            //string input =Console.ReadLine();
            //int value = int.Parse(input);
            //Console.Write(value);
            ///*문제)놀이동산 입장권
            // * 사용자로부터 나이, 군인할인, 연간 회원 여부를 입력받아서 입장요금을 계산
            // * 1.무료입장 조건: 나이가 3세이하 65세이상, 연간 회원
            // * 2.할인 적용: 군인 30%할인
            // * 3.일반 요금:성인(19~64세)10,000원, 청소년(13~18세)8,000원, 어린이(4~12세)5,000원
            // * 
            // * 나이를 입력하세요:(나이)
            // * 군인인가요?(네/아니요):
            // * 연산 회원인가요?(네/아니요):
            // * 입장료는 000원 입니다./무료 입장입니다.
            // */

            //직접 풀어본 코드
            //Console.Write("나이를 입력하세요 : ");
            //string age = Console.ReadLine();
            //int age1= int.Parse(age);
            //Console.Write("군인인가요?(네/아니요) : ");
            //string isSol = Console.ReadLine();
            //Console.Write("연간 회원인가요?(네/아니요) : ");
            //string isMem = Console.ReadLine();

            //double price=0;

            //if (age1 >= 65 || isMem == "네" || age1 <= 3)
            //{
            //    Console.WriteLine("무료 입장입니다.");
            //}
            //else
            //{
            //    if (age1 <= 64 && age1 >= 19)
            //        price = 10000;
            //    else if (age1 <= 18 && age1 >= 13)
            //        price = 8000;
            //    else if (age1 <= 12 && age1 >= 4)
            //        price = 5000;
            //    if (isSol == "네")
            //        price *= 0.7;
            //}

            //Console.WriteLine($"입장료는 {price}원 입니다.");

            ///*예시*/
            //int adult = 10000;
            //int youth = 8000;
            //int child = 5000;

            //Console.Write("나이를 입력하세요 : ");
            //string _Age = Console.ReadLine();
            //int _Age1 = int.Parse(_Age);
            //Console.Write("군인인가요?(네/아니요) : ");
            //string _isSol = Console.ReadLine();
            //Console.Write("연간 회원인가요?(네/아니요) : ");
            //string _isMem = Console.ReadLine();
            ////요금 계산
            //float pay = 0;
            //if (_Age1 >= 65 || _Age1 <= 3)//나이가 65이상 OR 3세 이하
            //{
            //    pay = 0;
            //}
            //else if (_Age1 <= 64 && _Age1 >= 19)//19세 이상 And 64세 이하
            //    pay = adult;
            //else if (_Age1 <= 18 && _Age1 >= 13)//18세 이상 And 13세 이하
            //    pay = youth;
            //else//4세 이상 And 12세 이하
            //    pay = child;
            //if (_isSol == "네")
            //{
            //    //현재 apy*0.7 == 70% 할인된 가격
            //    //pay *= 0.7f;//int형 변수는 소수점을 계산하지 못하기 때문에 float, double형을 바꾸어 주어야한다             
            //    //float temp = (pay * 0.7f); //값이 6999.1535... 식으로 나올 수 있음.        
            //    //pay = (int)temp;
            //    pay = (int)(pay * 0.7f); //pay * 0.7f을 먼저 계산한 후에 int형으로 바꾸기 위해 ()를 써주어야한다.
            //}
            //if (_isMem == "네")
            //    pay = 0;

            //if(pay==0)
            //    Console.WriteLine("무료 입장입니다.");
            //else
            //    Console.WriteLine($"입장료는 {pay}원 입니다.");

            ///*반복문
            // * 코드를 반복적으로 실행=>언제까지 반복을 실핼할 것인가?(중요)//프로그래머가 정의
            // * 크게 아래 3개로 나뉜다
            // * 1.while(언제까지 반복될건지 값이 true면 반복//false가 될때까지 반복)
            // *  {
            // *      반복적으로 실행될 코드
            // *  }
            // * 2.for(몇번 실행할건지에 대한 조건/변수(정수);조건;변수처리{사칙연산, 증감})
            // * {
            // *      반복적으로 실행될 코드
            // * }
            // * 3.do {
            // * 
            // * }while() 기본적으로 while문과 비슷하지만 코드를 무조건 한번은 실행 시킨다.
            // * {
            // *      
            // * }
            // */
            //int count = 1;
            //while (count < 10)
            //{
            //    count++;//count < 10 일때 코드가 실행
            //    Console.WriteLine(count);
            //}
            //Console.WriteLine($"&반복문이 끝났습니다. count는 {count}입니다.");
            //int count = 1;
            //while (true)//무한 루프(무한 루프안에 무한루프를 넣는 것을 기피해야한다.)반복문이 끝나지 않고 계속 실행되는 현상
            //{
            //    Console.WriteLine(count);
            //    count++;
            //    if (count > 10)
            //    {
            //        break;//break;를 만나면 반복문이 종료된다.
            //    }
            //}
            //반복문이 실행될 때 특정 순간에 그냥 스킵하고 싶을때 사용하는 키워드 ==> countinue
            //continue를 만나면 나머지를 실행하지 않고 반복문의 조건을 비교하는 부분으로 스킵한다.
            //int count = 1;
            //while (true)//무한 루프(무한 루프안에 무한루프를 넣는 것을 기피해야한다.)반복문이 끝나지 않고 계속 실행되는 현상
            //{
            //    if (count%2 == 0)
            //    {
            //        count++;
            //        continue;//짝수일 때 아래코드를 스킵한다.
            //    }
            //    Console.WriteLine(count);
            //    count++;
            //    if (count > 100)
            //        break;
            //}
            //do
            //{
            //    Console.WriteLine("Hello World!");//한번은 무조건 실행된다.
            //} while (false);
            //for (int i = 0; i< 10; i+=2)//외부에서 변수를 가져와도 된다.단 변수를 초기화 해줘야한다. 조건에 true를 넣을 경우 무한 루프
            //{
            //    Console.WriteLine(i);//int i를 선언했기때문에 변수i를 사용할 수 있다.but for문 밖에서는 접근할 수 없다.
            //}//break;, continue; 또한 사용 가능

            ///*문제
            // * 구구단
            // * 2부터 9까지의 숫자를 받아 해당하는 구구단을 출력
            // * 예시)
            // * 구구단을 출력할 숫자를 입력하세요.(2~7):
            // * 구구단 7단
            // * 7*1=7
            // * .
            // * .
            // * .
            // * 7*9=63
            // */

            //Console.Write("구구단을 출력할 숫자를 입력하세요.(2~9):");
            //string input=Console.ReadLine();
            //int value=int.Parse(input);
            //Console.WriteLine($"구구단 {value}단");
            ////int output;
            //for (int i = 1; i < 10; i++)
            //{
            //    //output =value * i;
            //    Console.WriteLine($"{value} * {i} = {value*i}");//value*i => output
            //}

            //다중 반복문-반복문안에 반복문을 넣는 것
            //for(int i= 0; i< 5 ; i++){
            //      i변수를 선언한 for문에서 반복적으로 실행할 코드
            //      for(int j=0; j<5; j++){
            //              j변수로 선언한 for문의 반목할 코드
            //          }
            //}

            /*문제
             * 별찍기
             * 1)왼쪽 정렬된 직각 삼각형
             * *
             * **
             * ***
             * ****
             * 2)오른쪽 정렬된 직각 삼각형
             *    *
             *   **
             *  ***
             * ****
             * 3)피라미드
             *   *  
             *  ***
             * *****
             * 3)다이아몬드
             *    *
             *   ***
             *  *****
             *   ***
             *    *
             *  
             */

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();//왼쪽 정렬
            //for (int i = 5; i >= 1; i--)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= (5 - i); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();//오른쪽 정렬

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= (5 - i + 1); j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();//왼쪽 역 정렬
            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= (5 - i + 1); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();//오른쪽 역 정렬

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int l = 1; l <= i + 1; l++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= 5 - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int k = 1; k <= (5 - i + 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();//역피라미드

            //for (int i = 1; i <= 5; i++)
            //{
            //    for (int j = 1; j <= (5 - i + 1); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= i; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int l = 1; l <= i - 1; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();//피라미드
            //int count = 3;
            //int line;
            //line = count / 2;
            //for (int i = 0; i < line; i++)
            //{
            //    for (int j = 0; j < (line - i); j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 0; k <= i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int l = 0; l <= i; l++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < line; i++)
            //{
            //    for (int l = 0; l < i + 2; l++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < line - i - 2; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    for (int k = 0; k < (line - i - 1); k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5 - i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //int count = 31;
            //int line;
            //line = count / 2;
            //for (int i = 1; i <= line; i++)
            //{
            //    for (int j = 0; j < line - i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2 * i - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = 1; i <= line; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j < 2 * (line - i) - 1; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //int line = 6;

            //for (int i = 1; i <= line; i+=2)//i는 별의 갯수
            //{
            //    for (int j = 1; j <= (line-i)/2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //for (int i = line - 2 ; i >= 1; i -=2)//i는 별의 갯수
            //{
            //    for (int j = 1; j <= (line - i) / 2; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}


            //객체 vs 값
            //객체(Object): Class로 부터 생성된 실체(Instance), Class는 설계도(템플릿)이고 실제는 메모리에 생성된 데이터이다.
            //Class: 데이터와 그 데이터와 관련된 데이터를 다루는데 필요한 기능들을 하나의 단위로 묶어서 관리한다.
            //Class를 통해서 생성된 실체를 객체하고 부른다.
            //값 vs 객체의 차이가 중요

            //예) 여러 학생을 관리 학생1:홍길동, 20 학생2:홍길순, 22 ... 여러학생들의 정보를 일일히 변수로 정의해줘야하는 번거로움이 늘어난다.또한 한번에 관리기가 힘듦
            //데이터가 많아질 수록 데이터를 묶어서 관리할 필요성이 생김 이떄 Class를 관리하기 위해 객체라는 개념이 등장
            //Class를 정의 하고 이에 표함될 데이터를 선언 =>feild(필), 프로터티(속성)
            //같은 Class의 데이터라도 각각의 클래스들을 분리하여 관리 => Object(객체), Class로 부터 생성된 실체

            //Class 선언 및 사용
            //Students _student1 = new Students();//새로운 클래스의 실체를 생성
            //_student1.age = 20;
            //_student1.name= "홍길동";//Student에 필요한 데이터들을 가져올 수 있다.
            //Students _student2 = new Students();//새로운 클래스의 실체를 생성
            //_student2.age = 25;
            //_student2.name = "홍길순";
            //Students _student3 = new Students();//새로운 클래스의 실체를 생성
            //_student3.age = 22;
            //_student3.name = "홍길철";

            //값 타입 변수: 변수의 직접 데이터를 저장 예)int a=10, b=a; b=50;
            //메모리: 
            //Number num1 = new Number();//참조 타입 변수
            //num1.Value = 10;//num1.Value에 10을 할당
            //Number num2 = num1;//num1이 가르키는 주소를 num2에 저장
            //num2.Value = 20;//num2가 가르키는 주소= num1이 가르키는 주소이기 때문에 num1.Value 가 20으로 바뀐다.
            //Console.WriteLine(num1.Value);
            //Console.WriteLine(num2.Value);

            //C#에서 제공하는 클래스들
            //1.배열: 같은 타입의 여러 데이터들을 순서대로 저장하기 위한 데이터 구조/클래스는 아니지만 참조형 데이터
            //int[] _Ages = new int[5];//[]:  배열의 인덱스
            //_Ages[0] = 10;
            //_Ages[1] = 20;
            //_Ages[2] = 30;
            //_Ages[3] = 40;
            //_Ages[4] = 50;

            //int[] _Ages2 = _Ages;
            //_Ages2[0] = 60;
            //_Ages2[1] = 7                                                                                     0;

            //for (int i = 0; i < _Ages.Length; i++)
            //{
            //    Console.WriteLine(_Ages[i]);
            //}

            //1부터 10까지 저장되어있는 배열을 선언하고
            //for문으로 배열의 요소들을 모두 더해서 그 결과를 출력하세요
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int sum=0;
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    sum += nums[i];
            //}
            //Console.WriteLine(sum);

            ////Console.WriteLine(nums.Sum());

            ////1~까지 배열의 짝수의 합을 출력
            //sum = 0;
            //for (int i = 0;i < nums.Length; i++)
            //{
            //    if (nums[i]%2==0) {
            //        sum += nums[i];
            //    }
            //}
            //Console.WriteLine(sum);

            //int[] numbers= {5,10,60,45,15,30}에서 최댓값,최솟값 출력

            //int[] numbers = {5,10,60,45,15,30};

            //int max= numbers[0], min=numbers[0];

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (max < numbers[i])
            //    {
            //        max = numbers[i];
            //    }
            //}
            //Console.WriteLine(max);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (min > numbers[i])
            //    {
            //        min = numbers[i];
            //    }
            //}
            //Console.WriteLine(min);

            
            //Console.WriteLine(numbers.Max());
            //Console.WriteLine(numbers.Min());

            //2.List: 가변 배열, 크기가 고정되어 배열과 달리 크기를 동적으로 바꿀 수 있는 배열
            //일반 배열 vs 가변 배열// 일반배열:크기 고정,가변배열:크기가 변할 수 있음

            //List<변수형> 변수명 = new List<변수형>();
            List<int> ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }
            //list를 일반 배열로 변환 가능
            int[] ints1 = ints.ToArray();
            for (int i = 0;i < ints1.Length; i++)
            {
                Console.WriteLine(ints1[i]);
            }

            ints.Remove(3);
            ints.RemoveAt(0);
            for (int i = 0; i < ints.Count; i++)
            {
                Console.WriteLine(ints[i]);
            }

            //List 특정 요소를 포함하고 있는지 확인
            Console.WriteLine($"Is include 2? {ints.Contains(2)}");
            Console.WriteLine($"Is include 2? {ints.Contains(1)}");

            //리스트 정렬
            ints.Add(321);
            ints.Add(542);
            ints.Add(456);
            ints.Add(354);
            ints.Add(457);
            ints.Add(555);
            ints.Add(635);
            ints.Sort();
            for (int i = 0; i < ints.Count; i++)
            {
                Console.Write(ints[i]+" ");
            }

            Solution solution = new Solution();
            solution.solution(ints1 );
        }
        public class Solution
        {
            public int[] solution(int[] numbers)
            {
                int[] answer = new int[] { };
                for (int i = 0; i < numbers.Length; i++)
                {
                    answer[i] = numbers[i]*2;
                }
                return answer;
            }
        }

        //학생 클래스
        //class Students
        //{
        //    public int age;
        //    public string? name;
        //}
        //class Number
        //{
        //    public int Value;
        //}
    }
}