using UnityEngine;


public class MovementPiece : MonoBehaviour
{
    private bool _canMove;

    private GameManager _gameManager;
    private void Awake()
    {
        _gameManager = GetComponent<GameManager>();
    }


}
