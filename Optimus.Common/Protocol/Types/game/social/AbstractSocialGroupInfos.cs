


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class AbstractSocialGroupInfos
{

public const short Id = 416;
public virtual short TypeId
{
    get { return Id; }
}



public AbstractSocialGroupInfos()
{
}



public virtual void Serialize(BigEndianWriter writer)
{



}

public virtual void Deserialize(BigEndianReader reader)
{



}


}


}