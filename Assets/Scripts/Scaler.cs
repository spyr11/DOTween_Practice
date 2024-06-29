using DG.Tweening;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    private readonly float _duration = 0.1f;

    private readonly float _scaleFactor = 1.1f;

    private void Start()
    {
        transform.DOScale(Vector3.one * _scaleFactor, _duration).SetLoops(-1, LoopType.Incremental);
    }
}