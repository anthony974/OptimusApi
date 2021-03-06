


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MailStatusMessage : NetworkMessage
{

public const uint Id = 6275;
public override uint MessageId
{
    get { return Id; }
}

public short unread;
        public short total;
        

public MailStatusMessage()
{
}

public MailStatusMessage(short unread, short total)
        {
            this.unread = unread;
            this.total = total;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(unread);
            writer.WriteShort(total);
            

}

public override void Deserialize(BigEndianReader reader)
{

unread = reader.ReadShort();
            if (unread < 0)
                throw new Exception("Forbidden value on unread = " + unread + ", it doesn't respect the following condition : unread < 0");
            total = reader.ReadShort();
            if (total < 0)
                throw new Exception("Forbidden value on total = " + total + ", it doesn't respect the following condition : total < 0");
            

}


}


}