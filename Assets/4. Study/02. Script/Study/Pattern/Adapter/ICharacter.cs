using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Adapter
{
    public interface ICharacter 
    {
        void Move(Vector3 dir);
        void Attack();
    }
}