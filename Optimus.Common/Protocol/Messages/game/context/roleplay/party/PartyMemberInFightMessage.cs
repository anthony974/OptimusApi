


















// Generated on 10/27/2013 07:41:37
using System;
using System.Collections.Generic;
using System.Linq;
using Optimus.Common.Protocol.Types;
using Optimus.Common.IO;
using Optimus.Common.Network;

namespace Optimus.Common.Protocol.Messages
{

public class PartyMemberInFightMessage : AbstractPartyMessage
{

public const uint Id = 6342;
public override uint MessageId
{
    get { return Id; }
}

public sbyte reason;
        public int memberId;
        public int memberAccountId;
        public string memberName;
        public int fightId;
        public Types.MapCoordinatesExtended fightMap;
        public int secondsBeforeFightStart;
        

public PartyMemberInFightMessage()
{
}

public PartyMemberInFightMessage(int partyId, sbyte reason, int memberId, int memberAccountId, string memberName, int fightId, Types.MapCoordinatesExtended fightMap, int secondsBeforeFightStart)
         : base(partyId)
        {
            this.reason = reason;
            this.memberId = memberId;
            this.memberAccountId = memberAccountId;
            this.memberName = memberName;
            this.fightId = fightId;
            this.fightMap = fightMap;
            this.secondsBeforeFightStart = secondsBeforeFightStart;
        }
        

public override void Serialize(BigEndianWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(reason);
            writer.WriteInt(memberId);
            writer.WriteInt(memberAccountId);
            writer.WriteUTF(memberName);
            writer.WriteInt(fightId);
            fightMap.Serialize(writer);
            writer.WriteInt(secondsBeforeFightStart);
            

}

public override void Deserialize(BigEndianReader reader)
{

base.Deserialize(reader);
            reason = reader.ReadSByte();
            if (reason < 0)
                throw new Exception("Forbidden value on reason = " + reason + ", it doesn't respect the following condition : reason < 0");
            memberId = reader.ReadInt();
            memberAccountId = reader.ReadInt();
            if (memberAccountId < 0)
                throw new Exception("Forbidden value on memberAccountId = " + memberAccountId + ", it doesn't respect the following condition : memberAccountId < 0");
            memberName = reader.ReadUTF();
            fightId = reader.ReadInt();
            fightMap = new Types.MapCoordinatesExtended();
            fightMap.Deserialize(reader);
            secondsBeforeFightStart = reader.ReadInt();
            

}


}


}