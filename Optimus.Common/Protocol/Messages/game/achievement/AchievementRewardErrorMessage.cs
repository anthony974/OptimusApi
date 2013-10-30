


















// Generated on 10/27/2013 07:41:25
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class AchievementRewardErrorMessage : NetworkMessage
{

public const uint Id = 6375;
public override uint MessageId
{
    get { return Id; }
}

public short achievementId;
        

public AchievementRewardErrorMessage()
{
}

public AchievementRewardErrorMessage(short achievementId)
        {
            this.achievementId = achievementId;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteShort(achievementId);
            

}

public override void Deserialize(BigEndianReader reader)
{

achievementId = reader.ReadShort();
            

}


}


}