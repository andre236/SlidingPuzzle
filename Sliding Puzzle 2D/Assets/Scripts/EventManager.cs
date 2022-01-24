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

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
