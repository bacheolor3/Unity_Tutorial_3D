using Pattern.Command;
using UnityEngine;

public class JumpCommand : ICommand
{
    private Player player;

    public JumpCommand(Player player)
    {
        this.player = player;
    }

    public void Cancel()
    {
        player.JumpCancel();
    }

    public void Execute()
    {
        player.Jump();
    }

}
