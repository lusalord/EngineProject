using UnityEngine;

namespace _01.Script.Enemy
{
    public class NullEnemyRoom : MonoBehaviour
    {
        public Transform enemiesParent;
        public GameObject door;
    
        private bool _doorOpen = false;

        private void Update()
        {
            if (!_doorOpen && AreAllEnemiesDead())
            {
                _doorOpen = true;
                door.SetActive(false);
            }
        }

        private bool AreAllEnemiesDead()
        {
            foreach (Transform enemy in enemiesParent)
            {
                if (enemy.gameObject.activeInHierarchy)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
