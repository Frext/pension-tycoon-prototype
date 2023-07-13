using System.Collections;
using UnityEngine;

namespace _Project.Scripts
{
    public class CustomerSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject customerPrefab;
        [SerializeField] private float secondsToWait;
        
        void Start()
        {
            StartCoroutine(SpawnCustomers());
        }

        private IEnumerator SpawnCustomers()
        {
            while (true)
            {
                Instantiate(customerPrefab, transform.position, Quaternion.identity, transform);
                
                yield return new WaitForSeconds(secondsToWait);
            }
        }
    }
}
