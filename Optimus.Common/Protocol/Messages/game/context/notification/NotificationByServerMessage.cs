


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class NotificationByServerMessage : NetworkMessage
{

public const uint Id = 6103;
public override uint MessageId
{
    get { return Id; }
}

public ushort id;
        public string[] parameters;
        public bool forceOpen;
        

public NotificationByServerMessage()
{
}

public NotificationByServerMessage(ushort id, string[] parameters, bool forceOpen)
        {
            this.id = id;
            this.parameters = parameters;
            this.forceOpen = forceOpen;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort(id);
            writer.WriteUShort((ushort)parameters.Length);
            foreach (var entry in parameters)
            {
                 writer.WriteUTF(entry);
            }
            writer.WriteBoolean(forceOpen);
            

}

public override void Deserialize(BigEndianReader reader)
{

id = reader.ReadUShort();
            if (id < 0 || id > 65535)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0 || id > 65535");
            var limit = reader.ReadUShort();
            parameters = new string[limit];
            for (int i = 0; i < limit; i++)
            {
                 parameters[i] = reader.ReadUTF();
            }
            forceOpen = reader.ReadBoolean();
            

}


}


}