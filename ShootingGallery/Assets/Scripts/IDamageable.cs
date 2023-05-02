using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamageable
{
    public void Damage(float damage, Vector3 hitPos, Vector3 hitNormal); 
}
