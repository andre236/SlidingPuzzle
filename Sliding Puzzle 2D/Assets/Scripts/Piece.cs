using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour
{

    private int _numberPiece;

    private Image _currentPieceImage;
    private Text _currentNumberTXT;
    private Color _currentTextColor;

    [SerializeField]
    private PieceObject _pieceSettings;


    private void Awake()
    {
        _currentPieceImage = GetComponent<Image>();
        _currentNumberTXT = transform.Find("NumberTXT").GetComponent<Text>();
        _currentTextColor = transform.Find("NumberTXT").GetComponent<Text>().color;
    }

    private void OnEnable()
    {
        _currentPieceImage.sprite = _pieceSettings.Sprite;
        _currentNumberTXT.font = _pieceSettings.Font;
        _currentNumberTXT.color = _pieceSettings.Color;
        _numberPiece = transform.GetSiblingIndex();
        _currentNumberTXT.text = _numberPiece.ToString();
    }

}
