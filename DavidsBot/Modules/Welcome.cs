using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Welcome :  ModuleBase<SocketCommandContext>
    {
        [Command("Welcome")]
        public async Task HelloWorldAsync()
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            //builder.AddField("test1","test2")
            //    .AddInlineField("test3","test4")
            //    .WithDescription("Fuckers")
            //    .WithColor(Color.Red);

            builder.WithTitle("Welcome To My Bot")
               .WithDescription("Check commands with ~Commands")
               .WithColor(Color.Red);

            await ReplyAsync("", false, builder.Build());

        }

    }
}
