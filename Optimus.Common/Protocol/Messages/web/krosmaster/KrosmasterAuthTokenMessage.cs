


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class KrosmasterAuthTokenMessage : NetworkMessage
{

public const uint Id = 6351;
public override uint MessageId
{
    get { return Id; }
}

public string token;
        

public KrosmasterAuthTokenMessage()
{
}

public KrosmasterAuthTokenMessage(string token)
        {
            this.token = token;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUTF(token);
            

}

public override void Deserialize(BigEndianReader reader)
{

token = reader.ReadUTF();
            

}


}


}