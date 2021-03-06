


















// Generated on 10/27/2013 07:41:44
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeStartOkMulticraftCrafterMessage : NetworkMessage
{

public const uint Id = 5818;
public override uint MessageId
{
    get { return Id; }
}

public sbyte maxCase;
        public int skillId;
        

public ExchangeStartOkMulticraftCrafterMessage()
{
}

public ExchangeStartOkMulticraftCrafterMessage(sbyte maxCase, int skillId)
        {
            this.maxCase = maxCase;
            this.skillId = skillId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(maxCase);
            writer.WriteInt(skillId);
            

}

public override void Deserialize(BigEndianReader reader)
{

maxCase = reader.ReadSByte();
            if (maxCase < 0)
                throw new Exception("Forbidden value on maxCase = " + maxCase + ", it doesn't respect the following condition : maxCase < 0");
            skillId = reader.ReadInt();
            if (skillId < 0)
                throw new Exception("Forbidden value on skillId = " + skillId + ", it doesn't respect the following condition : skillId < 0");
            

}


}


}