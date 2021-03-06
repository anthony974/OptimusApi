


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ActorOrientation
{

public const short Id = 353;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        public sbyte direction;
        

public ActorOrientation()
{
}

public ActorOrientation(int id, sbyte direction)
        {
            this.id = id;
            this.direction = direction;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            writer.WriteSByte(direction);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            direction = reader.ReadSByte();
            if (direction < 0)
                throw new Exception("Forbidden value on direction = " + direction + ", it doesn't respect the following condition : direction < 0");
            

}


}


}