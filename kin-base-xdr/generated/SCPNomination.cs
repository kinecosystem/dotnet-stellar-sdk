// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten

using System;

namespace Kin.Base.xdr
{
// === xdr source ============================================================
//  struct SCPNomination
//  {
//      Hash quorumSetHash; // D
//      Value votes<>;      // X
//      Value accepted<>;   // Y
//  };
//  ===========================================================================
    public class SCPNomination
    {
        public SCPNomination()
        {
        }

        public Hash QuorumSetHash { get; set; }
        public Value[] Votes { get; set; }
        public Value[] Accepted { get; set; }

        public static void Encode(XdrDataOutputStream stream, SCPNomination encodedSCPNomination)
        {
            Hash.Encode(stream, encodedSCPNomination.QuorumSetHash);
            int votessize = encodedSCPNomination.Votes.Length;
            stream.WriteInt(votessize);
            for (int i = 0; i < votessize; i++)
            {
                Value.Encode(stream, encodedSCPNomination.Votes[i]);
            }

            int acceptedsize = encodedSCPNomination.Accepted.Length;
            stream.WriteInt(acceptedsize);
            for (int i = 0; i < acceptedsize; i++)
            {
                Value.Encode(stream, encodedSCPNomination.Accepted[i]);
            }
        }

        public static SCPNomination Decode(XdrDataInputStream stream)
        {
            SCPNomination decodedSCPNomination = new SCPNomination();
            decodedSCPNomination.QuorumSetHash = Hash.Decode(stream);
            int votessize = stream.ReadInt();
            decodedSCPNomination.Votes = new Value[votessize];
            for (int i = 0; i < votessize; i++)
            {
                decodedSCPNomination.Votes[i] = Value.Decode(stream);
            }

            int acceptedsize = stream.ReadInt();
            decodedSCPNomination.Accepted = new Value[acceptedsize];
            for (int i = 0; i < acceptedsize; i++)
            {
                decodedSCPNomination.Accepted[i] = Value.Decode(stream);
            }

            return decodedSCPNomination;
        }
    }
}
