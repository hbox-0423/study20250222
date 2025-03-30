using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        // TRPG 게임
        // Player Class : 플레이어 캐릭터
        // Monster Class : 몬스터 캐릭터

        // 모든 캐릭터는 기본적으로 체력과 공격력을 가지고 있습니다.
        // 모든 캐릭터는 공격을 하거나 방어를 할 수 있습니다.
        // 공격을 할 때 상대방이 방어를 하면 데미지를 받지 않습니다.

        // 플레이어랑 캐릭터가 전투를 하는 로직을 구현한다. 
        // 플레이어는 1, 공격, 2, 방어
        // 적의 모든 행동(공격, 방어)은 다 랜덤으로 한다.

        //클래스의 상속성
        //한 클래스의 속성과 메서그를 다른 클래스가 상속받용할 수 있게하는 특징

        //클래스의 다형성
        //같은 인터페이스나 메서드 호출이 서로 다은 객테 타입(class)에 대해 서로 다른 동작을 할 수 있게 해준다.
        //메서드 오버라이팅 : 상속관계에 있는 클래스에서 부모 클래스에 정의된 메서드를 자식 클래스에서 재정의
        //virtual : 부모 클래스에 선언된 메서드를 자식 클래스에서 재정의 할 수 있도록 해주는 키워드

        class Character//플레이어와 몬스터 모두 공통적으로 사용하는 메서드나 필드를 가진 클래스
                       //=> 부모 클래스, 슈터 클래스  |  Player, Monster 클래스 => 자식 클래스, 서브 클래스
                       //Player, Monster 클래스에서 Character라는 부모 클래스의 메서드와 필드를 (사용)상속받는다
        {//플레이어, 몬스터 둘다 사용할 필드, 메서드
         //private는 상속받는 class도 접근이 안된다.protected는 상속받는 class도 접근이 가능하다.
            protected int health; // 체력
            protected int attack; // 공격력

            protected bool isDefence;//방어 여부

            //name 필드를 선언
            protected string name;
            //방어하는 메서드
            public void Defence()
            {
                //해당 class에 선언된 name으로 출력
                Console.WriteLine($"{name}이/가 방어합니다.");
                isDefence = true;
            }
            // 데미지를 받는 메서드
            public virtual void isAttacked(int amount)
            {
                if (isDefence)
                {
                    isDefence = false;
                }
                else
                    health -= amount;

            }
            // => 상대방이 공격력을 넘겨주면
            // 내가 방어하고 있는지 아닌지를 판단해서
            // 체력을 깍는다.
            public void resetDefence()
            {
                isDefence = false;
            }
            public int isHealth()
            {
                return health;
            }
        }
        class Player : Character//=> Player 는 Character 클래스를 상속받는다
        {

            public Player(string initialname, int initialhealth,int initialattack,bool initialisDefence)
            {
                name = initialname;
                health = initialhealth;
                attack = initialattack;
                isDefence = initialisDefence;
            }
            // 공격하는 메서드
            public void Attack(Monster monster)
            {
                Console.WriteLine("몬스터를 공격했습니다.");
                if (!isDefence)
                    monster.isAttacked(attack);
            }
            //player는 데미지를 받을 때마다 50%로 공격력 2배
            public override void isAttacked(int amount)
            {
                base.isAttacked(amount);//부모 계층을 의미//Character class의 isAttacked의 메서드 로직
                //확률 계산
                Random rand = new Random();
                int random = rand.Next(0,100);
                if (random < 50)
                {
                    attack += 5;
                    Console.WriteLine($"{name}특성 활성화 | 공격력 5 증가");
                }
            }
            //~Player()
            //{
            //    //리소스 정리
            //}

        }

        class Monster : Character
        {
            
            public Monster(string initialname, int initialhelth,int initialattack,bool initialisDefense)
            {
                name = initialname;
                health = initialhelth;
                attack = initialattack;
                isDefence = initialisDefense;
            }
            // 공격하는 메서드
            public void Attack(Player player)
            {
                Console.WriteLine("몬스터가 공격했습니다.");
                if (!isDefence)
                    player.isAttacked(attack);
            }
            //데미지를 받을때마다 30%로 체력을 50씩 회복
            public override void isAttacked(int amount)
            {
                base.isAttacked(amount);//부모 계층을 의미//Character class의 isAttacked의 메서드 로직Random rand = new Random();
                Random rand = new Random();
                int random = rand.Next(0, 100);
                if (random < 30)
                {
                    health += 50;
                    Console.WriteLine($"{name}특성 활성화 | 체력 50 회복");
                }
            }
        }

        static void Main(string[] args)
        {
            // 플레이어의 초기 스텟을 설정
            Player player = new Player("플레이어",100,10,false);

            // 몬스터의 초기 스텟을 설정
            Monster monster = new Monster("고블린",75,10,false);

            // 전투 시작
            Console.WriteLine("야생의 고블린이 나타났습니다.");
            Console.WriteLine("전투를 시작합니다.");

            Console.WriteLine($"플레이어 체력 : {player.isHealth()}  |  몬스터 체력 : {monster.isHealth()}");

            // 몬스터 혹은 플레이어 둘다 살아 있는 동안에는 계속 전투를 한다.
            while (monster.isHealth() > 0 && player.isHealth() > 0)
            {
                Random rand = new Random();

                int monsterAction = rand.Next(1, 3);// 1 혹은 2

                Console.Write("\n플레이어 턴입니다. 행동을 선택하세요(1번 공격, 2번 방어) : ");
                string input = Console.ReadLine();
                int choice = int.Parse(input);

                if (choice == 2)
                {
                    player.Defence();
                }
                if (monsterAction == 2)
                {
                    monster.Defence();
                }

                // 공격 로직를 실행한다.
                if (choice == 1)
                {
                    // 공격 메소드 실행
                    player.Attack(monster);
                }
                if (monsterAction == 1)
                {
                    monster.Attack(player);
                }


                player.resetDefence();
                monster.resetDefence();
                
                Console.WriteLine($"플레이어 체력 : {player.isHealth()}  |  몬스터 체력 : {monster.isHealth()}");
            }
            if (monster.isHealth() <= 0)
            {
                Console.WriteLine("\n플레이어가 승리했습니다.");
            }
            else if (player.isHealth() <= 0)
            {
                Console.WriteLine("\n플레이어가 패배했습니다.");
            }
        }
        //클래스의 생성자와 소멸자
        //클래스의 생성자 : 클래스의 인스턴스(객체)가 생성될 때 자동우로 호출되는 메서드
        //생성자의 주된 목적은 객체의 초기화, 즉 필드의 초기값을 설정

        //클래스의 소멸자(C#에서는 가비지 컬렉터가 있어서 리소스를 자동으로 절리하기 때문에 직접작성할 필요 x)
        // : 객체가 더이상 필요 없어 메모리에서 해제될 때 자동으로 호출되는 메서드
        //소멸자의 주된 목적은 사용한 리소스를 정리(파일 닫기, 네트워크 연결 해제...)
    }
}
