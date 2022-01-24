using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour
{
    [SerializeField]
    private bool _onRightPlace;
    [SerializeField]
    private bool _canMove;
    [SerializeField]
    private int _numberPiece;

    private SpriteRenderer _currentPieceImage;
    private Text _currentNumberTXT;
    private Color _currentTextColor;

    [SerializeField]
    private PieceObject _pieceSettings;

    public delegate void HandlePieceMovement();

    public event HandlePieceMovement PieceMoved;

    private void Awake()
    {
        _currentPieceImage = GetComponent<SpriteRenderer>();
        _currentNumberTXT = transform.Find("Canvas").transform.Find("NumberTXT").GetComponent<Text>();
        _currentTextColor = transform.Find("Canvas").transform.Find("NumberTXT").GetComponent<Text>().color;
    }

    private void OnEnable()
    {
        _currentPieceImage.sprite = _pieceSettings.Sprite;
        _currentNumberTXT.font = _pieceSettings.Font;
        _currentNumberTXT.color = _pieceSettings.Color;
        _numberPiece = transform.GetSiblingIndex() + 1;
        _currentNumberTXT.text = _numberPiece.ToString();
    }

    private void Update()
    {
        CheckRightPlace();
    }

    void CheckRightPlace()
    {
        int numberIndexTemp = _numberPiece - 1;
        if(transform.GetSiblingIndex() == numberIndexTemp)
        {
            _onRightPlace = true;
        }
        else
        {
            _onRightPlace = false;
        }
    }

    public void ChangeCanMove()
    {
        _canMove = true;
    }

    void TradePositionWithSpace()
    {
        
    }


}
