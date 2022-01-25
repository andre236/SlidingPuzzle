using UnityEngine;

namespace Manager
{
    public class AudioManager : MonoBehaviour
    {
        private GameObject[] _audioClips;

        public static AudioManager Instance;

        void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
            _audioClips = GameObject.FindGameObjectsWithTag("SFX");
        }

        public void PlayMovement()
        {
            _audioClips[Random.Range(0, _audioClips.Length)].GetComponent<AudioSource>().Play();
        }
    }
}