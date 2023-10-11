namespace MockObject
{
    public class EmployeeDatabase : IGetDataDatabase
    {
        public string GetNameById(int id)
        {
            string name;
            if (id == 1)
            {
                name = "Aakriti";
            }
            else if (id == 2)
            {
                name = "Manaswini";
            }
            else if (id == 3)
            {
                name = "Sandhya";
            }
            else
            {
                name = "Not Found";
            }
            return name;
        }
    }
}
