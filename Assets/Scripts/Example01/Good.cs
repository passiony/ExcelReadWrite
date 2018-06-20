using UnityEngine;
/// <summary>
/// 商品实体类
/// </summary>
[System.Serializable]
public class Good
{
    public string m_firstId;
    public string m_secondId;
    public string m_thirdId;

    public string m_key;
    public string m_name;
    public string m_brand;
    public string m_style;
    public string m_color;
    public string m_material;
    public string m_shape;
    public string m_price;

    public void init()
    {
        m_firstId = "";
        m_secondId = "";
        m_thirdId = "";
        m_key = "";
        m_name = "";

        m_brand = "";
        m_style = "";
        m_color = "";
        m_material = "";
        m_shape = "";
        m_price = "";
    }
    public void SetValue(string _firstId, string _secondId, string _thirdId,string _key, string _name, string _brand, string _style, string _color, string _material, string _shape,string _price)
    {
        m_firstId = _firstId;
        m_secondId = _secondId;
        m_thirdId = _thirdId;
        m_key = _key;
        m_name = _name;

        m_brand = _brand;
        m_style = _style;
        m_color = _color;
        m_material = _material;
        m_shape = _shape;
        m_price = _price;
    }

    public void SetValue(Good _good)
    {
        m_firstId = _good.m_firstId;
        m_secondId = _good.m_secondId;
        m_thirdId = _good.m_thirdId;
        m_key = _good.m_key;
        m_name = _good.m_name;

        m_brand = _good.m_brand;
        m_style = _good.m_style;
        m_color = _good.m_color;
        m_material = _good.m_material;
        m_shape = _good.m_shape;
        m_price = _good.m_price;
    }
}
