using Bol;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
bool exit = false;
LinkedList<AppraisalForm> formList = new LinkedList<AppraisalForm>();
formList.AddLast(new AppraisalForm(1, "Nikhil", "Director", "MD Award receipient"));
formList.AddLast(new AppraisalForm(2, "Tanmay", "Director", "MD Award receipient"));
formList.AddLast(new AppraisalForm(3, "Yash", "Director", "MD Award receipient"));
formList.AddLast(new AppraisalForm(4, "Surpiya", "Director", "MD Award receipient"));
formList.AddLast(new AppraisalForm(5, "Komal", "Director", "MD Award receipient"));
System.Console.WriteLine("Appraisal Form Window\n 1. Insert \n 2. Update\n 3. Delete\n 4. GetByID\n 5. GetAll\n 6. Serial\n 7. Deserial\n 8. Display\n 9. Exit");
int id = 0;
String name = null;
string fileName = null;
string jsonString = null;
AppraisalForm formdelete = new AppraisalForm(1, "Nikhil", "Director", "MD Award receipient");
try
{
    while (!exit)
    {
        try
        {
            String input = Console.ReadLine();
            int option = Convert.ToInt32(input);
            switch (option)
            {
                case 1:
                    System.Console.WriteLine("In insert option");
                    System.Console.WriteLine("Enter ID");
                    input = System.Console.ReadLine();
                    id = Convert.ToInt32(input);
                    System.Console.WriteLine("Enter name");
                    name = System.Console.ReadLine();
                    System.Console.WriteLine("Enter Designation");
                    String designation = System.Console.ReadLine();
                    System.Console.WriteLine("Enter description");
                    String description = System.Console.ReadLine();
                    formList.AddLast(new AppraisalForm(id, name, designation, description));
                    System.Console.WriteLine("Form submitted");
                    break;
                case 2:
                    System.Console.WriteLine("In Update");
                    System.Console.WriteLine("Enter ID");
                    input = System.Console.ReadLine();
                    id = Convert.ToInt32(input);
                    System.Console.WriteLine("Enter new name");
                    name = System.Console.ReadLine();
                    foreach (var item in formList)
                    {
                        if (item.Id == id)
                        {
                            item.Name = name;
                        }
                    }
                    break;
                case 3:
                    System.Console.WriteLine("In Delete");
                    System.Console.WriteLine("Enter ID");
                    input = System.Console.ReadLine();
                    id = Convert.ToInt32(input);
                    foreach (var item in formList)
                    {
                        if (item.Id == id)
                        {
                            formdelete = item;
                        }
                    }
                    formList.Remove(formdelete);
                    break;
                case 4:
                    System.Console.WriteLine("In GetByID");
                    System.Console.WriteLine("In Delete");
                    System.Console.WriteLine("Enter ID");
                    input = System.Console.ReadLine();
                    id = Convert.ToInt32(input);
                    foreach (var item in formList)
                    {
                        if (item.Id == id)
                        {
                            System.Console.WriteLine(item);
                            break;
                        }
                    }
                    break;
                case 5:
                    System.Console.WriteLine("In GetAll");
                    foreach (var item in formList)
                    {
                        System.Console.WriteLine(item);
                    }
                    break;
                    break;
                case 6:
                    System.Console.WriteLine("In Serial");
                    fileName = "formlist.json";
                    jsonString = JsonSerializer.Serialize(formList);
                    File.WriteAllText(fileName, jsonString);
                    Console.WriteLine(File.ReadAllText(fileName));
                    break;
                case 7:
                    System.Console.WriteLine("In Deserial");
                    fileName = "formlist.json";
                    jsonString = File.ReadAllText(fileName);
                    formList = JsonSerializer.Deserialize<LinkedList<AppraisalForm>>(jsonString);
                    break;
                case 8:
                    exit = true;
                    break;
            }
        }
        catch (System.Exception e)
        {
            System.Console.WriteLine(e.StackTrace);
        }
    }
}
catch (System.Exception e)
{
    System.Console.WriteLine(e.StackTrace);
}
System.Console.WriteLine("Exiting...");
