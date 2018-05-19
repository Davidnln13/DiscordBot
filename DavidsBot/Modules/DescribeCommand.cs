﻿using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class DescribeCommand : ModuleBase<SocketCommandContext>
    {
        [Command("DescribeCommand")]
        public async Task DescribeCommandAsync(string commandName)
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            string[] commandTitles = new string[9];
            string[] commandDescriptions = new string[9];

            commandTitles[0] = "Commands";
            commandTitles[1] = "DescribeCommand";
            commandTitles[2] = "Flip";
            commandTitles[3] = "Image";
            commandTitles[4] = "Insult";
            commandTitles[5] = "Repeat";
            commandTitles[6] = "Roll";
            commandTitles[7] = "Welcome";
            commandTitles[8] = "WhoAmI";

            commandDescriptions[0] = "Lists the commands";
            commandDescriptions[1] = "Type a command name after this command to find out what it does";
            commandDescriptions[2] = "Flips a coin";
            commandDescriptions[3] = "Work in progress";
            commandDescriptions[4] = "Type a name after this command to insult that person";
            commandDescriptions[5] = "Repeats exactly what you say";
            commandDescriptions[6] = "Rolls a number between the minimum and maximum you give it e.g. ~roll 1 100 rolls a number between 1 and 100";
            commandDescriptions[7] = "Provides a welcome message";
            commandDescriptions[8] = "Command to show who you are, what you're typing and where you're typing it";

            for(int i = 0; i < 9; i++)
            {
                if(commandTitles[i] == commandName)
                {
                    builder.WithTitle(commandTitles[i])
                        .WithDescription(commandDescriptions[i])
                        .WithColor(Color.Green);

                    await ReplyAsync("", false, builder.Build());
                }
            }
            

        }

    }
}
