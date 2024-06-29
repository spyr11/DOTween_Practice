using DG.Tweening;
using UnityEngine;

public class Mover : MonoBehaviour
{
    private readonly float _speed = 2f;
    private readonly float _duration = 1f;

    [SerializeField] private Vector3 _direction;

    private void Start()
    {
        transform.DOBlendableMoveBy(_direction * _speed, _duration)
            .SetEase(Ease.Linear).SetLoops(-1, LoopType.Incremental);
    }
}