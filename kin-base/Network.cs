// This file was modified by Kin Ecosystem (2019)


using System;
using System.Text;

namespace Kin.Base
{
    public class Network
    {
        public const string PublicPassphrase = "Kin Mainnet ; December 2018";
        public const string TestnetPassphrase = "Kin Testnet ; December 2018";

        public Network(string networkPassphrase)
        {
            NetworkPassphrase = networkPassphrase ?? throw new ArgumentNullException(nameof(networkPassphrase), "networkPassphrase cannot be null");
        }

        public string NetworkPassphrase { get; }

        public byte[] NetworkId => Util.Hash(Encoding.UTF8.GetBytes(NetworkPassphrase));

        public static Network Current { get; private set; }

        public static Network Public()
        {
            return new Network(PublicPassphrase);
        }

        public static Network Test()
        {
            return new Network(TestnetPassphrase);
        }

        public static void Use(Network network)
        {
            Current = network;
        }

        public static bool IsPublicNetwork(Network network)
        {
            return network.NetworkPassphrase == PublicPassphrase;
        }

        public static void UsePublicNetwork()
        {
            Use(Public());
        }

        public static void UseTestNetwork()
        {
            Use(Test());
        }
    }
}
