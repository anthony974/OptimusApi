


















// Generated on 10/27/2013 07:41:52
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class ObjectEffectDuration : ObjectEffect
{

public const short Id = 75;
public override short TypeId
{
    get { return Id; }
}

public short days;
        public short hours;
        public short minutes;
        

public ObjectEffectDuration()
{
}

public ObjectEffectDuration(short actionId, short days, short hours, short minutes)
         : base(actionId)
        {
            this.days = days;
            this.hours = hours;
            this.minutes = minutes;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteShort(days);
            writer.WriteShort(hours);
            writer.WriteShort(minutes);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            days = reader.ReadShort();
            if (days < 0)
                throw new Exception("Forbidden value on days = " + days + ", it doesn't respect the following condition : days < 0");
            hours = reader.ReadShort();
            if (hours < 0)
                throw new Exception("Forbidden value on hours = " + hours + ", it doesn't respect the following condition : hours < 0");
            minutes = reader.ReadShort();
            if (minutes < 0)
                throw new Exception("Forbidden value on minutes = " + minutes + ", it doesn't respect the following condition : minutes < 0");
            

}


}


}