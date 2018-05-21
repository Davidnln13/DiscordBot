using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class DickSize : ModuleBase<SocketCommandContext>
    {
        [Command("DickSize")]
        public async Task DickSizeAsync()
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            Random r = new Random();
            int ranNum = r.Next(1, 11);
            string attached = "";
            if (ranNum <= 3)
                attached = "Your poor woman";
            else if (ranNum <= 7)
                attached = "Alright not bad";
            else
                attached = "Wow lucky girl";

            builder.WithTitle(Context.User.Mention + " Your Dick is " + ranNum + " inches, " + attached)
               .WithDescription(ranNum.ToString())
               .WithColor(Color.Green)
               .WithThumbnailUrl("http://www.pngall.com/wp-content/uploads/2016/06/Ruler-PNG-File.png");

            await Context.Channel.SendMessageAsync("", false, builder);

        }

    }
}
