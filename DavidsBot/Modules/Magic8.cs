using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Magic8 : ModuleBase<SocketCommandContext>
    {
        [Command("Magic8")]
        public async Task Magic8Async([Remainder] string s)
        {

            string[] responses = new string[23];
            responses[0] = "It is certain.";
            responses[1] = "It is decidedly so.";
            responses[2] = "Without a doubt.";
            responses[3] = "Yes definitely.";
            responses[4] = "You may rely on it.";
            responses[5] = "You can count on it.";
            responses[6] = "As I see it, yes.";
            responses[7] = "Most likely.";
            responses[8] = "Outlook good.";
            responses[9] = "Yes.";
            responses[10] = "Signs point to yes.";
            responses[11] = "Absolutely.";
            responses[12] = "Reply hazy try again.";
            responses[13] = "Ask again later.";
            responses[14] = "Better not tell you now";
            responses[15] = "Cannot predict now.";
            responses[16] = "Concentrate and ask again.";
            responses[17] = "Don't count on it.";
            responses[18] = "My reply is no.";
            responses[19] = "My sources say no.";
            responses[20] = "Outlook not so good.";
            responses[21] = "Very doubtful.";
            responses[22] = "Chances aren't good.";

            //pretify
            EmbedBuilder builder = new EmbedBuilder();

            Random r = new Random();
            int ranNum = r.Next(0, 23);

            builder.WithTitle("The Magic 8 ball says")
               .WithDescription(responses[ranNum])
               .WithColor(Color.DarkGrey)
                .WithThumbnailUrl("http://www.backgroundsy.com/file/large/pool-eight-ball.jpg");

            await Context.Channel.SendMessageAsync("", false, builder);

        }

    }
}
