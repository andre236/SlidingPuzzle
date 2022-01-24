using UnityEngine;

public class EventManager : MonoBehaviour
{
    private GameManager _gameManager;
    private UIManager _uiManager;
    private Piece[] _pieces;


    void Awake()
    {
        _gameManager = FindObjectOfType<GameManager>();
        _uiManager = FindObjectOfType<UIManager>();
        _pieces = FindObjectsOfType<Piece>();

        for(int i = 0; i < _pieces.Length; i++)
        {
            _pieces[i].PieceMoved += _uiManager.OnPieceMoved;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
