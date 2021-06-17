using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp4;

namespace ConsoleApp4
{
    class Program
    {
        async static void AsynFunciton()
        {
            await Task.Delay(1);
            Console.WriteLine("异步");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("异步" + i);
            }
        }

        //List<UserModel> UserList { get; set; } = new List<UserModel>();
        private List<UserModel> _userlist;

        public List<UserModel> UserList
        {
            get { return _userlist; }
            set { _userlist = value; }
        }

        public Program()
        {
            UserList = new List<UserModel>();
            UserList.Add(new UserModel {ID="1",LOGIN_NAME="zhiyi" });
            UserList.Add(new UserModel {ID="2",LOGIN_NAME="wang" });
            UserList.Add(new UserModel {ID="3",LOGIN_NAME="wei" });
        }


        static  void Main(string[] args)
        {
            string ct = "1";
            string test= ct == "-1" ? " " : "test";
            Console.WriteLine(test);

            Program pro = new Program();
            if(pro.UserList.Any(u => u.ID=="3"))
                Console.WriteLine("已经有3");

            ///List的微软示例
            List<string> dinosaurs = new List<string>();
            dinosaurs.Add("Tyrannosaurus");
            dinosaurs.Add("Amargasaurus");
            dinosaurs.Add("Mamenchisaurus");
            dinosaurs.Add("Deinonychus");
            dinosaurs.Add("Compsognathus");

            Console.WriteLine("\nCapacity: {0}", dinosaurs.Capacity);
            Console.WriteLine("Count: {0}", dinosaurs.Count);
            Console.WriteLine("\nContains(\"Deinonychus\"): {0}",dinosaurs.Contains("Deinonychus"));
            dinosaurs.Insert(2, "Compsognathus");
            foreach (string dinosaur in dinosaurs)
            {
                Console.WriteLine(dinosaur);
            }

            DateTime NextTime = DateTime.Now;
            Console.WriteLine(NextTime.ToShortDateString());

            int x = 3;
            int y = x == 3 ? 1 : 2;
            Console.WriteLine($"现在y={y}");

            Action<string> say = SayHello;
            say("Action Hello");

            Action<string> action = s => Console.WriteLine(s);
            action("Lambda Action");

            Task t = new Task(()=> {
                Console.WriteLine("任务开始。。。");
                Thread.Sleep(1000);
            });

            t.Start();
            t.ContinueWith((task)=> {
                Console.WriteLine($"任务完成，IsCanceled={task.IsCanceled},IsCompleted={task.IsCompleted},IsFaulted={task.IsFaulted}");
            });


            var t3=Task.Factory.StartNew(() => {
                Thread.Sleep(1000);
                Console.WriteLine("任务3 Task3");
            });
            Task.WaitAll(t3);

            AsynFunciton();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            DateTime LastTime = DateTime.Now;
            Console.WriteLine(LastTime);

            Console.Read();
        }


        private static void SayHello(string obj)
        {
            Console.WriteLine(obj);
        }


    }
}
