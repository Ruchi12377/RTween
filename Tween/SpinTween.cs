using UnityEngine;
using Random = UnityEngine.Random;
using Object = System.Object;

namespace RTween
{
    public static class SpinTween
    {
        public static void Spin(this Transform transform, Vector3 Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.rotation, Target, Time,
            (float rate) =>
            {
                transform.rotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.rotation = Target.quaternion();
            }, id);
            obj.Diff = (Target - transform.rotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void SpinX(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.rotation, Target, Time,
            (float rate) =>
            {
                transform.rotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.rotation = new Vector3(Target, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(Target, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z) - transform.rotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void SpinY(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.rotation, Target, Time,
            (float rate) =>
            {
                transform.rotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.rotation = new Vector3(transform.rotation.eulerAngles.x, Target, transform.rotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.rotation.eulerAngles.x, Target, transform.rotation.eulerAngles.z) - transform.rotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void SpinZ(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, Target).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, Target) - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalSpin(this Transform transform, Vector3 Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = Target.quaternion();
            }, id);
            obj.Diff = (Target - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LoaclSpinX(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = new Vector3(Target, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(Target, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z) - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalSpinY(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = new Vector3(transform.localRotation.eulerAngles.x, Target, transform.localRotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.localRotation.eulerAngles.x, Target, transform.localRotation.eulerAngles.z) - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalSpinZ(this Transform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.rotation, Target, Time,
            (float rate) =>
            {
                transform.rotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.rotation = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, Target).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, Target) - transform.rotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void Spin(this RectTransform transform, Vector3 Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.rotation, Target, Time,
            (float rate) =>
            {
                transform.rotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.rotation = Target.quaternion();
            }, id);
            obj.Diff = (Target - transform.rotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void SpinX(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.rotation, Target, Time,
            (float rate) =>
            {
                transform.rotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.rotation = new Vector3(Target, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(Target, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z) - transform.rotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void SpinY(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.rotation, Target, Time,
            (float rate) =>
            {
                transform.rotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.rotation = new Vector3(transform.rotation.eulerAngles.x, Target, transform.rotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.rotation.eulerAngles.x, Target, transform.rotation.eulerAngles.z) - transform.rotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void SpinZ(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, Target).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, Target) - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalSpin(this RectTransform transform, Vector3 Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = Target.quaternion();
            }, id);
            obj.Diff = (Target - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LoaclSpinX(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = new Vector3(Target, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(Target, transform.localRotation.eulerAngles.y, transform.localRotation.eulerAngles.z) - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalSpinY(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = new Vector3(transform.localRotation.eulerAngles.x, Target, transform.localRotation.eulerAngles.z).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.localRotation.eulerAngles.x, Target, transform.localRotation.eulerAngles.z) - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static void LocalSpinZ(this RectTransform transform, float Target, float Time)
        {
            Tween.CoreInit();
            TweenObject<Object, Object> obj = default;
            int id = Random.Range(int.MinValue, int.MaxValue);
            obj = new TweenObject<Object, Object>(transform.localRotation, Target, Time,
            (float rate) =>
            {
                transform.localRotation = (((Quaternion)obj.TWObject).eulerAngles + ((Quaternion)obj.Diff).eulerAngles * rate).quaternion();
            },
            () =>
            {
                transform.localRotation = new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, Target).quaternion();
            }, id);
            obj.Diff = (new Vector3(transform.localRotation.eulerAngles.x, transform.localRotation.eulerAngles.y, Target) - transform.localRotation.eulerAngles).quaternion();
            Tween.TweenObjectData.TryAdd(id, obj);
        }

        public static Quaternion quaternion(this Vector3 vec)
        {
            return Quaternion.Euler(vec);
        }
    }
}