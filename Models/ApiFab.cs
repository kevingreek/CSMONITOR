﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;

namespace csmon.Models
{
    public static class ApiFab
    {
        public static NodeApi.API.Client CreateNodeApi(string addr)
        {
            TTransport transport = new TSocket(addr, 9090, 60000);
            TProtocol protocol = new TBinaryProtocol(transport);
            var client = new NodeApi.API.Client(protocol);
            transport.Open();
            return client;
        }

        public static ServerApi.API.Client CreateSignalApi(string addr)
        {
            TTransport transport = new TSocket(addr, 8080, 20000);
            TProtocol protocol = new TBinaryProtocol(transport);
            var client = new ServerApi.API.Client(protocol);
            transport.Open();
            return client;
        }

    }
}
