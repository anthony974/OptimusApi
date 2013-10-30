


















// Generated on 10/27/2013 07:41:39
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildMemberSetWarnOnConnectionMessage : NetworkMessage
{

public const uint Id = 6159;
public override uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public GuildMemberSetWarnOnConnectionMessage()
{
}

public GuildMemberSetWarnOnConnectionMessage(bool enable)
        {
            this.enable = enable;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(enable);
            

}

public override void Deserialize(BigEndianReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}