using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Flip : ModuleBase<SocketCommandContext>
    {
        [Command("Flip")]
        public async Task FlipAsync()
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            Random r = new Random();
            int num = r.Next(1, 3);
            string outcome = "";

            if(num == 1)
            {
                outcome = "Heads";
            }
            else
            {
                outcome = "Tails";
            }
            builder.WithTitle("Flipping a coin")
               .WithDescription(outcome)
               .WithColor(Color.DarkMagenta);

            await ReplyAsync("", false, builder.Build());

        }

    }
}
