


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class DungeonPartyFinderRoomContentUpdateMessage : NetworkMessage
{

public const uint Id = 6250;
public override uint MessageId
{
    get { return Id; }
}

public short dungeonId;
        public Types.DungeonPartyFinderPlayer[] addedPlayers;
        public int[] removedPlayersIds;
        

public DungeonPartyFinderRoomContentUpdateMessage()
{
}

public DungeonPartyFinderRoomContentUpdateMessage(short dungeonId, Types.DungeonPartyFinderPlayer[] addedPlayers, int[] removedPlayersIds)
        {
            this.dungeonId = dungeonId;
            this.addedPlayers = addedPlayers;
            this.removedPlayersIds = removedPlayersIds;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(dungeonId);
            writer.WriteUShort((ushort)addedPlayers.Length);
            foreach (var entry in addedPlayers)
            {
                 entry.Serialize(writer);
            }
            writer.WriteUShort((ushort)removedPlayersIds.Length);
            foreach (var entry in removedPlayersIds)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

dungeonId = reader.ReadShort();
            if (dungeonId < 0)
                throw new Exception("Forbidden value on dungeonId = " + dungeonId + ", it doesn't respect the following condition : dungeonId < 0");
            var limit = reader.ReadUShort();
            addedPlayers = new Types.DungeonPartyFinderPlayer[limit];
            for (int i = 0; i < limit; i++)
            {
                 addedPlayers[i] = new Types.DungeonPartyFinderPlayer();
                 addedPlayers[i].Deserialize(reader);
            }
            limit = reader.ReadUShort();
            removedPlayersIds = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 removedPlayersIds[i] = reader.ReadInt();
            }
            

}


}


}