// Trong script qu?n l? bom
using UnityEngine;

public Animator bombAnimator; // Tham chi?u �?n Animator Controller c?a qu? bom

void Explode()
{
    // K�ch ho?t animation n?
    bombAnimator.SetTrigger("ExplodeTrigger");

    // ... C�c x? l? kh�c khi bom n? ...
}