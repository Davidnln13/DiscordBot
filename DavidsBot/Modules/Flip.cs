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
            string link = "";
            if (outcome == "Tails")
                link = "https://www.eestipank.ee/sites/eestipank.ee/files/2eur_eu_lipp_rev_0.png";
            else
                link = "http://www.stickpng.com/assets/images/580b585b2edbce24c47b27c1.png";

            builder.WithTitle("Flipping a coin")
               .WithDescription(outcome)
               .WithColor(Color.LighterGrey)
               .WithThumbnailUrl(link);

            await Context.Channel.SendMessageAsync("", false, builder);

        }

    }
}
