


















// Generated on 10/27/2013 07:41:38
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class SpellForgetUIMessage : NetworkMessage
{

public const uint Id = 5565;
public override uint MessageId
{
    get { return Id; }
}

public bool open;
        

public SpellForgetUIMessage()
{
}

public SpellForgetUIMessage(bool open)
        {
            this.open = open;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(open);
            

}

public override void Deserialize(BigEndianReader reader)
{

open = reader.ReadBoolean();
            

}


}


}