


















// Generated on 10/27/2013 07:41:29
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SequenceNumberMessage : NetworkMessage
{

public const uint Id = 6317;
public override uint MessageId
{
    get { return Id; }
}

public ushort number;
        

public SequenceNumberMessage()
{
}

public SequenceNumberMessage(ushort number)
        {
            this.number = number;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort(number);
            

}

public override void Deserialize(BigEndianReader reader)
{

number = reader.ReadUShort();
            if (number < 0 || number > 65535)
                throw new Exception("Forbidden value on number = " + number + ", it doesn't respect the following condition : number < 0 || number > 65535");
            

}


}


}