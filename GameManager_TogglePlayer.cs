using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

namespace GameManager
{
    public class GameManager_TogglePlayer : MonoBehaviour
    {
        private GameManager_Master gameManagerMaster;
        public FirstPersonController playerController;

        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.MenuToggleEvent += TogglePlayerController;
            gameManagerMaster.InventoryUIToggleEvent += TogglePlayerController;
        }

        void OnDisable()
        {
            gameManagerMaster.MenuToggleEvent -= TogglePlayerController;
            gameManagerMaster.InventoryUIToggleEvent -= TogglePlayerController;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GameObject.Find("Game Manager").GetComponent<GameManager_Master>();
        }

        void TogglePlayerController()
        {
            if (playerController != null)
            {
                playerController.enabled = !playerController.enabled;
            }
        }
    }
}

