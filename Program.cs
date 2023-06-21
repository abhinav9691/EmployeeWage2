using EmployeeWage2;

while (true)
{
    Console.WriteLine("Select the choice\n1)Employee Presence\n2)Employee Daily Wage" +
        "\n3)Part Time Wage");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            //Creating Object of the class to call in Main method
            //because method is non static
            EmployeePresence employeeAttendance = new EmployeePresence();
            employeeAttendance.EmpPresentAbsent();
            break;

        case 2:
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.EmpWage();
            break;

        case 3:
            PartTime partTime = new PartTime();
            partTime.EmployeeWage();
            break;
    }
}