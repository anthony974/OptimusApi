


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class NumericWhoIsRequestMessage : NetworkMessage
{

public const uint Id = 6298;
public override uint MessageId
{
    get { return Id; }
}

public int playerId;
        

public NumericWhoIsRequestMessage()
{
}

public NumericWhoIsRequestMessage(int playerId)
        {
            this.playerId = playerId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(playerId);
            

}

public override void Deserialize(BigEndianReader reader)
{

playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}