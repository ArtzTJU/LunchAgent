﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LunchAgent.Entities
{
    public struct SlackSetting
    {
        public string BotToken { get; set; }
        public string ChannelName { get; set; }
        public string BotId { get; set; }

        public SlackSetting(string botToken, string channelName, string botId) : this()
        {
            BotToken = botToken;
            ChannelName = channelName;
            BotId = botId;
        }
    }
}
