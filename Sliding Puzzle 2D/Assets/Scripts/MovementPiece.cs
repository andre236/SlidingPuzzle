using Manager;
using UnityEngine;


public class MovementPiece : MonoBehaviour
{
    [SerializeField]
    private bool _canMove;
    private bool _isMoving;

    private float _speedMovement = 15f;

    private GameObject _spacePiece;
    private Vector2 _oldPosition;
    private Vector2 _spacePiecePosition;

    private MovementPiece[] _movementPieces;


    private void Start()
    {
        _movementPieces = FindObjectsOfType<MovementPiece>();
        _spacePiece = FindObjectOfType<SpaceScript>().gameObject;
    }

    private void FixedUpdate()
    {
        TradePositionWithSpace();
    }

    void OnMouseDown()
    {
        if (_canMove && !_isMoving)
        {
            AudioManager.Instance.PlayMovement();
            GetPositions();
            _isMoving = true;
            _canMove = false;
            
        }
    }

    void TradePositionWithSpace()
    {
        
        if (_isMoving)
        {
            // Impossibilitar a movimentação de todas as peças.
            for (int i = 0; i < _movementPieces.Length; i++)
            {
                _movementPieces[i].ChangeCanMove(false);

            }
            // Trocar de lugar com espaço.
            _spacePiece.transform.position = Vector2.MoveTowards(_spacePiece.transform.position, _oldPosition, _speedMovement * Time.deltaTime);
            transform.position = Vector2.MoveTowards(transform.position, _spacePiecePosition, _speedMovement * Time.deltaTime);
            
            // Quando finalmente trocar de lugar.
            if (Vector2.Distance(transform.position, _spacePiecePosition) == 0 && Vector2.Distance(_spacePiece.transform.position, _oldPosition) == 0)
            {
                _isMoving = false;
                _spacePiece.GetComponent<SpaceScript>().AllowPieceMove();
                GameManager.Instance.CheckWin();
            }
        }
    }

    // Pegando as posições das peças comum e da "vazia".
    void GetPositions()
    {
        _oldPosition = transform.position;
        _spacePiecePosition = _spacePiece.transform.position;
    }

    public void ChangeCanMove(bool canMove)
    {
        _canMove = canMove;
    }
}
