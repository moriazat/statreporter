﻿
namespace StatReporter.Scraping
{
    internal class ActionTypeConverter
    {
        public static ActionType GetActionType(string actionString)
        {
            switch (actionString)
            {
                case "messageActionChatCreate":
                    return ActionType.CreateChat;

                case "messageActionChatLeave":
                    return ActionType.LeaveChat;

                case "messageActionChatAddUser":
                    return ActionType.AddUser;

                case "messageActionChatDeleteUser":
                    return ActionType.DeleteUser;

                case "messageActionPinMessage":
                    return ActionType.PinnedMessage;

                case "messageActionChannelMigrateFrom":
                    return ActionType.UpgradedToSupergroup;

                case "messageActionChatMigrateTo":
                    return ActionType.UpgradedToSupergroup;

                default:
                    return ActionType.None;
            }
        }
    }
}