using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Compliment : ModuleBase<SocketCommandContext>
    {
        [Command("Compliment")]
        public async Task ComplimentAsync(string name = "")
        {
            if (name == "")
            {
                name = Context.User.Mention;
            }
            string[] compliments = new string[15];
            compliments[0] = "You just light up the room.";
            compliments[1] = "You make a bigger impact than you realize.";
            compliments[2] = "You are always so helpful.";
            compliments[3] = "You have the best laugh.";
            compliments[4] = "You bring out the best in the rest of us.";
            compliments[5] = "You inspire me.";
            compliments[6] = "I hope you are proud of yourself, because I am!";
            compliments[7] = "Everything seems brighter when you are around.";
            compliments[8] = "You're a smart cookie.";
            compliments[9] = "You're like a ray of sunshine on a really dreary day.";
            compliments[10] = "Everything would be better if more people were like you!";
            compliments[11] = "You may dance like no one's watching, but everyone's watching because you're an amazing dancer!";
            compliments[12] = "You're wonderful.";
            compliments[13] = "If you were a box of crayons, you'd be the giant name-brand one with the built-in sharpener.";
            compliments[14] = "Someone is getting through something hard right now because you've got their back. ";

            Random r = new Random();
            int num = r.Next(0, 15);

            await ReplyAsync(name + ", " + compliments[num]);
        }
    }
}
