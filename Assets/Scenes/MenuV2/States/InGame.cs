using UnityEngine;

namespace Scenes.MenuV2.States
{
    public class InGame : IMenuState
    {
        private readonly Menu menu;

        public InGame(Menu menu)
        {
            this.menu = menu;
        }
        
        public void Enter()
        {
            menu.inGame.SetActive(true);
        }

        public void Update()
        {
            IMenuState newState = null;
            
            if (Input.GetKeyDown(KeyCode.C)) newState = new InGarage(menu);
            else if (Input.GetKeyDown(KeyCode.R)) newState = new InGarage(menu);
            else if (Input.GetKeyDown(KeyCode.L)) newState = new TooltipLevelList(menu);
            else if (Input.GetKeyDown(KeyCode.Escape)) newState = new OpenSettings(menu);

            if (newState != null) menu.SetState(newState);
        }

        public void Exit() {}
    }
}
