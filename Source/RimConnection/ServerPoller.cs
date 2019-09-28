﻿using System;
using Verse;

namespace RimConnection
{
    class ServerPoller : GameComponent
    {
        private float timeCounterSeconds = 0.0f;
        private float waitTimeSeconds = 10.0f;

        private DateTime previousDateTime;

        public ServerPoller(Game game)
        {
        }

        public ServerPoller()
        {
        }

        public override void FinalizeInit()
        {
            base.FinalizeInit();
            previousDateTime = DateTime.Now;
        }

        public override void GameComponentTick()
        {
            base.GameComponentTick();
            var now = DateTime.Now;

            timeCounterSeconds += (float)(now - previousDateTime).TotalSeconds;
            if(timeCounterSeconds > waitTimeSeconds)
            {
                timeCounterSeconds = 0.0f;
                serverChecker();
            }

            previousDateTime = now;
        }

        private void serverChecker()
        {
            var commands = RequestHandler.GetCommands();
            foreach (var command in commands)
            {
                var action = ActionList.actionList[int.Parse(command.id)];
                action.execute(command.amount);
            }
            return;
        }

    }
}
