using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DavidsBot.Modules
{
    public class WhoAmI : ModuleBase<SocketCommandContext>
    {
        [Command("WhoAmI")]
        public async Task WhoAmIAsync()
        {
            //user is me client is bot guild is server message is what triggered command 
            //Context.User;
            //Context.Client;
            //Context.Guild;
            //Context.Message;
            await ReplyAsync($"{Context.Client.CurrentUser.Mention} || { Context.User.Mention} sent { Context.Message.Content} in {Context.Guild.Name}!");

        }

    }
}
