


















// Generated on 10/27/2013 07:41:35
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class JobCrafterDirectorySettingsMessage : NetworkMessage
{

public const uint Id = 5652;
public override uint MessageId
{
    get { return Id; }
}

public Types.JobCrafterDirectorySettings[] craftersSettings;
        

public JobCrafterDirectorySettingsMessage()
{
}

public JobCrafterDirectorySettingsMessage(Types.JobCrafterDirectorySettings[] craftersSettings)
        {
            this.craftersSettings = craftersSettings;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteUShort((ushort)craftersSettings.Length);
            foreach (var entry in craftersSettings)
            {
                 entry.Serialize(writer);
            }
            

}

public override void Deserialize(BigEndianReader reader)
{

var limit = reader.ReadUShort();
            craftersSettings = new Types.JobCrafterDirectorySettings[limit];
            for (int i = 0; i < limit; i++)
            {
                 craftersSettings[i] = new Types.JobCrafterDirectorySettings();
                 craftersSettings[i].Deserialize(reader);
            }
            

}


}


}