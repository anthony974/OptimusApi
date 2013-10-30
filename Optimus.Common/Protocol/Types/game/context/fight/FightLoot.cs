


















// Generated on 10/27/2013 07:41:49
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class FightLoot
{

public const short Id = 41;
public virtual short TypeId
{
    get { return Id; }
}

public short[] objects;
        public int kamas;
        

public FightLoot()
{
}

public FightLoot(short[] objects, int kamas)
        {
            this.objects = objects;
            this.kamas = kamas;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 writer.WriteShort(entry);
            }
            writer.WriteInt(kamas);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            objects = new short[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = reader.ReadShort();
            }
            kamas = reader.ReadInt();
            if (kamas < 0)
                throw new Exception("Forbidden value on kamas = " + kamas + ", it doesn't respect the following condition : kamas < 0");
            

}


}


}