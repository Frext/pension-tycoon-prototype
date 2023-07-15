using System;
using System.Collections;
using _Project.Scripts.ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace _Project.Scripts
{
    [RequireComponent(typeof(Image))]
    public class ShowRatingObject : MonoBehaviour
    {
        [SerializeField] private RatingObject ratingObjectSO;

        private Image image;

        void Awake()
        {
            image = GetComponent<Image>();
        }

        void OnEnable()
        {
            StartCoroutine(IUpdateText());
        }

        IEnumerator IUpdateText()
        {
            while (true)
            {
                image.fillAmount = ratingObjectSO.value / 5f;
                yield return new WaitForSeconds(.25f);
            }
        }

        private void OnDisable()
        {
            StopAllCoroutines();
        }
    }
}