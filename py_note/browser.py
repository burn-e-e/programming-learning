import requests
from discord import app_commands, Intents, Client, Interaction

# This will print the information in console
print("\n".join([
   "Сайн уу?"
]))


while True:
    # While loop starts and used Python.input() to get the token
    token = input("Token оо оруулна уу. >")

    # Then validates if the token you provided was correct or not
    r = requests.get("https://discord.com/api/v10/users/@me", headers={
        "Authorization": f"Bot {token}"
    })

    # If the token is correct, it will continue the code
    data = r.json()
    if data.get("id", None):
        break  # Breaks the while loop

    # If the token is incorrect, it will print the error message
    # and ask you to enter the token again (while Loop)
    print("\nБуруу Token оруулсан байна.")


class FunnyBadge(Client):
    def __init__(self, *, intents: Intents):
        super().__init__(intents=intents)
        self.tree = app_commands.CommandTree(self)

    async def setup_hook(self) -> None:
        """ This is called when the bot boots, to setup the global commands """
        await self.tree.sync(guild=None)


# Variable to store the bot class and interact with it
# Since this is a simple bot to run 1 command over slash commands
# We then do not need any intents to listen to events
client = FunnyBadge(intents=Intents.none())


@client.event
async def on_ready():
    """ This is called when the bot is ready and has a connection with Discord
        It also prints out the bot's invite URL that automatically uses your
        Client ID to make sure you invite the correct bot with correct scopes.
    """
    print("\n".join([
        f"Бот {client.user} аар амжилттай нэвтэрлээ(ID: {client.user.id})",
        "",
        f"Доорх LINK ийг ашиглаж {client.user} bot ийг server-дуу урьна уу.",
        f"https://discord.com/api/oauth2/authorize?client_id={client.user.id}&scope=applications.commands%20bot"
    ]))


async def _init_command_response(interaction: Interaction) -> None:
    """ This is called when the command is ran
        The reason the command is outside of the command function
        is because there are two ways to run the command and slash commands
        do not natevily support aliases, so we have to fake it.
    """

    # Responds in the console that the command has been ran
    print(f"> {interaction.user} command хэрэглэсэн.")

    # Then responds in the channel with this message
    await interaction.response.send_message("\n".join([
        f"Сайн уу? **{interaction.user}**, юу байна даа?."
    ]))


@client.tree.command()
async def sainuu(interaction: Interaction):
    """ Says hello or something """
    # Calls the function "_init_command_response" to respond to the command
    await _init_command_response(interaction)
    
@client.tree.command()
async def givemebadge(interaction: Interaction):
    """ Says hello or something, but with a different name """
    # Calls the function "_init_command_response" to respond to the command
    await _init_command_response(interaction)
    
@client.tree.command()
async def sdave(interaction: Interaction):
    """ Says hello or something """
    # Calls the function "_init_command_response" to respond to the command
    await _init_command_response(interaction)

# Runs the bot with the token you provided
client.run(token)
