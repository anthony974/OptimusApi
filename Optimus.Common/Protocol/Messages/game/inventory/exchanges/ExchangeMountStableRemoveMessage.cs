


















// Generated on 10/27/2013 07:41:42
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ExchangeMountStableRemoveMessage : NetworkMessage
{

public const uint Id = 5964;
public override uint MessageId
{
    get { return Id; }
}

public double mountId;
        

public ExchangeMountStableRemoveMessage()
{
}

public ExchangeMountStableRemoveMessage(double mountId)
        {
            this.mountId = mountId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteDouble(mountId);
            

}

public override void Deserialize(BigEndianReader reader)
{

mountId = reader.ReadDouble();
            

}


}


}