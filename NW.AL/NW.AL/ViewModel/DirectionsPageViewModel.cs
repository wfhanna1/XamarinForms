using System.Threading.Tasks;
using Microsoft.Bot.Connector.DirectLine;
using NW.AL.ViewModel;
using NW.AL.Common.Interfaces;
using NW.AL.Common;

namespace NW.AL.ViewModel
{
    public class DirectionsPageViewModel : BaseViewModel
    {
        Conversation conv;
        IBotCommunication _bot;
        public DirectionsPageViewModel(IBotCommunication bot)
        {
            if (NullChecker.IsObjectInitialized(bot))
            {
                _bot = bot;
            }
            Task.Run(async () => conv = await bot.StartConversation());

        }


        public void ReadMessages()
        {
            Task.Run(async () => await _bot.ReadBotMessagesAsync());
        }

        public void SendMessages()
        {

        }
    }
}
