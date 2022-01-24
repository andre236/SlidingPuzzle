using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    private GameObject _board;
    [SerializeField]
    private GameObject _piecePrefab;
    [SerializeField]
    private GameObject _spacePiecePrefab;

    [SerializeField]
    private Vector2[] _positionsPiece;


    private void Awake()
    {
        _board = GameObject.FindGameObjectWithTag("Board");
    }


}
