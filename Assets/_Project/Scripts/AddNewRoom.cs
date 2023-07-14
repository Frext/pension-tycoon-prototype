using UnityEngine;

namespace _Project.Scripts
{
    public class AddNewRoom : MonoBehaviour
    {
        [SerializeField] private GameObject roomPrefab;
        [SerializeField] private Vector3 spawnPoint;

        int count = 0;
        
        public void Add()
        {
            if (count > 2)
            {
                return;
            }
            
            Instantiate(roomPrefab, spawnPoint, Quaternion.identity);

            spawnPoint += new Vector3(-1.5f, 0, 0);

            count++;
        }
    }
}
