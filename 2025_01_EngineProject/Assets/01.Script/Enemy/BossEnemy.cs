using System.Collections;
using UnityEngine;

namespace _01.Script.Enemy
{
    public class BossEnemy : MonoBehaviour
    {
        private bool _isMove;
        private IEnumerator Dash()
        {
            yield return new WaitForSeconds(2f);
        }
    }
}
