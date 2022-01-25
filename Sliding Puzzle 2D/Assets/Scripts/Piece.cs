using Manager;
using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour
{
    // --- Caracteristicas da Peça
    [SerializeField]
    private int _numberPiece;
    private SpriteRenderer _currentPieceImage;
    private Text _currentNumberTXT;
    private Color _currentTextColor;

    [SerializeField]
    private PieceObject _pieceSettings;

    [field:SerializeField]
    public bool OnRightPlace { get; private set; }

    private void Awake()
    {
        _currentPieceImage = GetComponent<SpriteRenderer>();
        _currentNumberTXT = transform.Find("Canvas").transform.Find("NumberTXT").GetComponent<Text>();
        _currentTextColor = transform.Find("Canvas").transform.Find("NumberTXT").GetComponent<Text>().color;
    }

    private void Start()
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
        // Se a posição for a mesma que a index da posição da board.
        Vector3 RightPositionOnBoard = FindObjectOfType<BoardManager>().PositionsBoard[transform.GetSiblingIndex()];

        if (transform.position == RightPositionOnBoard)
        {
            OnRightPlace = true;
        }
        else
        {
            OnRightPlace = false;
        }


    }


}
