


















// Generated on 10/27/2013 07:41:47
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class ProtocolRequired : NetworkMessage
{

public const uint Id = 1;
public override uint MessageId
{
    get { return Id; }
}

public int requiredVersion;
        public int currentVersion;
        

public ProtocolRequired()
{
}

public ProtocolRequired(int requiredVersion, int currentVersion)
        {
            this.requiredVersion = requiredVersion;
            this.currentVersion = currentVersion;
        }
        

public override void Serialize(BigEndianWriter writer)
{

writer.WriteInt(requiredVersion);
            writer.WriteInt(currentVersion);
            

}

public override void Deserialize(BigEndianReader reader)
{

requiredVersion = reader.ReadInt();
            if (requiredVersion < 0)
                throw new Exception("Forbidden value on requiredVersion = " + requiredVersion + ", it doesn't respect the following condition : requiredVersion < 0");
            currentVersion = reader.ReadInt();
            if (currentVersion < 0)
                throw new Exception("Forbidden value on currentVersion = " + currentVersion + ", it doesn't respect the following condition : currentVersion < 0");
            

}


}


}