using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _piecePrefab;
    [SerializeField]
    private GameObject _spacePiecePrefab;
    private GameObject _board;

    public GameObject[] PiecesOnBoard { get; private set; }


    void Awake()
    {
        _board = GameObject.FindGameObjectWithTag("Board");
        InstantiateAllPieces();
        PiecesOnBoard = GameObject.FindGameObjectsWithTag("Piece");
    }

    private void Start()
    {
        RandomPositions();
    }

    void InstantiateAllPieces()
    {
        for (int i = 0; i < 15; i++)
        {
            Instantiate(_piecePrefab, _board.transform);
        }
        Instantiate(_spacePiecePrefab, _board.transform);
    }

    void RandomPositions()
    {
        for (int i = 0; i < PiecesOnBoard.Length; i++)
        {
            PiecesOnBoard[i].transform.SetSiblingIndex(Random.Range(0, 15));
        }
    }

    public void OnPieceMoved()
    {
        for (int i = 0; i < PiecesOnBoard.Length; i++)
        {
            if (PiecesOnBoard[i].transform.GetSiblingIndex() == i)
            {
                Debug.Log("Win!!!");
            }
            else
            {
                Debug.Log("Continue...");
            }
        }
    }
}
