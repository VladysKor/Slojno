using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slojno
{
    internal class Employee
    {
        private static int _Counter = 1;                                               //Этот класс является моделью сотрудника компании и содержит данные о его идентификаторе,
                                                                                       //ФИО, отделе и зарплате.В конструкторе класса идентификатор каждого нового сотрудника увеличивается на 1
                                                                                       //относительно предыдущего сотрудника, таким образом, каждому сотруднику присваивается уникальный идентификатор.
                                                                                       //Доступ к полям ФИО, отдела и зарплаты осуществляется через свойства,
                                                                                       //которые определены с помощью ключевых слов get и set.Кроме того, класс содержит статическую переменную _Counter,
                                                                                       //которая хранит количество созданных сотрудников и используется для присвоения каждому сотруднику уникального идентификатора.
        public int ID;

        private string _FIO { get; set; }
        private int _Department { get; set; }
        private double _Salary { get; set; }

        public Employee(string fio, int department, int salary)
        {
            ID = Counter;
            Counter++;
            _FIO = fio;
            _Department = department;
            _Salary = salary;
        }

        public string FIO
        {
            get => _FIO;
            set => _FIO = value;
        }

        public int Department
        {
            get => _Department;
            set => _Department = value;
        }

        public double Salary
        {
            get => _Salary;
            set => _Salary = value;
        }

        public int Counter
        {
            get => _Counter;
            set => _Counter = value;
        }
    }
}
