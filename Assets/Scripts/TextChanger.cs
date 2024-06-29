using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class TextChanger : MonoBehaviour
{
    private readonly string _textReplaced = "Replaced";
    private readonly string _textAdd = "--ADDED--";
    private readonly string _textScramble = "ScrambleMode - All";

    private readonly float _delay = 2f;

    [SerializeField] private Text _text;

    private void Start()
    {
        Sequence sequence = DOTween.Sequence();

        sequence.Append(_text.DOText(_textReplaced, _delay));
        sequence.Append(_text.DOText(_textAdd, _delay).SetDelay(_delay).SetRelative());
        sequence.Append(_text.DOText(_textScramble, _delay, true, ScrambleMode.All));
        sequence.SetLoops(-1);
    }
}