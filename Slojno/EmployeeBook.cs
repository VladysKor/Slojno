using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slojno
{
    internal class EmployeeBook
    {
        private List<Employee> employees = new List<Employee>()
            {
                new Employee("Никитина Алиса Витальевна", 2, 50000),
                new Employee("Федотов Сергей Юрьевич", 4, 60000),
                new Employee("Иванова Елена Михайловна", 5, 45000),
                new Employee("Галкин Валентин Николаевич", 3, 70000),
                new Employee("Чернов Николай Алексеевич", 1, 65000),
                new Employee("Селезнева Наталья Ивановна", 3, 75000),
                new Employee("Гуляев Андрей Павлович", 5, 65000),
                new Employee("Матвеева Анна Владимировна", 1, 80000),
                new Employee("Ракова Ольга Сергеевна", 2, 60000),
                new Employee("Лаврентьева Вера Алексеевна", 4, 52000)
            };

        public void GetAllEmployees()
        {
            foreach (Employee emp in employees)          //ищем в емплое сотрудников и выводим
            {
                if (emp != null)   // возвращаем значение если неимеем одинакокого значение, если нет то false       
                {
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.FIO}, Отдел: {emp.Department}, Зарплата: {emp.Salary}");    // выводим ид, ФИО, отдел, Зарплыту
                }
            }
        }

        public void CalculateMonthlySalary()
        {
            double totalSalary = 0;
            foreach (var emp in employees)                       //вычисляет общую сумму затрат на зарплаты для всех сотрудников,
                                                                 //используя данные из массива employees. Он добавляет зарплату
                                                                 //каждого сотрудника в переменную totalSalary с помощью цикла foreach, а затем выводит
            {
                totalSalary += emp.Salary;
            }
            Console.WriteLine("Затраты на зарплаты в месяц: " + totalSalary);
        }

        public void FindEmployeeWithLowestSalary()
        {
            Employee minSalaryEmployee = null;
            double minSalary = double.MaxValue;
            foreach (var emp in employees)
            {
                if (emp != null && emp.Salary < minSalary)                            //находит среди всех сотрудников того, у кого зарплата является минимальной.
                                                                                      //Для этого с помощью цикла foreach проходится по всем сотрудникам в массиве employees
                                                                                      //и сравнивает их зарплату с переменной minSalary. Если зарплата сотрудника меньше,
                                                                                      //чем текущее значение minSalary, то оно заменяется на зарплату этого сотрудника,
                                                                                      //а переменной minSalaryEmployee присваивается значение этого сотрудника.
                {
                    minSalary = emp.Salary;
                    minSalaryEmployee = emp;
                }
            }
            Console.WriteLine($"Сотрудник с наименьшей зарплатой:\nID: {minSalaryEmployee.ID}, ФИО: {minSalaryEmployee.FIO}," +
                $" Отдел: {minSalaryEmployee.Department}, Зарплата: {minSalaryEmployee.Salary}");
        }

        public void FindEmployeeWithHighestSalary()
        {
            Employee maxSalaryEmployee = null;
            double maxSalary = double.MinValue;
            foreach (var emp in employees)
            {
                if (emp != null && emp.Salary > maxSalary)
                {
                    maxSalary = emp.Salary;
                    maxSalaryEmployee = emp;
                }
            }
            Console.WriteLine($"Сотрудник с наибольшей зарплатой:\nID: {maxSalaryEmployee.ID}, ФИО: {maxSalaryEmployee.FIO}," +     //находит среди всех сотрудников того, у кого зарплата является максимальной.
                                                                                                                                    //Для этого с помощью цикла foreach проходится по всем сотрудникам в массиве employees
                                                                                                                                    //и сравнивает их зарплату с переменной maxSalary. Если зарплата сотрудника больше,
                                                                                                                                    //чем текущее значение maxSalary, то оно заменяется на зарплату этого сотрудника,
                                                                                                                                    //а переменной maxSalaryEmployee присваивается значение этого сотрудника
                $" Отдел: {maxSalaryEmployee.Department}, Зарплата: {maxSalaryEmployee.Salary}");
        }

        public void CalculateAverageSalary()
        {
            double totalSalary = 0;
            int count = 0;
            foreach (var emp in employees)
            {
                if (emp != null)
                {
                    totalSalary += emp.Salary;                     //рассчитывает среднюю зарплату всех сотрудников, хранящихся в массиве employees.
                                                                   //Для этого метод использует цикл foreach для перебора всех элементов массива employees.
                                                                   //Внутри цикла проверяется, является ли элемент массива экземпляром класса Employee,
                                                                   //и если это так, то значение зарплаты Salary этого объекта прибавляется к переменной totalSalary,
                                                                   //а переменная count увеличивается на 1
                    count++;
                }
            }
            Console.WriteLine("Средняя зарплата: " + totalSalary / count);
        }

        public void GetAllEmployeeNames()          //выводит на консоль имена всех сотрудников, хранящихся в массиве employees.
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(emp.FIO);
            }
        }

        public void SalaryIndexing()
        {
            double indexingSalary = 1.05;
            foreach (var emp in employees)
            {
                emp.Salary *= indexingSalary;                                                 //нутри цикла значение зарплаты каждого сотрудника умножается на коэффициент 1.2 (indexingSalary),
                                                                                              //который соответствует индексации зарплаты на 20%
                Console.WriteLine("Зарплата после индексации на 5%: " + emp.Salary);
            }
        }

        public void DepartmentEmployeeWithLowestSalary()
        {
            double minSalary = double.MaxValue;
            foreach (var emp in employees)
            {
                if (emp.Department == 1 && emp.Salary < minSalary)
                {
                    minSalary = emp.Salary;
                    Console.WriteLine($"Сотрудник отдела 1 с наименьшей зарплатой:\nID: {emp.ID}, ФИО: {emp.FIO}," +      //находит сотрудника из отдела №2 с наименьшей зарплатой. Для этого переменная minSalary
                                                                                                                          //инициализируется начальным значением double.MaxValue, чтобы любая первая зарплата,
                                                                                                                          //которую мы сравниваем, была ниже этого значения. Затем метод использует цикл foreach,
                                                                                                                          //чтобы перебрать всех сотрудников в массиве employees.
                        $" Зарплата: {emp.Salary}");
                }
            }
        }

        public void DepartmentEmployeeWithHighestSalary()
        {
            double maxSalary = double.MinValue;
            foreach (var emp in employees)
            {
                if (emp.Department == 1 && emp.Salary > maxSalary)
                {
                    maxSalary = emp.Salary;
                    Console.WriteLine($"Сотрудник отдела 1 с наибольшей зарплатой:\nID: {emp.ID}, ФИО: {emp.FIO}," +         //находит сотрудника из отдела №2 с наибольшей зарплатой. Для этого переменная minSalary
                                                                                                                             //инициализируется начальным значением double.MaxValue, чтобы любая первая зарплата,
                                                                                                                             //которую мы сравниваем, была ниже этого значения. Затем метод использует цикл foreach,
                                                                                                                             //чтобы перебрать всех сотрудников в массиве employees.
                        $" Зарплата: {emp.Salary}");
                }
            }
        }

        public void DepartmentCalculateAverageSalary()
        {
            double totalSalary = 0;
            int count = 0;
            foreach (var emp in employees)
            {
                if (emp != null && emp.Department == 1)
                {
                    totalSalary += emp.Salary;                                             //находит среднюю зарплату сотрудников из отдела №2. Он использует переменную totalSalary,
                                                                                           //которая инициализируется нулем, каждый раз когда встречается сотрудник из отдела №2 и
                                                                                           //зарплата которого известна, зарплата добавляется в переменную
                    count++;
                }
            }
            Console.WriteLine("Средняя зарплата отдела 1: " + totalSalary / count);
        }

        public void DepartmentSalaryIndexing()
        {
            double indexingSalary = 1.05;
            foreach (var emp in employees)
            {
                if (emp.Department == 1)
                {
                    emp.Salary *= indexingSalary;
                    Console.WriteLine("Зарплата сотрудников отдела 2 после индексации на 50%: " + emp.Salary);   //н начинается с инициализации переменной indexingSalary стандартным значением 1.2,
                                                                                                                 //которое соответствует 20%-му повышению зарплаты. Затем для каждого сотрудника из
                                                                                                                 //списка employees происходит проверка, работает ли он в отделе №2, и если да,
                                                                                                                 //то его зарплата умножается на indexingSalary. 
                }
            }
        }

        public void GetAllDepartmentEmployeeNames()
        {
            foreach (var emp in employees)
            {
                if (emp.Department == 2)
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.FIO}, Зарплата: {emp.Salary}");            //В методе создается новый объект типа Employee, в который затем передаются значения параметров,
                                                                                                           //таких как ID, ФИО, зарплата, отдел. 
            }
        }

        public void SalaryLess()
        {
            Console.WriteLine("\nСотрудники с зарплатой меньше 50000:");
            foreach (var emp in employees)
            {
                if (emp.Salary < 50000)
                {
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.FIO}, Зарплата: {emp.Salary}");       //начала метод выводит в консоль заголовок списка. Затем он проходит через массив "employees"
                                                                                                      //по каждому элементу и если значение зарплаты меньше 80000, то выводит информацию о сотруднике в консоль.
                }
            }
        }

        public void SalaryMoreOrEqually()
        {
            Console.WriteLine("Сотрудники с зарплатой 50000 или больше:");                             //метод выводит заголовок списка в консоль. Затем он проходит через массив "employees" по каждому элементу и выводит
                                                                                                       //информацию о сотруднике, если значение его зарплаты больше либо равно 80000.
            foreach (var emp in employees)
            {
                if (emp.Salary >= 50000)
                {
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.FIO}, Зарплата: {emp.Salary}");
                }
            }
        }

        public void Add()
        {
            Console.Write("Введите ФИО нового сотрудника: ");
            string newFIO = Console.ReadLine();

            Console.Write("Введите номер отдела нового сотрудника: ");                            //Данный метод позволяет добавить нового сотрудника в список работников компании. При вызове метода
                                                                                                  //пользователю предлагается ввести данные нового сотрудника: ФИО, номер отдела и зарплату.
                                                                                                  //Затем происходит проверка введенного номера отдела. Если номер не соответствует допустимым значениям(от 1 до 5),
                                                                                                  //то пользователь получает сообщение об ошибке и ему предлагается повторно ввести номер отдела.
            int newDepartment = Convert.ToInt16(Console.ReadLine());

            if (newDepartment < 1 && newDepartment > 5)
            {
                Console.Write("Номер отдела введён некорректно!\nВведите номер отдела нового сотрудника: ");
                newDepartment = Convert.ToInt16(Console.ReadLine());
            }

            Console.Write("Введите зарплату нового сотрудника: ");
            int newSalary = Convert.ToInt32(Console.ReadLine());

            bool addEmp = false;

            for (int i = 0; i < employees.Count; i++)
            {
                if (i != employees[i].ID)
                {
                    employees.Insert(i, new Employee(newFIO, newDepartment, newSalary));
                    employees[i].ID = i;
                    addEmp = true;
                }
            }
            if (addEmp == false)
            {
                employees.Add(new Employee(newFIO, newDepartment, newSalary));
            }
            Console.WriteLine("Cотрудник добавлен");
        }

        public void Remove()
        {
            Console.Write("Введите ID или ФИО сотрудника для удаления: ");                        //Данный метод предназначен для удаления сотрудника из списка работников компании.
                                                                                                  //При вызове метода пользователю предлагается ввести ID или ФИО сотрудника, которого нужно удалить.
                                                                                                  //Далее метод проходит по списку работников и ищет тех, чьё ФИО или ID совпадают с введенным пользователем.
                                                                                                  //Если находится более одного сотрудника с таким ФИО, то пользователь должен уточнить ID нужного сотрудника.
            string removeEmp = Console.ReadLine();
            int counter = 0;

            foreach (var emp in employees)
            {
                if (removeEmp == emp.FIO)
                {
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.FIO}, Отдел: {emp.Department}, Зарплата: {emp.Salary}");
                    counter++;
                }
            }

            if (counter > 1)
            {
                Console.Write("Уточните ID сотрудника для удаления: ");
                removeEmp = Console.ReadLine();
            }

            foreach (var emp in employees)
            {
                if (removeEmp == emp.ID.ToString())
                {
                    employees.RemoveAt(emp.ID);
                    Console.WriteLine("Сотрудник удалён");
                    break;
                }
            }
        }

        public void Edit()
        {
            Console.Write("Введите ID или ФИО сотрудника: ");                                                                    //Данный метод предназначен для редактирования данных конкретного сотрудника в списке работников компании.
                                                                                                                                 //При вызове метода пользователь должен ввести ID или ФИО сотрудника, чьи данные он хочет отредактировать.
                                                                                                                                 //Затем метод ищет в списке работников сотрудника с введенным ID или ФИО и в случае успешного нахождения выводит информацию
                                                                                                                                 //о нем на экран.Пользователю предлагается выбрать, какие данные необходимо изменить: зарплату, отдел или зарплату и отдел сразу.
            string empInfo = Console.ReadLine();
            int counter = 0;

            foreach (var emp in employees)
            {
                if (empInfo == emp.FIO)
                {
                    Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.FIO}, Отдел: {emp.Department}, Зарплата: {emp.Salary}");
                    counter++;
                }
            }

            Console.WriteLine("Введите чтобы изменить: \n" + "1 - Зарплату\n" + "2 - Отдел\n" + "3 - Зарплату и отдел");
            string action = Console.ReadLine();

            foreach (var emp in employees)
            {
                if (empInfo == emp.ID.ToString())
                {
                    switch (action)
                    {
                        case "1":
                            Console.Write("Введите зарплату сотрудника: ");
                            action = Console.ReadLine();
                            emp.Salary = Convert.ToInt32(action);
                            break;
                        case "2":
                            Console.Write("Введите отдел сотрудника: ");
                            action = Console.ReadLine();
                            emp.Department = Convert.ToInt32(action);
                            break;
                        case "3":
                            Console.Write("Введите зарплату сотрудника: ");
                            action = Console.ReadLine();
                            emp.Salary = Convert.ToInt32(action);
                            Console.Write("Введите отдел сотрудника: ");
                            action = Console.ReadLine();
                            emp.Department = Convert.ToInt32(action);
                            break;
                    }

                    Console.WriteLine("Данные сотрудника изменены");
                    break;
                }
            }
        }

        public void EmployeesDepartments()                                                           //Данный метод предназначен для вывода списка сотрудников компании, отсортированных по отделам.
                                                                                                     //Внутри метода используется цикл for для перебора всех отделов в компании, начиная с первого и заканчивая пятым.
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i + "-й отдел: ");
                foreach (var emp in employees)
                {
                    if (i == emp.Department)
                    {
                        Console.WriteLine($"ID: {emp.ID}, ФИО: {emp.FIO}, Зарплата: {emp.Salary}");
                    }
                }
            }
        }
    }
}
