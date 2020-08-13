using UnityEngine;
using System;
using System.Collections.Concurrent;
using Random = UnityEngine.Random;
using Object = System.Object;

namespace RTween
{
    public static class Tween
    {
        public static ConcurrentDictionary<int, TweenObject<Object, Object>> TweenObjectData;
        public static bool isInit { get; private set; } = false;
        private static TweenCore core = null;

        public static void Init(int capacity)
        {
            if (isInit) return;
            isInit = true;
            int numProcs = Environment.ProcessorCount;
            int concurrencyLevel = numProcs * 2;
            TweenObjectData = new ConcurrentDictionary<int, RTween.TweenObject<Object, Object>>(concurrencyLevel, capacity);
        }

        public static void CoreInit()
        {
            if (core != null) return;
            GameObject go = new GameObject();
            go.name = "[RTweenCore]";
            core = go.AddComponent<TweenCore>();
        }

        public static void To(this float num, float Target, float Time)
        {
            CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(num, Target, Time,
            (float rate) =>
            {
                num = ((float)obj.TWObject) + ((float)obj.Diff) * rate;
            },
            () =>
            {
                num = Target;
            }, id);
            obj.Diff = Target - num;
            TweenObjectData.TryAdd(id, obj);
        }
    }
}