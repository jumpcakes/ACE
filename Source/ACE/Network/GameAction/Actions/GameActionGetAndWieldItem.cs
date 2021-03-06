﻿namespace ACE.Network.GameAction.Actions
{
    public static class GameActionGetAndWieldItem
    {
        [GameAction(GameActionType.GetAndWieldItem)]
        public static void Handle(ClientMessage message, Session session)
        {
            uint itemGuid = message.Payload.ReadUInt32();
            uint location = message.Payload.ReadUInt32();
            session.Player.HandleActionWieldItem(session.Player, itemGuid, location);
        }
    }
}
