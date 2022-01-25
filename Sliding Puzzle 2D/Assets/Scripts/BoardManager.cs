using UnityEngine;

namespace Manager
{
    public class BoardManager : MonoBehaviour
    {
        private GameObject _layoutPieces;
        [SerializeField]
        private GameObject _piecePrefab;
        [SerializeField]
        private GameObject _spacePiecePrefab;

        [field: SerializeField]
        public Vector2[] PositionsBoard { get; private set; }
        public GameObject[] PiecesOnBoard { get; private set; }

        private void Awake()
        {
            _layoutPieces = GameObject.FindGameObjectWithTag("Board");
            InstantiatePieces();
            PiecesOnBoard = GameObject.FindGameObjectsWithTag("Piece");
            RandomizeIndexPosition();
        }

        void InstantiatePieces()
        {
            for (int i = 0; i < 15; i++)
            {
                Instantiate(_piecePrefab, _layoutPieces.transform);
            }
            Instantiate(_spacePiecePrefab, _layoutPieces.transform);
        }

        void RandomizeIndexPosition()
        {
            for (int i = 0; i < 15; i++)
            {
                PiecesOnBoard[i].transform.SetSiblingIndex(Random.Range(0, 15));
            }
            for (int i = 0; i < PositionsBoard.Length; i++)
            {
                PiecesOnBoard[i].transform.position = PositionsBoard[i];
            }
        }



    }
}