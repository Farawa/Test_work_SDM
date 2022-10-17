using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DataManager
{
    private static Data _data;
    public static Data DataSO
    {
        get
        {
            if (!_data)
            {
                _data = Resources.Load("Data") as Data;
            }
            return _data;
        }
    }
}
