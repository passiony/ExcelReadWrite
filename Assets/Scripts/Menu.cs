using UnityEngine;

[System.Serializable]
public class Menu
{

    public string m_Id;
    public string m_level;
    public string m_parentId;
    public string m_name;

    public void SetValue(string _id,string _level,string _parentid, string _name)
    {
        m_Id = _id;
        m_level = _level;
        m_parentId = _parentid;
        m_name = _name;
    }
    public void SetValue(Menu _menu)
    {
        m_Id = _menu.m_Id;
        m_level = _menu.m_level;
        m_parentId = _menu.m_parentId;
        m_name = _menu.m_name;
    }
}
