using UnityEngine;
using Random = UnityEngine.Random;
using Object = System.Object;

namespace RTween
{
    public static class MoveTween
    {
        public static void Move(this Transform transform, Vector3 Target, float Time)
        {
            Tween.CoreInit();
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
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void MoveX(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.position, Target, Time,
            (float rate) =>
            {
                transform.position = ((Vector3)obj.TWObject) + new Vector3(((float)obj.Diff) * rate, 0, 0);
            },
            () =>
            {
                transform.position = new Vector3(Target, transform.position.y, transform.position.z);
            }, id);
            obj.Diff = Target - transform.position.x;
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void MoveY(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
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
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void MoveZ(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.position, Target, Time,
            (float rate) =>
            {
                transform.position = ((Vector3)obj.TWObject) + new Vector3(0, 0, ((float)obj.Diff) * rate);
            },
            () =>
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, Target);
            }, id);
            obj.Diff = Target - transform.position.z;
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalMove(this Transform transform, Vector3 Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localPosition, Target, Time,
            (float rate) =>
            {
                transform.localPosition = ((Vector3)obj.TWObject) + ((Vector3)obj.Diff) * rate;
            },
            () =>
            {
                transform.localPosition = Target;
            }, id);
            obj.Diff = Target - transform.localPosition;
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalMoveX(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localPosition, Target, Time,
            (float rate) =>
            {
                transform.localPosition = ((Vector3)obj.TWObject) + new Vector3(((float)obj.Diff) * rate, 0, 0);
            },
            () =>
            {
                transform.localPosition = new Vector3(Target, transform.localPosition.y, transform.localPosition.z);
            }, id);
            obj.Diff = Target - transform.localPosition.x;
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalMoveY(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localPosition, Target, Time,
            (float rate) =>
            {
                transform.localPosition = ((Vector3)obj.TWObject) + new Vector3(0, ((float)obj.Diff) * rate, 0);
            },
            () =>
            {
                transform.localPosition = new Vector3(transform.localPosition.x, Target, transform.localPosition.z);
            }, id);
            obj.Diff = Target - transform.localPosition.y;
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalMoveZ(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localPosition, Target, Time,
            (float rate) =>
            {
                transform.localPosition = ((Vector3)obj.TWObject) + new Vector3(0, 0, ((float)obj.Diff) * rate);
            },
            () =>
            {
                transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, Target);
            }, id);
            obj.Diff = Target - transform.localPosition.z;
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void Move(this RectTransform transform, Vector2 Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localPosition, Target, Time,
            (float rate) =>
            {
                transform.localPosition
                    = ((Vector3)obj.TWObject) + Expansions.Vector2ToVector3(((Vector2)obj.Diff) * rate, 0);
            },
            () =>
            {
                transform.localPosition = Target;
            }, id);
            obj.Diff = Target - new Vector2(transform.localPosition.x, transform.localPosition.y);
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void MoveX(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localPosition, Target, Time,
            (float rate) =>
            {
                transform.localPosition = ((Vector3)obj.TWObject) + new Vector3((float)obj.Diff * rate, 0, 0);
            },
            () =>
            {
                transform.localPosition
                = new Vector3(Target, transform.localPosition.y, transform.localPosition.z);
            }, id);
            obj.Diff = Target - transform.localPosition.x;
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void MoveY(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localPosition, Target, Time,
            (float rate) =>
            {
                transform.localPosition = ((Vector3)obj.TWObject) + new Vector3(0, (float)obj.Diff * rate, 0);
            },
            () =>
            {
                transform.localPosition = new Vector3(transform.localPosition.x, Target, transform.localPosition.z);
            }, id);
            obj.Diff = Target - transform.localPosition.y;
            Tween.TweenObjectData.TryAdd(id, obj);
        }
    }
}