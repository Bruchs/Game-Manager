 using UnityEngine;
using System.Collections;

namespace GameManager
{
	public class GameManager_ToggleInstructionsUI : MonoBehaviour {

        public GameObject panelInstructionsUI;
        public GameObject panelMenu;
        private GameManager_Master gameManagerMaster;

        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.InstructionsUIToggleEvent += ToggleInstructionsUI;
        }

        void OnDisable()
        {
            gameManagerMaster.InstructionsUIToggleEvent -= ToggleInstructionsUI;
        }

        void Update()
        {
            CheckForToggleInstruction();
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        void CheckForToggleInstruction()
        {
            ToggleOffInstructionsUI();
        }

        void ToggleInstructionsUI()
        {
            if (panelInstructionsUI != null)
            {
                panelInstructionsUI.SetActive(!panelInstructionsUI.activeSelf);
                gameManagerMaster.isInstructionsOn = !gameManagerMaster.isInstructionsOn;
                panelMenu.SetActive(!panelMenu.activeSelf);
            }
        }

        void ToggleOffInstructionsUI()
        {
            if (panelInstructionsUI != null && Input.GetKeyDown(KeyCode.Escape) && panelInstructionsUI.activeSelf == true)
            {
                panelInstructionsUI.SetActive(!panelInstructionsUI.activeSelf);
                gameManagerMaster.isInstructionsOn = !gameManagerMaster.isInstructionsOn;
                panelMenu.SetActive(!panelMenu.activeSelf);
            }
        }

        void BackToMenu()
        {
            if (panelInstructionsUI != null)
            {
                panelInstructionsUI.SetActive(!panelInstructionsUI.activeSelf);
                gameManagerMaster.isInstructionsOn = !gameManagerMaster.isInstructionsOn;
                panelMenu.SetActive(!panelMenu.activeSelf);
            }
        }
      
	}
}

