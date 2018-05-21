using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Percentage : ModuleBase<SocketCommandContext>
    {
        [Command("Percentage")]
        public async Task PercentageAsync([Remainder] string s)
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            Random r = new Random();
            int ranNum = r.Next(1, 101);

            builder.WithTitle(s)
               .WithDescription(ranNum.ToString() + "%")
               .WithColor(Color.Magenta);

            await ReplyAsync("", false, builder.Build());

        }

    }
}
