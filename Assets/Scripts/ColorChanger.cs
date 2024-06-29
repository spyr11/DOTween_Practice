using DG.Tweening;
using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class ColorChanger : MonoBehaviour
{
    private readonly Color _color = Color.red;
    private readonly float _duration = 1f;

    private void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();

        renderer.DOColor(_color, _duration).SetLoops(-1, LoopType.Yoyo);
    }
}
