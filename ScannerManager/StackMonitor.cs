using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class StackMonitor
{  

    internal System.Threading.ThreadStart Monitor(string port)
    {
        //throw new NotImplementedException();
       
        while (true)
        {
            DataReceive dr = new DataReceive(port);
            string ipaddress = dr.ipaddress;
            //Console.WriteLine("ipaddress"+ipaddress);
            //Console.WriteLine("enqueueing");
            StackIpaddress.ScannerClerkIpAddress.Enqueue(ipaddress);
            //Console.WriteLine(StackIpaddress.ScannerClerkIpAddress.Peek()+"enqueued");
            
            

        }
    }
}
