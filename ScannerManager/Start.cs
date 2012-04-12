using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Start
{
    public bool working;
    public Start(string port)
    {
        working = true;
        string clientip = "";
        string clientPath = "";
        DataReceive1 dr = new DataReceive1(port);
        DataReceive1 dr2 = new DataReceive1(port);
        clientip = dr.getData();
        clientPath = dr2.getData();
        //Console.WriteLine(dr.getData() + " and " + dr2.getData());
        FileHelper fh = new FileHelper();
        String final = "\\" + "\\" + clientip +  clientPath.Remove(0, 2);
        //Console.WriteLine(final);
        fh.GetFileRecursive(final);
        List<string> dirs = fh.getFiles();
        Queue<string> temp = new Queue<string>();
        foreach (string di in dirs)
        {
            temp.Enqueue(di);
            Console.WriteLine(di);

        }
        foreach (string di in dirs)
        {
            

            while (StackIpaddress.ScannerClerkIpAddress.Count == 0) ;

            string ipaddress = StackIpaddress.ScannerClerkIpAddress.Dequeue();
            //Console.WriteLine(ipaddress);
            //Console.WriteLine(Static_Lock.lockCondition1 + (Convert.ToInt32(port) + 1).ToString());
            //Console.WriteLine("DataSending ENd"+ipaddress);
            DataSend ds = new DataSend(ipaddress, (Convert.ToInt32(port) + 1).ToString());
            ds.sendData(di);
            //Console.WriteLine("DataSending END...");
            //Console.WriteLine(StackIpaddress.ScannerClerkIpAddress.Count.ToString()) ;
        }
        working = false;
    }
}