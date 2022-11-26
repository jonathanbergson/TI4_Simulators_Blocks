using UnityEngine;

namespace Menu.States
{
    public class OpenSettings : IMenuState
    {
        private readonly Menu menu;

        public OpenSettings(Menu menu)
        {
            this.menu = menu;
        }
        
        public void Enter()
        {
            menu.openSettings.SetActive(true);
            Time.timeScale = 0;
        }

        public void Update()
        {
            if (!Input.GetKeyDown(KeyCode.Escape)) return;
            
            IMenuState newState = new InGame(menu);
            menu.SetState(newState);
        }

        public void Exit()
        {
            Time.timeScale = 1;
        }
    }
}
