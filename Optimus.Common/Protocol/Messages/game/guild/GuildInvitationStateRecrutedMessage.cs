


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildInvitationStateRecrutedMessage : NetworkMessage
{

public const uint Id = 5548;
public override uint MessageId
{
    get { return Id; }
}

public sbyte invitationState;
        

public GuildInvitationStateRecrutedMessage()
{
}

public GuildInvitationStateRecrutedMessage(sbyte invitationState)
        {
            this.invitationState = invitationState;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(invitationState);
            

}

public override void Deserialize(BigEndianReader reader)
{

invitationState = reader.ReadSByte();
            if (invitationState < 0)
                throw new Exception("Forbidden value on invitationState = " + invitationState + ", it doesn't respect the following condition : invitationState < 0");
            

}


}


}