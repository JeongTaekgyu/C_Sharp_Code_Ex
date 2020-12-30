using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(threadFunc);
            t.IsBackground = true;  // 스레드가 실행 종료에 영향을 미치지 않도록 (프로그램은 호출당한 스레드의 실행 여부와 상관없이 종료된다.)
            t.Start();

            //t.Join();   // 인스턴스(t)가 나타내는 스레드가 종료될 때 까지 호출 스레드를 차단한다
                        // ( t 스레드가 종료할 때까지 현재 스레드를 무한 대기 )
            Console.WriteLine("주 스레드 종료");
        }

        static void threadFunc()
        {
            /* 주 스레드에서 스레드 객체의 Start 메서드를 실행했는데 threadFunc에 있는 코드가 실행이 안되는 이유는
                스레드가 CPU에 의해 선택되어 실행될 수 있는 단계까지 시간이 걸리기 때문이다.
                즉, threadFunc을 실행해야할 스레드가 운영체제의 스케줄러에 의해 선택되기도 전에
                Main 메서드를 실행하는 스레드가 종료됐으므로 그런 현상이 발생한 것이다.
            */
            // 이를 해결하기 위해 Join 메서드를 사용하면 된다.
            Console.WriteLine("3초 후 프로그램 종료");
            Thread.Sleep(1000 * 3);
            Console.WriteLine("스레드 종료");
        }
    }
}
