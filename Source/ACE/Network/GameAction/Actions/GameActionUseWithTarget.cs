﻿using ACE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACE.Network.GameAction.Actions
{
    public static class GameActionUseWithTarget
    {
        [GameAction(GameActionType.UseWithTarget)]
        public static void Handle(ClientMessage message, Session session)
        {
            uint sourceObjectId = message.Payload.ReadUInt32();
            uint targetObjectId = message.Payload.ReadUInt32();
            session.Player.HandleActionUseOnTarget(new ObjectGuid(sourceObjectId), new ObjectGuid(targetObjectId));
        }
    }
}
