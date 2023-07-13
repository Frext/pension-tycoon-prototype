using System;
using System.Collections;
using _Project.Scripts.ScriptableObjects;
using UnityEngine;

namespace _Project.Scripts
{
    public class DecayManager : MonoBehaviour
    {
        [SerializeField] private float decayTime;
        [SerializeField] private IntObject intObjectSO;
        
        void Start()
        {
            StartCoroutine(DecayOverTime());
        }

        private IEnumerator DecayOverTime()
        {
            while (true)
            {
                yield return new WaitForSeconds(decayTime);
                
                intObjectSO.value = Math.Clamp(intObjectSO.value - 1, 0, int.MaxValue);
            }
        }
    }
}
