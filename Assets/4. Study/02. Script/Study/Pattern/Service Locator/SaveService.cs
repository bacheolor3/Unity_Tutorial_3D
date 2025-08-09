using System.Collections;
using UnityEngine;

namespace Assets._4._Study._02._Script.Study.Pattern.Service_Locator
{
    public class SaveService : MonoBehaviour, ISaveService
    {
        public void SaveData()
        {
            Debug.Log("Save Data");
        }

        public void LoadData()
        {
            Debug.Log("Load Data");
        }       
    }
}