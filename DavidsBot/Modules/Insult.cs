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
         

            Random r = new Random();
            int num = r.Next(0, 15);

            await ReplyAsync(name + ", " + insults[num]);
        }
    }
}
