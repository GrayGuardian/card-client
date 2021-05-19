
using System.Numerics;
using DG.Tweening;
using UnityEngine;
public class Main : MonoBehaviour
{
    void Awake()
    {
        MonoSingleton.Instance.MonoGo.AddComponent<LuaClient>();

        // float a = 10;
        // DOTween.To(() => a, (x) => a = x, 10, 100).SetEase(Ease.Linear) ;t
        // transform.DOLocalRotate()
        // Vector3
    }

}
