using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pattern.Command
{
    public class PlayerController : MonoBehaviour
    {
        public Player player;

        private ICommand attackCommand, jumpCommand, skillCommand;

        private Queue<ICommand> commandQueue = new Queue<ICommand>();
        private Stack<ICommand> executeCommands = new Stack<ICommand>();

        private void Awake()
        {
            attackCommand = new AttackCommand(player);
            jumpCommand = new JumpCommand(player);
            skillCommand = new SkillCommand(player, "Fireball");
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                attackCommand.Execute();
                executeCommands.Push(attackCommand);
            }
            else if (Input.GetKeyDown(KeyCode.W))
            {
                jumpCommand.Execute();
                executeCommands.Push(jumpCommand);
            }
            else if (Input.GetKeyDown(KeyCode.E))
            {
                skillCommand.Execute();
                executeCommands.Push(skillCommand);
            }

            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                commandQueue.Enqueue(attackCommand);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                commandQueue.Enqueue(jumpCommand);
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3))
            {
                commandQueue.Enqueue(skillCommand);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Debug.Log("Turn end and Execute Command");
                while(commandQueue.Count > 0)
                {
                    ICommand command = commandQueue.Dequeue();
                    command.Execute();
                    executeCommands.Push(command);
                }
            }

            if (Input.GetKeyDown(KeyCode.Z))
            {
                ICommand lastCommand = executeCommands.Pop();
                Debug.Log($"Cancel Command : {lastCommand.GetType().Name}");

                lastCommand.Cancel();
            }
            else
            {
                Debug.Log("There is no command to Cancel");
            }
        }
    }

}
