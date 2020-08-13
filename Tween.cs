using UnityEngine;
using Random = UnityEngine.Random;
using System;
using Object = System.Object;
using System.Collections.Concurrent;

namespace RTween
{
    public static class Tween
    {
        public static ConcurrentDictionary<int, TweenObject<Object, Object>> TweenObjectData;
        public static bool isInit { get; private set; } = false;

        public static void Init(int capacity)
        {
            if (isInit) return;
            isInit = true;
            int numProcs = Environment.ProcessorCount;
            int concurrencyLevel = numProcs * 2;
            TweenObjectData = new ConcurrentDictionary<int, RTween.TweenObject<Object, Object>>(concurrencyLevel, capacity);
        }

        public static void Move(this Transform transform, Vector3 Target, float Time)
        {
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.position, Target, Time,
            (float rate) =>
            {
                transform.position = ((Vector3)obj.TWObject) + ((Vector3)obj.Diff) * rate;
            },
            () =>
            {
                transform.position = Target;
            }, id);
            obj.Diff = Target - transform.position;
            TweenObjectData.TryAdd(id, obj);
        }

        public static void MoveY(this Transform transform, float Target, float Time)
        {
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.position, Target, Time,
            (float rate) =>
            {
                transform.position = ((Vector3)obj.TWObject) + new Vector3(0, ((float)obj.Diff) * rate, 0);
            },
            () =>
            {
                transform.position = new Vector3(transform.position.x, Target, transform.position.z);
            }, id);
            obj.Diff = Target - transform.position.y;
            TweenObjectData.TryAdd(id, obj);
        }
    }
}