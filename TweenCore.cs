using UnityEngine;

namespace RTween
{
    public class TweenCore : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(gameObject);
            Tween.Init(10);
        }

        private void Update()
        {
            lock (Tween.TweenObjectData)
            {
                foreach (var v in Tween.TweenObjectData.Values)
                {
                    v.Update(Time.deltaTime);
                }
            }
        }
    }
}