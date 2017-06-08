using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public DataHolder dataHolder;

	// Use this for initialization
	void Start ()
    {
        //dataHolder = new DataHolder();

        dataHolder = Load();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Save()
    {
        var serializer = new XmlSerializer(typeof(DataHolder));

        using (var stream = new FileStream(Application.dataPath + "/Testsave.xml", FileMode.Create))
        {
            serializer.Serialize(stream, dataHolder);
        }
    }

    public DataHolder Load()
    {
        var serializer = new XmlSerializer(typeof(DataHolder));

        using (var stream = new FileStream(Application.dataPath + "/Testsave.xml", FileMode.Open))
        {
            return serializer.Deserialize(stream) as DataHolder;
        }
    }
}
