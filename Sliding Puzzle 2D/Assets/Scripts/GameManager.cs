using UnityEngine;

namespace Manager
{
    public class GameManager : MonoBehaviour
    {
        private BoardManager _boardManager;
        public static GameManager Instance;
        public bool WinGame { get; private set; }

        private void Awake()
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
            _boardManager = FindObjectOfType<BoardManager>();
        }

        private void Update()
        {
            
        }

        public void CheckWin()
        {
            int piecesRightPlace = 0;

            for(int i = 0; i < 15; i++)
            {
                if (_boardManager.PiecesOnBoard[i].GetComponent<Piece>().OnRightPlace)
                {
                    piecesRightPlace++;
                    if(piecesRightPlace == 15)
                    {
                        WinGame = true;
                    }
                }
            }

        }

    }
}