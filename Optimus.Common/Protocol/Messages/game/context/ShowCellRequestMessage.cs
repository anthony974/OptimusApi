


















// Generated on 10/27/2013 07:41:31
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ShowCellRequestMessage : NetworkMessage
{

public const uint Id = 5611;
public override uint MessageId
{
    get { return Id; }
}

public short cellId;
        

public ShowCellRequestMessage()
{
}

public ShowCellRequestMessage(short cellId)
        {
            this.cellId = cellId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(cellId);
            

}

public override void Deserialize(BigEndianReader reader)
{

cellId = reader.ReadShort();
            if (cellId < 0 || cellId > 559)
                throw new Exception("Forbidden value on cellId = " + cellId + ", it doesn't respect the following condition : cellId < 0 || cellId > 559");
            

}


}


}