


















// Generated on 10/27/2013 07:41:34
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class HouseKickRequestMessage : NetworkMessage
{

public const uint Id = 5698;
public override uint MessageId
{
    get { return Id; }
}

public int id;
        

public HouseKickRequestMessage()
{
}

public HouseKickRequestMessage(int id)
        {
            this.id = id;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            

}


}


}