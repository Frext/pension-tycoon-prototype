using System.Collections.Generic;
using UnityEngine;

namespace _Project.Scripts.ScriptableObjects
{
    [CreateAssetMenu]
    public class RatingObject : ScriptableObject
    {
        [SerializeField] private List<IntObject> intObjectSOList;

        public float value
        {
            get
            {
                float rating = 0;
                foreach (var intObject in intObjectSOList)
                {
                    rating += (float)intObject.value / intObjectSOList.Count;
                }

                return rating;
            }
        }
    }
}
