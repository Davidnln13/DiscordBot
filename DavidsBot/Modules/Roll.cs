using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Roll : ModuleBase<SocketCommandContext>
    {
        [Command("Roll")]
        public async Task RollAsync(int min = 1, int max = 100)
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            if (min < 1)
                min = 1;

            Random r = new Random();
            int ranNum = r.Next(min, (max+1));
           

            
            builder.WithTitle("Rolling number between "+ min + " and " + max)
               .WithDescription(ranNum.ToString())
               .WithColor(Color.Red);

            await ReplyAsync("", false, builder.Build());

        }

    }
}
