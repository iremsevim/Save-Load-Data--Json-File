using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JsonController : MonoBehaviour
{
   
    public InputField ID;
    public InputField Name;
    public InputField Info;
    private TextAsset weapondata;


    public void SaveToJson()
    {
        WeaponData weapon = new WeaponData();

        weapon.ID = ID.text;
        weapon.Name = Name.text;
        weapon.Info = Info.text;
        string json = JsonUtility.ToJson(weapon, true);

        System.IO.File.WriteAllText(Application.dataPath + "/Resources/WeaponData.json", json);
    }
    public void LoadToJson()
    {
        
     
        string jsons = System.IO.File.ReadAllText(Application.dataPath + "/WeaponData.json");
        WeaponData data = JsonUtility.FromJson<WeaponData>(jsons);
        ID.text = data.ID;
        Name.text = data.Name;
        Info.text = data.Info;
    }
   [System.Serializable]
    public class WeaponData
    {
        public string ID;
        public string Name;
        public string Info;
    }
}
