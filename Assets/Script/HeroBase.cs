using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroBase
{
    public string Name { get; set; }//名字
    public int Id { get; set; }//ID
    public string Introduction { get; private set; }//介绍
    public List<string> Country { get; private set; }//国家
    public List<string> ArmType { get; private set; }//兵种
    public string Icon { get; private set; }//图片

    // Start is called before the first frame update
    public HeroBase(int id, string name,string introduction, List<string> country, List<string> armType, string icon)
    {
        this.Id = id;
        this.Name = name;
        this.Introduction = introduction;
        this.Country = country;
        this.ArmType = armType;
        this.Icon = icon;
    }
}
