using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Repeat : ModuleBase<SocketCommandContext>
    {
        [Command("Repeat")]
        public async Task HelloWorldAsync([Remainder] string message = "nothing apparently")
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            //builder.AddField("test1","test2")
            //    .AddInlineField("test3","test4")
            //    .WithDescription("Fuckers")
            //    .WithColor(Color.Red);

            builder.WithTitle(Context.User.Mention + " wants me to say")
               .WithDescription(message)
               .WithColor(Color.Green);

            await ReplyAsync("", false, builder.Build());

        }

    }
}
