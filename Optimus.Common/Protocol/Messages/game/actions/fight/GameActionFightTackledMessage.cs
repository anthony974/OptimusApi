


















// Generated on 10/27/2013 07:41:27
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GameActionFightTackledMessage : AbstractGameActionMessage
{

public const uint Id = 1004;
public override uint MessageId
{
    get { return Id; }
}

public int[] tacklersIds;
        

public GameActionFightTackledMessage()
{
}

public GameActionFightTackledMessage(short actionId, int sourceId, int[] tacklersIds)
         : base(actionId, sourceId)
        {
            this.tacklersIds = tacklersIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteUShort((ushort)tacklersIds.Length);
            foreach (var entry in tacklersIds)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            var limit = reader.ReadUShort();
            tacklersIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 tacklersIds[i] = reader.ReadInt();
            }
            

}


}


}