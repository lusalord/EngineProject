using System.Collections;
using UnityEngine;

namespace _01.Script.Enemy
{
    public class NcAttack : MonoBehaviour
    {
        [SerializeField] GameObject napePrefab;
        private void Update()
        {
            StartCoroutine(ThroughNape());
        }

        private IEnumerator ThroughNape()
        {
            yield return new WaitForSeconds(2f);
            Instantiate(napePrefab, transform.position, Quaternion.identity);
        }
    }
}
