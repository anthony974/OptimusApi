


















// Generated on 10/27/2013 07:41:40
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class GuildFightPlayersEnemyRemoveMessage : NetworkMessage
{

public const uint Id = 5929;
public override uint MessageId
{
    get { return Id; }
}

public double fightId;
        public int playerId;
        

public GuildFightPlayersEnemyRemoveMessage()
{
}

public GuildFightPlayersEnemyRemoveMessage(double fightId, int playerId)
        {
            this.fightId = fightId;
            this.playerId = playerId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteDouble(fightId);
            writer.WriteInt(playerId);
            

}

public override void Deserialize(BigEndianReader reader)
{

fightId = reader.ReadDouble();
            if (fightId < 0)
                throw new Exception("Forbidden value on fightId = " + fightId + ", it doesn't respect the following condition : fightId < 0");
            playerId = reader.ReadInt();
            if (playerId < 0)
                throw new Exception("Forbidden value on playerId = " + playerId + ", it doesn't respect the following condition : playerId < 0");
            

}


}


}