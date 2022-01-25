using UnityEngine;
using UnityEngine.UI;

namespace Manager
{
    public class UIManager : MonoBehaviour
    {
        private Image _uiWin;

        void Awake()
        {
            _uiWin = GameObject.Find("FadeToBlack").GetComponent<Image>();
        }

        private void Start()
        {
            _uiWin.gameObject.SetActive(false);
        }

        private void Update()
        {
            if (GameManager.Instance.WinGame)
            {
                _uiWin.gameObject.SetActive(true);
            }
        }

    }
}