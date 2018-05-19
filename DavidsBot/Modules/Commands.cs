using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("Commands")]
        public async Task CommandsAsync()
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            //builder.AddField("test1","test2")
            //    .AddInlineField("test3","test4")
            //    .WithDescription("Fuckers")
            //    .WithColor(Color.Red);

            builder.WithTitle("Commands")
               .WithDescription("~Welcome \n" +
                                "~Commands \n" +
                                "~WhoAmI \n" +
                                "~Insult \n" +
                                "~Repeat \n" +
                                "~Roll \n" +
                                "~Flip \n" +
                                "~Image \n" +
                                "~DescribeCommand CommandName")
               .WithColor(Color.Blue);

            await ReplyAsync("", false, builder.Build());

        }

    }
}
