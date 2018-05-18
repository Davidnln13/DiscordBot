using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class helloworld :  ModuleBase<SocketCommandContext>
    {
        [Command("helloworld")]
        public async Task HelloWorldAsync()
        {
            await ReplyAsync("Hi I am Davids bot whaddup fam");
        }

        [Command("insult_chris")]
        public async Task FuckChrisAsync()
        {
            string insult = "";
            Random r = new Random();
            int num = r.Next(1, 6);
            if(num==1)
            {
                insult = "Go fuck yourself chris";
            }
            else if(num==2)
            {
                insult = "chris you're a shit head";
            }
            else if(num==3)
            {
                insult = "im chris i like asians wah";
            }
            else if(num==4)
            {
                insult = "legend 3 btw";
            }
            else
            {
                insult = "ha i liek wocks what about you";
            }
            await ReplyAsync(insult);
        }
    }
}
