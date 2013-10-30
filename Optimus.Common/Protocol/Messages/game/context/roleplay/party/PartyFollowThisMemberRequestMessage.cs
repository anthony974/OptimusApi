


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyFollowThisMemberRequestMessage : PartyFollowMemberRequestMessage
{

public const uint Id = 5588;
public override uint MessageId
{
    get { return Id; }
}

public bool enabled;
        

public PartyFollowThisMemberRequestMessage()
{
}

public PartyFollowThisMemberRequestMessage(int partyId, int playerId, bool enabled)
         : base(partyId, playerId)
        {
            this.enabled = enabled;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteBoolean(enabled);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            enabled = reader.ReadBoolean();
            

}


}


}