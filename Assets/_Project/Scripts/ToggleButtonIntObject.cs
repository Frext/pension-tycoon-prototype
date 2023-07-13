using _Project.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    [RequireComponent(typeof(Image))]
    public class ToggleButtonIntObject : MonoBehaviour
    {
        [SerializeField] private IntObject intObjectSO;

        private Image image;
        
        void Start()
        {
            image = GetComponent<Image>();

            image.enabled = intObjectSO.value != 5;
        }

        void Update()
        {
            image.enabled = intObjectSO.value != 5;
        }
    }
}
