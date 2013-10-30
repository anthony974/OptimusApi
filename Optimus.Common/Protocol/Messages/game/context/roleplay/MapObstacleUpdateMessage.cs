


















// Generated on 10/27/2013 07:41:33
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class MapObstacleUpdateMessage : NetworkMessage
{

public const uint Id = 6051;
public override uint MessageId
{
    get { return Id; }
}

public Types.MapObstacle[] obstacles;
        

public MapObstacleUpdateMessage()
{
}

public MapObstacleUpdateMessage(Types.MapObstacle[] obstacles)
        {
            this.obstacles = obstacles;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)obstacles.Length);
            foreach (var entry in obstacles)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            obstacles = new Types.MapObstacle[limit];
            for (int i = 0; i < limit; i++)
            {
                 obstacles[i] = new Types.MapObstacle();
                 obstacles[i].Deserialize(reader);
            }
            

}


}


}