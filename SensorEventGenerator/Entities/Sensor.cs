//********************************************************* 
// 
//    Copyright (c) Microsoft. All rights reserved. 
//    This code is licensed under the Microsoft Public License. 
//    THIS CODE IS PROVIDED *AS IS* WITHOUT WARRANTY OF 
//    ANY KIND, EITHER EXPRESS OR IMPLIED, INCLUDING ANY 
//    IMPLIED WARRANTIES OF FITNESS FOR A PARTICULAR 
//    PURPOSE, MERCHANTABILITY, OR NON-INFRINGEMENT. 
// 
//********************************************************* 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;
using Newtonsoft.Json;

namespace FundCodeGenerator
{

    public class FundCode
    {
        public int id = 0;
        public string DateCreated;
        public string Fundcode;
        public int MemberNumber;



        static Random R = new Random();
        static string[] Fundcodes = new[] {"Fund01","Fund02","Fund03","Fund04","Fund05","Fund06","Fund07","Fund08","Fund09","Fund10", "Fund11", "Fund12", "Fund13", "Fund14", "Fund15", "Fund16", "Fund17", "Fund18", "Fund19", "Fund20", "Fund21", "Fund22", "Fund23", "Fund24", "Fund25", "Fund26", "Fund27", "Fund28", "Fund29", "Fund30" };
        static int identity = 0;


        public static FundCode Generate()
        {
            identity = identity + 1;
            return new FundCode { id = identity, DateCreated = DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss.fffffffK"), Fundcode = Fundcodes[R.Next(Fundcodes.Length)], MemberNumber = R.Next(1, 10000) };
        }

    }
}
