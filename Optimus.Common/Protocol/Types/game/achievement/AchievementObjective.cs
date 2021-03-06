


















// Generated on 10/27/2013 07:41:48
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AchievementObjective
{

public const short Id = 404;
public virtual short TypeId
{
    get { return Id; }
}

public int id;
        public short maxValue;
        

public AchievementObjective()
{
}

public AchievementObjective(int id, short maxValue)
        {
            this.id = id;
            this.maxValue = maxValue;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteInt(id);
            writer.WriteShort(maxValue);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

id = reader.ReadInt();
            if (id < 0)
                throw new Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0");
            maxValue = reader.ReadShort();
            if (maxValue < 0)
                throw new Exception("Forbidden value on maxValue = " + maxValue + ", it doesn't respect the following condition : maxValue < 0");
            

}


}


}