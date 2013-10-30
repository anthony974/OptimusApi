


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class InteractiveUseEndedMessage : NetworkMessage
{

public const uint Id = 6112;
public override uint MessageId
{
    get { return Id; }
}

public int elemId;
        public short skillId;
        

public InteractiveUseEndedMessage()
{
}

public InteractiveUseEndedMessage(int elemId, short skillId)
        {
            this.elemId = elemId;
            this.skillId = skillId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(elemId);
            writer.WriteShort(skillId);
            

}

public override void Deserialize(BigEndianReader reader)
{

elemId = reader.ReadInt();
            if (elemId < 0)
                throw new Exception("Forbidden value on elemId = " + elemId + ", it doesn't respect the following condition : elemId < 0");
            skillId = reader.ReadShort();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}