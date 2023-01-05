namespace Bol;
public class AppraisalForm
{
    public int Id{get;set;}
    public String Name{get;set;}
    public String Designation{get;set;}
    public String Description{get;set;}
    public bool SubmitFlag{get;set;}

    public AppraisalForm()
    {
        this.Id=0;
        this.Name="name";
        this.Designation="designation";
        this.Description="description";
    }

    public AppraisalForm(int id,String name,String designation,String description)
    {
        this.Id=id;
        this.Name=name;
        this.Designation=designation;
        this.Description=description;
    }

    public override string ToString()
    {
        return "Id: "+Id+" Name: "+Name+" Designation: "+Designation+" Description: "+Description;
    }
}
