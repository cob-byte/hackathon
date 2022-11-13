using UnityEngine;

public class User
{
    string address, signmessage, _name;
    int passport, mmr;

    // Start is called before the first frame update
    public User(string address, string signmessage, string _name, int passport, int mmr)
    {
        this.address = address;
        this.signmessage = signmessage;
        this._name = _name;
        this.passport = passport;
    }
}
