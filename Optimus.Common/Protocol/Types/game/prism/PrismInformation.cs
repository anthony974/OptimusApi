


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class PrismInformation
{

public const short Id = 428;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte typeId;
        public sbyte state;
        public int nextVulnerabilityDate;
        public int placementDate;
        public int rewardTokenCount;
        

public PrismInformation()
{
}

public PrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, int rewardTokenCount)
        {
            this.typeId = typeId;
            this.state = state;
            this.nextVulnerabilityDate = nextVulnerabilityDate;
            this.placementDate = placementDate;
            this.rewardTokenCount = rewardTokenCount;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(typeId);
            writer.WriteSByte(state);
            writer.WriteInt(nextVulnerabilityDate);
            writer.WriteInt(placementDate);
            writer.WriteInt(rewardTokenCount);
            

}

public virtual void Deserialize(BigEndianReader reader)
{

typeId = reader.ReadSByte();
            if (typeId < 0)
                throw new Exception("Forbidden value on typeId = " + typeId + ", it doesn't respect the following condition : typeId < 0");
            state = reader.ReadSByte();
            if (state < 0)
                throw new Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            nextVulnerabilityDate = reader.ReadInt();
            if (nextVulnerabilityDate < 0)
                throw new Exception("Forbidden value on nextVulnerabilityDate = " + nextVulnerabilityDate + ", it doesn't respect the following condition : nextVulnerabilityDate < 0");
            placementDate = reader.ReadInt();
            if (placementDate < 0)
                throw new Exception("Forbidden value on placementDate = " + placementDate + ", it doesn't respect the following condition : placementDate < 0");
            rewardTokenCount = reader.ReadInt();
            if (rewardTokenCount < 0)
                throw new Exception("Forbidden value on rewardTokenCount = " + rewardTokenCount + ", it doesn't respect the following condition : rewardTokenCount < 0");
            

}


}


}