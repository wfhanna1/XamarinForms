using System;
using Microsoft.Bot.Connector.DirectLine;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Rest;
using System.Linq;
using NW.AL.Common.Interfaces;

namespace NW.AL.Common
{
    public class BotCommunication : IBotCommunication
    {
        DirectLineClient client;
        private Conversation botConversation;
        //TODO: Research issue with configuration manager and .net standard
        private string directLineSecret = "rHEYURQZKHs.cwA.a3o.9S8zf2nuMoSrHy4LsPd4GMe3ZAQr8mq18WlHEn2Zy3s";
        private string botId = "NWALChatBot";

        public BotCommunication()
        {

            client = new DirectLineClient(directLineSecret);
        }

        public async Task<Conversation> StartConversation()
        {
            try
            {
                botConversation =  await client.Conversations.StartConversationAsync();
                return botConversation;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task ReadBotMessagesAsync()
        {
            try
            {
                string watermark = null;


                while (true)
                {
                    var activitySet = await client.Conversations.GetActivitiesAsync(botConversation.ConversationId, watermark);
                    watermark = activitySet?.Watermark;

                    var activities = from x in activitySet.Activities
                                     where x.From.Id == botId
                                     select x;

                    foreach (Activity activity in activities)
                    {
                        Console.WriteLine(activity.Text);
                    }
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
