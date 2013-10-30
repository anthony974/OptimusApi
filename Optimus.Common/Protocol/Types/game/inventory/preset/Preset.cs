


















// Generated on 10/27/2013 07:41:53
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Types
{

public class Preset
{

public const short Id = 355;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte symbolId;
        public bool mount;
        public Types.PresetItem[] objects;
        

public Preset()
{
}

public Preset(sbyte presetId, sbyte symbolId, bool mount, Types.PresetItem[] objects)
        {
            this.presetId = presetId;
            this.symbolId = symbolId;
            this.mount = mount;
            this.objects = objects;
        }
        

public virtual void Serialize(BigEndianWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(symbolId);
            writer.WriteBoolean(mount);
            writer.WriteUShort((ushort)objects.Length);
            foreach (var entry in objects)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(BigEndianReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            symbolId = reader.ReadSByte();
            if (symbolId < 0)
                throw new Exception("Forbidden value on symbolId = " + symbolId + ", it doesn't respect the following condition : symbolId < 0");
            mount = reader.ReadBoolean();
            var limit = reader.ReadUShort();
            objects = new Types.PresetItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objects[i] = new Types.PresetItem();
                 objects[i].Deserialize(reader);
            }
            

}


}


}