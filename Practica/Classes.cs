using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    enum Report_
    {
        текст_отчёта = 12,
        дата_выполнения = 13,
        исполнитель = 14
    }
    internal class Report
    {
        private int count_task;
        Person person;
        public Report(int count_task)
        {
            this.count_task = count_task;
        }

        public string ResultReport(Report report)
        {
            if (report.count_task == 1)
            {
                Console.WriteLine($"Отсчёт утвердился успешно, задача принята");
                return "Отсчёт утвердился успешно, задача принята";
            }
            else
            {
                Console.WriteLine($"Задачу нужно отправить на доработку");
                return "Задачу нужно отправить на доработку";
            }
        }

        public int CountTask(Report report)
        {
            if (report.count_task == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }

    enum Status_Task
    {
        Назначена = 8,
        В_работе = 9,
        На_проверке = 10,
        Выполнена = 11,
        Не_назначена
    }
    internal class Task
    {
        internal string description_ { get; set; }
        private DateTime time { get; set; }
        private string customer_ { get; set; }
        private string executor_ { get; set; }
        public Status_Task status_ { get; set; }

        private Project project { get; set; }

        public Task(string description_, DateTime time, string customer_, string executor_, Status_Task status_)
        {
            this.description_ = description_;
            this.time = time;
            this.customer_ = customer_;
            this.executor_ = executor_;
            this.status_ = status_;
        }
        public Task(string description_, DateTime time, string customer_, Status_Task status_)
        {
            this.description_ = description_;
            this.time = time;
            this.customer_ = customer_;
            this.executor_ = executor_;
            this.status_ = status_;
        }

        public void StartTask(Task task)
        {
            if (task.status_ == Status_Task.Назначена)
            {
                Console.WriteLine($"Задача (({task.description_})) перешла в статус <В работе>");
                task.status_ = Status_Task.В_работе;
            }
            else
            {
                Console.WriteLine($"Задача (({task.description_})) не перешла в статус <В работе>, так как её не выбрали");
            }
        }

        public void ExaminationTask(Task task)
        {
            if (task.status_ == Status_Task.В_работе)
            {
                Console.WriteLine($"Задача (({task.description_})) перешла с статус <На проверке>");
                task.status_ = Status_Task.На_проверке;
            }
            else
            {
                Console.WriteLine($"Задача (({task.description_})) не перешла в статус <На проверке>, так как её не выбрали");
            }
        }

        public int Report(Task task)
        {
            DateTime date = new DateTime(2023, 11, 20);
            if (task.status_ == Status_Task.На_проверке && task.time <= date)
            {
                Console.WriteLine($"Задача (({task.description_})) соответствует требованиям");
                return 1;
            }
            else
            {
                Console.WriteLine($"Задача (({task.description_} не соответствует требованиям))");
                return 0;
            }
        }
    }

    enum Status_Project
    {
        Проект = 5,
        Исполнение = 6,
        Закрыт = 7
    }
    internal class Project
    {
        private string description { get; set; }
        private DateTime time { get; set; }
        private string customer { get; set; }
        private Person person { get; set; }
        private Task task { get; set; }
        private Status_Project status { get; set; }

        public Project(string description, DateTime time, string customer, Person person, Status_Project status)
        {
            this.description = description;
            this.time = time;
            this.customer = customer;
            this.person = person;
            this.status = status;
        }

        public Status_Project Сhecking_Project_Status()
        {
            if (status == Status_Project.Проект)
            {
                return Status_Project.Проект;
            }
            else if (status == Status_Project.Исполнение)
            {
                return Status_Project.Исполнение;
            }
            else
            {
                return Status_Project.Закрыт;
            }
        }
    }

    enum Persons
    {
        Тимплид = 1,
        Главный_разраб = 2,
        Разраб = 3,
        Художник = 4,

    }
    internal class Person
    {
        private string name;
        private List<Task> tasks = new List<Task>();
        private Persons person;
        private Status_Task Status;
        public Person(string name, Persons person)
        {
            this.name = name;
            this.person = person;
        }
        public Person(string name, Task[] task, Status_Task status)
        {
            this.name = name;
            this.tasks.AddRange(task);
            Status = status;
        }

        public void AddTask(Task task)
        {
            Console.WriteLine($"{name} взял задачу: (({task.description_}))");
            task.status_ = Status_Task.Назначена;
            tasks.Add(task);
        }

        public void RemoveTask(Task task)
        {
            Console.WriteLine($"{name} решил отказаться от задачи: (({task.description_}))");
            task.status_ = Status_Task.Не_назначена;
            tasks.Remove(task);
        }

        public void SubmitTask(Task task, Person person)
        {
            Console.WriteLine($"{name} решил взять задачу {person.name}");
            task.status_ = Status_Task.Назначена;
        }
    }
}
