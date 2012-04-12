using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ScannerManager
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Console.WriteLine("working");

            //StackMonitor sm = new StackMonitor();
            //Thread t1 = new Thread(sm.Monitor("11000"));
            Program p = new Program();
            Thread thread = new Thread(new ThreadStart(p.WorkThreadFunction));
            thread.Start();
            //Console.WriteLine("thread going to start");
            //t1.Start();
            //Console.WriteLine("starting acept");

            Thread threadStart = new Thread(new ThreadStart(p.start));
            threadStart.Start();
            
            
          
         }
        void WorkThreadFunction()
        {
            while (true)
            {
                DataReceive dr = new DataReceive("11000");
                string ipaddress = dr.ipaddress;
                //Console.WriteLine(ipaddress);
                StackIpaddress.ScannerClerkIpAddress.Enqueue(ipaddress);


                //Console.WriteLine(StackIpaddress.ScannerClerkIpAddress.Peek() + "enqueued");
            }
        }
        void start()
        {
            while (true)
            {
                Start s = new Start("10000");
                while (s.working == true) ;
            }
        }
       
    }
}
