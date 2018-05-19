using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class Insult : ModuleBase<SocketCommandContext>
    {
        [Command("Insult")]
        public async Task InsultAsync(string name = "")
        {
            if(name == "")
            {
                name = Context.User.Mention;
            }
            string[] insults = new string[15];
            insults[0] = "I envy people who have never met you.";
            insults[1] = "You’re kinda like Rapunzel except instead of letting down your hair, you let down everyone in your life.";
            insults[2] = "You’re impossible to underestimate.";
            insults[3] = "You’re not the dumbest person on the planet, but you sure better hope he doesn’t die.";
            insults[4] = "If you were an inanimate object, you’d be a participation trophy.";
            insults[5] = "Your mother fucks for bricks so she can build your sister a whorehouse.";
            insults[6] = "Such a shame your mother didn’t swallow you.";
            insults[7] = "People like you are the reason God doesn’t talk to us anymore.";
            insults[8] = "How the fuck are you the sperm that won?";
            insults[9] = "I hope your wife brings a date to your funeral.";
            insults[10] = "I’d call you a cunt, but you have neither the warmth or the depth.";
            insults[11] = "If I wanted to commit suicide I’d climb to your ego and jump to your IQ.";
            insults[12] = "Everyone that has ever said they love you was wrong.";
            insults[13] = "You have the charm and charisma of a burning orphanage.";
            insults[14] = "If there was a single intelligent thought in your head it would have died from loneliness.";

            Random r = new Random();
            int num = r.Next(0, 15);

            await ReplyAsync(name + ", " + insults[num]);
        }
    }
}
