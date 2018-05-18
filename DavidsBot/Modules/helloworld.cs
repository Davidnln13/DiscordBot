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

        [Command("fuck_chris")]
        public async Task FuckChrisAsync()
        {
            await ReplyAsync("Yeah fuck that guy");
        }
    }
}
