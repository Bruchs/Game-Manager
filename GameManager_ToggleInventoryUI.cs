using UnityEngine;
using System.Collections;

namespace GameManager
{
    public class GameManager_ToggleInventoryUI : MonoBehaviour
    {
        public GameObject inventoryUI;
        private GameManager_Master gameManagerMaster;


        void Start()
        {
            SetInitialReferences();
        }

        void Update()
        {
            CheckForInventoryUIToggleRequest();
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        void CheckForInventoryUIToggleRequest()
        {
            if (Input.GetButtonUp("Toggle Inventory") && !gameManagerMaster.isMenuOn && !gameManagerMaster.isGameOver)
            {
                ToggleInventoryUI();
            }
        }

        public void ToggleInventoryUI()
        {
            if (inventoryUI != null)
            {
                inventoryUI.SetActive(!inventoryUI.activeSelf);
                gameManagerMaster.isInventoryUIOn = !gameManagerMaster.isInventoryUIOn;
                gameManagerMaster.CallInventoryUIToggle();
            }
        }
    }
}

