public class Person
{
    public string PersonName { get; set; }
    public string Email { get; set; }

    //there is Equals method of System.Object 
    //let's override this Equals method
    public override bool Equals(object obj)
    {
        Person p = (Person)obj;
        if(this.PersonName == p.PersonName && this.Email==p.Email)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return "Person name: "+ this.PersonName;
    }
}