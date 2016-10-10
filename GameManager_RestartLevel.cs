using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace GameManager
{
    public class GameManager_RestartLevel : MonoBehaviour
    {
        private GameManager_Master gameManagerMaster;

        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.RestarLevelEvent += RestartLevel;
        }

        void OnDisable()
        {
            gameManagerMaster.RestarLevelEvent -= RestartLevel;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        void RestartLevel()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

