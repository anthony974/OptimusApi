


















// Generated on 10/27/2013 07:41:36
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PaddockSellBuyDialogMessage : NetworkMessage
{

public const uint Id = 6018;
public override uint MessageId
{
    get { return Id; }
}

public bool bsell;
        public int ownerId;
        public int price;
        

public PaddockSellBuyDialogMessage()
{
}

public PaddockSellBuyDialogMessage(bool bsell, int ownerId, int price)
        {
            this.bsell = bsell;
            this.ownerId = ownerId;
            this.price = price;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteBoolean(bsell);
            writer.WriteInt(ownerId);
            writer.WriteInt(price);
            

}

public override void Deserialize(BigEndianReader reader)
{

bsell = reader.ReadBoolean();
            ownerId = reader.ReadInt();
            if (ownerId < 0)
                throw new Exception("Forbidden value on ownerId = " + ownerId + ", it doesn't respect the following condition : ownerId < 0");
            price = reader.ReadInt();
            if (price < 0)
                throw new Exception("Forbidden value on price = " + price + ", it doesn't respect the following condition : price < 0");
            

}


}


}