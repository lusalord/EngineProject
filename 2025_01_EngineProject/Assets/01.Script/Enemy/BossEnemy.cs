using System.Collections;
using UnityEngine;

public class BossEnemy : MonoBehaviour
{
    private IEnumerator Dash()
    {
        yield return new WaitForSeconds(2f);
    }
}
