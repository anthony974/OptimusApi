


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameFightJoinRequestMessage : NetworkMessage
{

public const uint Id = 701;
public override uint MessageId
{
    get { return Id; }
}

public int fighterId;
        public int fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(int fighterId, int fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(fighterId);
            writer.WriteInt(fightId);
            

}

public override void Deserialize(BigEndianReader reader)
{

fighterId = reader.ReadInt();
            fightId = reader.ReadInt();
            

}


}


}