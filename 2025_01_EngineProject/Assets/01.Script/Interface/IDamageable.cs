using UnityEngine;

namespace _01.Script.Interface
{
    public interface IDamageable
    {
        public void GetDamaged(int damage, GameObject attacker);
    }
}
