


















// Generated on 10/27/2013 07:41:41
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class TeleportBuddiesRequestedMessage : NetworkMessage
{

public const uint Id = 6302;
public override uint MessageId
{
    get { return Id; }
}

public short dungeonId;
        public int inviterId;
        public int[] invalidBuddiesIds;
        

public TeleportBuddiesRequestedMessage()
{
}

public TeleportBuddiesRequestedMessage(short dungeonId, int inviterId, int[] invalidBuddiesIds)
        {
            this.dungeonId = dungeonId;
            this.inviterId = inviterId;
            this.invalidBuddiesIds = invalidBuddiesIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(dungeonId);
            writer.WriteInt(inviterId);
            writer.WriteUShort((ushort)invalidBuddiesIds.Length);
            foreach (var entry in invalidBuddiesIds)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

dungeonId = reader.ReadShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            inviterId = reader.ReadInt();
            if (inviterId < 0)
                throw new Exception("Forbidden value on inviterId = " + inviterId + ", it doesn't respect the following condition : inviterId < 0");
            var limit = reader.ReadUShort();
            invalidBuddiesIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 invalidBuddiesIds[i] = reader.ReadInt();
            }
            

}


}


}