using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Image : ModuleBase<SocketCommandContext>
    {
        [Command("Image")]
        public async Task ImageAsync([Remainder] string message)
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();

          
            builder.WithTitle("The Man")
               .WithDescription("You Know it")
               .WithThumbnailUrl("https://pixel.nymag.com/imgs/daily/intelligencer/2018/05/16/trump/16-trump-happy.w710.h473.jpg")
               .WithColor(Color.DarkMagenta);

            await ReplyAsync("", false, builder.Build());


        }

    }
}
