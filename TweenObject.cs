using UnityEngine;
using System;

namespace RTween
{
    public class TweenObject<T1, T2> where T1 : new() where T2 : new()
    {
        public T1 TWObject;
        public T2 Target;
        public float TargetTime;
        public object Diff;
        public Action<float> OnUpdate;
        public Action OnCompleted;
        public int InstanceID;
        private float Time;

        public TweenObject(T1 TWObject, T2 Target, float TargetTime, Action<float> OnUpdate, Action OnCompleted, int InstanceID)
        {
            this.TWObject = TWObject;
            this.Target = Target;
            this.TargetTime = TargetTime;
            this.Diff = default;
            this.OnUpdate = OnUpdate;
            this.OnCompleted = OnCompleted;
            this.InstanceID = InstanceID;
        }

        public void Update(float deltaTime)
        {
            Time += deltaTime / 2;
            float Rate = Time / TargetTime;
            Debug.Log(Rate);
            if (Rate >= 1f)
            {
                OnCompleted?.Invoke();
                Tween.TweenObjectData.TryRemove(InstanceID, out _);
                return;
            }
            OnUpdate?.Invoke(Rate);
        }
    }
}