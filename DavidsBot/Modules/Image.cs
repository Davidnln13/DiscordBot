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
        public async Task ImageAsync()
        {
            //pretify
            EmbedBuilder builder = new EmbedBuilder();


            builder.WithTitle("The Man")
               .WithDescription("You Know it")
               .WithColor(Color.LightOrange)
               .WithThumbnailUrl("https://www.askideas.com/media/48/Donald-Trump-Funny-Smiling-Picture.jpg");
              

            await Context.Channel.SendMessageAsync("", false, builder);


        }

    }
}
