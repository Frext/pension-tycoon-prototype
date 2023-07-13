using _Project.Scripts.ScriptableObjects;
using UnityEngine;

namespace _Project.Scripts
{
    public class SetIntObject : MonoBehaviour
    {
        [SerializeField] private IntObject intObjectSO;
        
        // Used for buttons
        public void SetTo(int val)
        {
            intObjectSO.value = val;
        }
    }
}
