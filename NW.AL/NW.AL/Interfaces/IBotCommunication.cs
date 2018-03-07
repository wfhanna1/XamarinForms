using System;
using System.Threading.Tasks;
using Microsoft.Bot.Connector.DirectLine;

namespace NW.AL.Common.Interfaces
{
    public interface IBotCommunication
    {
        Task<Conversation> StartConversation();
        Task ReadBotMessagesAsync();
    }
}
