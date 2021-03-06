


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class OrnamentSelectErrorMessage : NetworkMessage
{

public const uint Id = 6370;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        

public OrnamentSelectErrorMessage()
{
}

public OrnamentSelectErrorMessage(sbyte reason)
        {
            this.reason = reason;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(reason);
            

}

public override void Deserialize(BigEndianReader reader)
{

reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            

}


}


}