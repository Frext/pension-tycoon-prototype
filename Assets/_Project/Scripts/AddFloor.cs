using UnityEngine;

namespace _Project.Scripts
{
    public class AddFloor : MonoBehaviour
    {
        [SerializeField] private GameObject floorPrefab;
        [SerializeField] private Vector3 spawnPoint;

        public void Add()
        {
            Instantiate(floorPrefab, spawnPoint, Quaternion.identity);

            spawnPoint += new Vector3(0, 2, 0);
        }
    }
}
