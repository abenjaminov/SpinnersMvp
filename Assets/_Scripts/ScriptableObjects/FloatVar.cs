using UnityEngine;
using UnityEngine.Serialization;

namespace _Scripts.ScriptableObjects
{
    [CreateAssetMenu(menuName = "Variables/Float", fileName = "New Float Var")]
    public class FloatVar: ScriptableObject
    {
        [SerializeField] private float _value;

        [HideInInspector]
        public float Value
        {
            get => _value;
            set => _value = value;
        }
    }
}