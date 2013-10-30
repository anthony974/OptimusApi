


















// Generated on 10/27/2013 07:41:26
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightDispellMessage : AbstractGameActionMessage
{

public const uint Id = 5533;
public override uint MessageId
{
    get { return Id; }
}

public int targetId;
        

public GameActionFightDispellMessage()
{
}

public GameActionFightDispellMessage(short actionId, int sourceId, int targetId)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteInt(targetId);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadInt();
            

}


}


}