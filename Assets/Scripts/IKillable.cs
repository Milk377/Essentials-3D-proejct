using System.Collections;
using System.Collections.Generic;

public interface IKillable 
{
    void Kill();
}

public interface IDamageable<T>
{
    void Damage(T damage);
}


