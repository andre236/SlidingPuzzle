using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject _piecePrefab;
    [SerializeField]
    private GameObject _spacePiecePrefab;
    private GameObject[] _piecesOnBoard;
    private GameObject _board;

    public bool IsPreparing { get; private set; } = false;
    public bool IsRunning { get; private set; } = false;
    private void Awake()
    {
        _board = GameObject.FindGameObjectWithTag("Board");
        InstantiateAllPieces();
        _piecesOnBoard = GameObject.FindGameObjectsWithTag("Piece");
        RandomPositions();
        StartCoroutine("CheckIndexOnParent");
    }

    private void Update()
    {
        
    }

    private void Start()
    {
    }

    void InstantiateAllPieces()
    {
        for(int i = 0; i < 15; i++)
        {
            Instantiate(_piecePrefab, _board.transform);
        }
        Instantiate(_spacePiecePrefab, _board.transform);
    }
    
    void RandomPositions()
    {
        for(int i = 0; i < _piecesOnBoard.Length; i++)
        {
            _piecesOnBoard[i].transform.SetSiblingIndex(Random.Range(0,15));
            Debug.Log(_piecesOnBoard[i].transform.GetSiblingIndex());
        }
    }

    void CheckWin()
    {
        for(int i = 0; i < _piecesOnBoard.Length; i++)
        {
            if (_piecesOnBoard[i].transform.GetSiblingIndex() == i)
            {
                Debug.Log("Win!!!");
            }
            else
            {
                Debug.Log("Continue...");
            }
        }
    }

    private IEnumerator CheckIndexOnParent()
    {
        yield return new WaitForSeconds(3f);

        for (int i = 0; i < _piecesOnBoard.Length; i++)
        {
            Debug.Log(_piecesOnBoard[i].transform.GetSiblingIndex());
        }

        CheckWin();
        StartCoroutine("CheckIndexOnParent");
    }
}
