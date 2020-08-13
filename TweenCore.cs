using UnityEngine;
using System.Collections.Generic;

namespace RTween
{
    public class TweenCore : MonoBehaviour
    {
        [SerializeField, NonEditable]
        private int CurrentTweenCount = 0;
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            Tween.Init(10);
        }

        private void Update()
        {
            lock (Tween.TweenObjectData)
            {
                CurrentTweenCount = Tween.TweenObjectData.Values.Count;
                foreach (var v in Tween.TweenObjectData.Values)
                {
                    v.Update(Time.deltaTime);
                }
            }
        }
    }
}