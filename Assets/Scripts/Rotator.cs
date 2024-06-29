using DG.Tweening;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    private readonly float _duration = 1f;
    private readonly float _angle = 360f;

    private void Start()
    {
        transform.DORotate(Vector3.up * _angle, _duration, RotateMode.LocalAxisAdd)
            .SetLoops(-1).SetEase(Ease.Linear);
    }
}
