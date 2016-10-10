using UnityEngine;
using System.Collections;

namespace GameManager
{
    public class GameManager_GameOver : MonoBehaviour
    {
        private GameManager_Master gameManagerMaster;
        public GameObject panelGameOver;
        public GameObject panelMenu;
        public AudioSource effectsAudioSource;
        public AudioSource ambienceAudioSource;

        void OnEnable()
        {
            SetInitialReferences();
            gameManagerMaster.GameOverEvent += TurnOnGameOverPanel;
        }

        void OnDisable()
        {
            gameManagerMaster.GameOverEvent -= TurnOnGameOverPanel;
        }

        void SetInitialReferences()
        {
            gameManagerMaster = GetComponent<GameManager_Master>();
        }

        void TurnOnGameOverPanel()
        {
            if (panelGameOver != null)
            {
                effectsAudioSource.enabled = true;
                effectsAudioSource.Play();
                ambienceAudioSource.enabled = true;
                ambienceAudioSource.Play();

                panelGameOver.SetActive(!panelGameOver.activeSelf);
                gameManagerMaster.isInstructionsOn = !gameManagerMaster.isInstructionsOn;
                panelMenu.SetActive(!panelMenu.activeSelf);
            }
            else
            {
                effectsAudioSource.enabled = false;
                ambienceAudioSource.enabled = false;
            }
        }
    }
}

