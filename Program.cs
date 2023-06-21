using EmployeeWage2;





while (true)
{
    Console.WriteLine("Select the choice\n1)Employee Presence\n2)Employee Daily Wage");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            EmployeePresence employeeAttendance = new EmployeePresence();
            employeeAttendance.EmpPresentAbsent();
            break;

        case 2:
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.EmpWage();
            break;
    }
}