using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using static ConsoleApp2.Program;

namespace ConsoleApp2
{
    internal class Program
    {
        // 마트 계산기 프로그램
        // 핵심 기능 :
        // 1, 상품(상품 이름, 설명) 등록
        // 2, 장바구니에 상품 추가
        // 3, 총액 계산
        // 4, 할인 적용(ref/out 사용)
        // 5, 제네릭 계산기 사용(합계)

        // 요구 사항
        // 1, Product Class
        //      - 상품 
        //      - 상품 설명
        // 2, Cart Class(Generic)
        //      - 상품 리스트
        // 3, static을 활용한 계산기 로직 구현 
        //      - 할인 계산
        //      - 총액 계산

        // 기본 로직
        // 사과, 우유, 식빵 상품을 생성
        // 사용자가 사과, 우유, 식빵 중 선택해서 Cart에 담기
        // 연관 회원인지 확인
        // 총 가격에서 10% 할인
        // 지불해야 할 비용 출력

        // 출력 예시
        //
        // 안녕하세요 마트에 오신걸 환영합니다.
        // 현재 상품은 사과, 우유, 식빵이 있습니다.
        // 어떤 상품을 고르시겠습니까? (1) 사과 , (2) 우유, (3) 식빵 , (0) 쇼핑 종료 : 1
        // 어떤 상품을 고르시겠습니까? (1) 사과 , (2) 우유, (3) 식빵 , (0) 쇼핑 종료 : 2
        // 어떤 상품을 고르시겠습니까? (1) 사과 , (2) 우유, (3) 식빵 , (0) 쇼핑 종료 : 0
        // 쇼핑이 종료됬습니다. 선택한 상품 수는 2개입니다.
        // 연간 회원이십니까? : Yes
        // 연간 회원 10% 할인이 적용되었습니다.
        // (연간 회원이면) 총 지불해야하는 가격은 10% 할인이 적용된 {} 입니다.
        // (연간 회원이 아니면) 총 지불해야하는 가격은 {} 입니다.

        public class Product
        {
            private string name;
            private string description;
            public int price;

            public Product(string name, string description, int price)
            {
                this.name = name;
                this.description = description;
                this.price = price;
            }
        }
        public class Cart<Product>
        {
            public List<Product> products = new List<Product>();    
            public void AddProduct(Product products)
            {
                this.products.Add(products);
            }
            public int count => products.Count;
        }

        public static class Calculate
        {
            public static int TotalPrice(List<Product> products)
            {
                int total = 0;
                foreach (Product product in products)
                {
                    total += product.price;
                }
                return total;
            }
            public static void Mem(ref int total, out int Finalprice, double discountrate)
            {
                Finalprice = (int)(total * (1 - discountrate));
            }
        }
        static void Main(string[] args)
        {
            // 상품 등록
            Product apple = new Product("사과", "신선한 사과입니다.", 990);
            Product milk = new Product("우유", "고칼슘 우유입니다.", 2000);
            Product bread = new Product("식빵", "갓 구운 식빵입니다.", 1500);

            List<Product> productList = new List<Product> { apple, milk, bread };
            Cart<Product> cart = new Cart<Product>();

            Console.WriteLine("안녕하세요 마트에 오신걸 환영합니다.");
            Console.WriteLine("현재 상품은 사과, 우유, 식빵이 있습니다.");

            while (true)
            {
                Console.Write("어떤 상품을 고르시겠습니까? (1) 사과 , (2) 우유, (3) 식빵 , (0) 쇼핑 종료 : ");
                string input = Console.ReadLine();

                if (input == "0")
                    break;

                switch (input)
                {
                    case "1":
                        cart.AddProduct(apple);
                        break;
                    case "2":
                        cart.AddProduct(milk);
                        break;
                    case "3":
                        cart.AddProduct(bread);
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다.");
                        break;
                }
            }

            Console.WriteLine($"쇼핑이 종료되었습니다. 선택한 상품 수는 {cart.count}개입니다.");

            // 연간 회원 여부 확인
            Console.Write("연간 회원이십니까? (Yes/No) : ");
            string isMember = Console.ReadLine();

            int total = Calculate.TotalPrice(cart.products);  // 총액 계산
            int finalPrice;
            if (isMember.ToLower() == "yes")
            {
                // 할인 적용
                Calculate.Mem(ref total, out finalPrice, 0.1);
                Console.WriteLine("연간 회원 10% 할인이 적용되었습니다.");
                Console.WriteLine($"총 지불해야하는 가격은 {finalPrice:N2}원 입니다.");
            }
            else
            {
                Console.WriteLine($"총 지불해야하는 가격은 {total}원 입니다.");
            }

        }
    }
}