


















// Generated on 10/27/2013 07:41:45
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ObjectFeedMessage : NetworkMessage
{

public const uint Id = 6290;
public override uint MessageId
{
    get { return Id; }
}

public int objectUID;
        public int foodUID;
        public short foodQuantity;
        

public ObjectFeedMessage()
{
}

public ObjectFeedMessage(int objectUID, int foodUID, short foodQuantity)
        {
            this.objectUID = objectUID;
            this.foodUID = foodUID;
            this.foodQuantity = foodQuantity;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(objectUID);
            writer.WriteInt(foodUID);
            writer.WriteShort(foodQuantity);
            

}

public override void Deserialize(BigEndianReader reader)
{

objectUID = reader.ReadInt();
            if (objectUID < 0)
                throw new Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            foodUID = reader.ReadInt();
            if (foodUID < 0)
                throw new Exception("Forbidden value on foodUID = " + foodUID + ", it doesn't respect the following condition : foodUID < 0");
            foodQuantity = reader.ReadShort();
            if (foodQuantity < 0)
                throw new Exception("Forbidden value on foodQuantity = " + foodQuantity + ", it doesn't respect the following condition : foodQuantity < 0");
            

}


}


}