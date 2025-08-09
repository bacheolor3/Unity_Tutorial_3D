using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Service_Locator
{
    public interface ISaveService 
    {
        void SaveData();
        void LoadData();
    }
}