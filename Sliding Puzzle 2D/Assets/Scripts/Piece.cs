using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class Piece : MonoBehaviour
{
    private int _numberPiece;

    private Image _currentPieceImage;
    private Text _currentNumberTXT;
    private Color _currentTextColor;

    public PieceObject PieceSettings;

    private void Awake()
    {
        _currentPieceImage = GetComponent<Image>();
        _currentNumberTXT = transform.Find("Number").GetComponent<Text>();
        _currentTextColor = transform.Find("Number").GetComponent<Text>().color;
    }

    private void Start()
    {
        _currentNumberTXT.text = Regex.Match(gameObject.name, "\\d+").Value;
        _numberPiece = int.Parse(gameObject.name);
        _currentPieceImage.sprite = PieceSettings.Sprite;
        _currentNumberTXT.font = PieceSettings.Font;
        _currentNumberTXT.color = PieceSettings.Color;
    }
}
