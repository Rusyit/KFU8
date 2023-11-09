using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Создание проекта");
            Person semen = new Person("Рустам", Persons.Тимплид);
            Person rashid = new Person("Рашид", Persons.Главный_разраб);
            Person lucas = new Person("Рустам1", Persons.Главный_разраб);
            Person alkham = new Person("Рашид1", Persons.Разраб);
            Person orkady = new Person("Данис", Persons.Разраб);
            Person volodya = new Person("Леха", Persons.Разраб);
            Person iltash = new Person("Саня", Persons.Разраб);
            Person ivanich = new Person("Саня1", Persons.Разраб);
            Person ilya = new Person("Илья", Persons.Художник);
            Person vitya = new Person("Витя", Persons.Художник);
            Person zhenya = new Person("Женя", Persons.Художник);
            Console.WriteLine("Укажите тему преокта");
            Console.WriteLine("\nДля того чтобы выбрать разработку веб сайта для КФУ, нажмите 1" + 
                "\nДля того чтобы выбрать разработку мобильной игры CSGO, нажмите 2" +
                "\nДля того чтобы выбрать разработку базы данных, нажмите 3");
            bool flag = uint.TryParse(Console.ReadLine(), out uint number);
            if (flag)
            {
                switch (number)
                {
                    case 1:
                        Project web_site = new Project("Разработка веб сайта КФУ", new DateTime(2023,11,20), "Виталик", semen, Status_Project.Проект);
                        if (web_site.Сhecking_Project_Status() == Status_Project.Проект)
                        {
                            Console.WriteLine("Теперь ваш проект находится в статусе <Проект>, теперь дадим каждому сотруднику задачу");
                            Task web_task_1 = new Task("Назначить задачи всем сотрудникам", new DateTime(2023,11,09), "Рустам", Status_Task.Назначена);
                            Task web_task_2 = new Task("Разработать программу сайта", new DateTime(2023,11,10), "Рустам", "Рашид", Status_Task.Назначена);
                            Task web_task_3 = new Task("Разработать личный кабинет для учителя",new DateTime(2023,11,11), "Рустам", "Рустам1" , Status_Task.Назначена);
                            Task web_task_4 = new Task("Разработать личный кабинет для ученика", new DateTime(2023,11,12),"Рустам", "Рашид1", Status_Task.Назначена);
                            Task web_task_5 = new Task("Создать программу для входа <Логин, пароль>",new DateTime(2023,11,13), "Рустам", "Данис", Status_Task.Назначена);
                            Task web_task_6 = new Task("Создать ссылку сайта школы в браузере",new DateTime(2023,11,14), "Рустам", "Леха", Status_Task.Назначена);
                            Task web_task_7 = new Task("Разработать код для безопасности",new DateTime(2023,11,15), "Рустам", "Саня", Status_Task.Назначена);
                            Task web_task_8 = new Task("Пофиксить все баги предыдущих разработчиков",new DateTime(2023,11,16), "Рустам", "Саня1", Status_Task.Назначена);
                            Task web_task_9 = new Task("Разработать интерфейсы",new DateTime(2023,11,17), "Рустам", "Илья", Status_Task.Назначена);
                            Task web_task_10 = new Task("Нарисовать главную страницу школьного сайта",new DateTime(2023,11,17), "Рустам", "Витя", Status_Task.Назначена);
                            Task web_task_11 = new Task("Нарисовать остальные странички сайта",new DateTime(2023,11,18), "Рустам", "Женя", Status_Task.Назначена);
                            Console.WriteLine();
                            Console.WriteLine("На этом проекте все участники команды взяли по одной задаче");
                            Console.WriteLine();
                            semen.AddTask(web_task_1);
                            rashid.AddTask(web_task_2);
                            lucas.AddTask(web_task_3);
                            alkham.AddTask(web_task_4);
                            orkady.AddTask(web_task_5);
                            volodya.AddTask(web_task_6);
                            iltash.AddTask(web_task_7);
                            ivanich.AddTask(web_task_8);
                            ilya.AddTask(web_task_9);
                            vitya.AddTask(web_task_10);
                            zhenya.AddTask(web_task_11);
                            Console.WriteLine();
                            Console.WriteLine("После этого все задачи перешли в статус <В работе>");
                            Console.WriteLine();
                            web_task_1.StartTask(web_task_1);
                            web_task_2.StartTask(web_task_2);
                            web_task_3.StartTask(web_task_3);
                            web_task_4.StartTask(web_task_4);
                            web_task_5.StartTask(web_task_5);
                            web_task_6.StartTask(web_task_6);
                            web_task_7.StartTask(web_task_7);
                            web_task_8.StartTask(web_task_8);
                            web_task_9.StartTask(web_task_9);
                            web_task_10.StartTask(web_task_10);
                            web_task_11.StartTask(web_task_11);
                            Console.WriteLine();
                            Console.WriteLine("После того, как все задачи были в статусе работы, они перешли в статус <проверки>");
                            Console.WriteLine();
                            web_task_1.ExaminationTask(web_task_1);
                            web_task_2.ExaminationTask(web_task_2);
                            web_task_3.ExaminationTask(web_task_3);
                            web_task_4.ExaminationTask(web_task_4);
                            web_task_5.ExaminationTask(web_task_5);
                            web_task_6.ExaminationTask(web_task_6);
                            web_task_7.ExaminationTask(web_task_7);
                            web_task_8.ExaminationTask(web_task_8);
                            web_task_9.ExaminationTask(web_task_9);
                            web_task_10.ExaminationTask(web_task_10);
                            web_task_11.ExaminationTask(web_task_11);
                            Console.WriteLine();
                            Task[] web_tasks = new Task[] { web_task_1, web_task_2, web_task_3, web_task_4, web_task_5, web_task_6, web_task_7,
                                web_task_8, web_task_9, web_task_10, web_task_11};
                            Console.WriteLine();
                            Report web_report_1 = new Report(web_tasks[0].Report(web_tasks[0]));
                            Report web_report_2 = new Report(web_tasks[1].Report(web_tasks[1]));
                            Report web_report_3 = new Report(web_tasks[2].Report(web_tasks[2]));
                            Report web_report_4 = new Report(web_tasks[3].Report(web_tasks[3]));
                            Report web_report_5 = new Report(web_tasks[4].Report(web_tasks[4]));
                            Report web_report_6 = new Report(web_tasks[5].Report(web_tasks[5]));
                            Report web_report_7 = new Report(web_tasks[6].Report(web_tasks[6]));
                            Report web_report_8 = new Report(web_tasks[7].Report(web_tasks[7]));
                            Report web_report_9 = new Report(web_tasks[8].Report(web_tasks[8]));
                            Report web_report_10 = new Report(web_tasks[9].Report(web_tasks[9]));
                            Report web_report_11 = new Report(web_tasks[10].Report(web_tasks[10]));
                            Console.WriteLine();
                            web_report_1.ResultReport(web_report_1);
                            web_report_2.ResultReport(web_report_2);
                            web_report_3.ResultReport(web_report_3);
                            web_report_4.ResultReport(web_report_4);
                            web_report_5.ResultReport(web_report_5);
                            web_report_6.ResultReport(web_report_6);
                            web_report_7.ResultReport(web_report_7);
                            web_report_8.ResultReport(web_report_8);
                            web_report_9.ResultReport(web_report_9);
                            web_report_10.ResultReport(web_report_10);
                            web_report_11.ResultReport(web_report_1);
                            Console.WriteLine();
                            Report[] reports_1 = { web_report_1, web_report_2, web_report_3, web_report_4, web_report_5, web_report_6, web_report_7,
                                
                                web_report_8, web_report_9, web_report_10, web_report_11 };
                            int web_report = 0;
                            for (int i = 0; i < reports_1.Length; i++)
                            {
                                reports_1[i].CountTask(reports_1[i]);
                                web_report += reports_1[i].CountTask(reports_1[i]);
                            }   
                            if (web_report >= 11)
                            {
                                Console.WriteLine("Ваш проект выполнен");
                            }
                            else
                            {
                                Console.WriteLine("Ваш проект не выполнен, так как не все приняли задачу");
                            }
                            
                        }
                        else
                        {
                            Console.WriteLine("Ваш проект находится в статусе <Исполнения> или <Закрыт>, мы не можем начинать работу");
                        }
                        break;
                    case 2:
                        Project game = new Project("Разработка мобильной игры CSGO", new DateTime(2023, 11, 20), "Данилка", semen, Status_Project.Проект);
                        if(game.Сhecking_Project_Status() == Status_Project.Проект)
                        {
                            Console.WriteLine("Теперь ваш проект находится в статусе <Проект>, теперь дадим каждому сотруднику задачу");
                            Task task_game_1 = new Task("Назначить задачи всем сотрудникам", new DateTime(2023, 11, 09), "Рустам", Status_Task.Назначена);
                            Task task_game_2 = new Task("Создать скин Огонь чантико", new DateTime(2023, 11, 10), "Рустам", "Рашид", Status_Task.Назначена);
                            Task task_game_3 = new Task("Создать скин Тригер дисциплин", new DateTime(2023, 11, 11), "Рустам", "Рустам1", Status_Task.Назначена);
                            Task task_game_4 = new Task("Создать скин Экзо скелет", new DateTime(2023, 11, 12), "Рустам", "Рашид1", Status_Task.Назначена);
                            Task task_game_5 = new Task("Создать скин Свипер", new DateTime(2023, 11, 13), "Рустам", "Данис", Status_Task.Назначена);
                            Task task_game_6 = new Task("Создать скин Предатор", new DateTime(2023, 11, 14), "Рустам", "Леха", Status_Task.Назначена);
                            Task task_game_7 = new Task("Создать скин Драгон Лор", new DateTime(2023, 11, 15), "Рустам", "Саня", Status_Task.Назначена);
                            Task task_game_8 = new Task("Создать скин Азимов", new DateTime(2023, 11, 16), "Рустам", "Саня1", Status_Task.Назначена);
                            Task task_game_9 = new Task("Нарисовать карты", new DateTime(2023, 11, 17), "Рустам", "Илья", Status_Task.Назначена);
                            Task task_game_10 = new Task("Нарисовать главное меню", new DateTime(2023, 11, 18), "Рустам", "Витя", Status_Task.Назначена);
                            Task task_game_11 = new Task("Протестировать анимацию боя", new DateTime(2023, 11, 19), "Рустам", "Женя", Status_Task.Назначена);
                            Console.WriteLine();
                            Console.WriteLine("Добавили задачу каждому разработчику");
                            Console.WriteLine();
                            semen.AddTask(task_game_1);
                            rashid.AddTask(task_game_2);
                            lucas.AddTask(task_game_3);
                            alkham.AddTask(task_game_4);
                            orkady.AddTask(task_game_5);
                            volodya.AddTask(task_game_6);
                            iltash.AddTask(task_game_7);
                            ivanich.AddTask(task_game_8);
                            ilya.AddTask(task_game_9);
                            vitya.AddTask(task_game_10);
                            zhenya.AddTask(task_game_11);
                            Console.WriteLine("Но один разработчик решил отказаться от задачи");
                            lucas.RemoveTask(task_game_3);
                            Console.WriteLine();
                            Console.WriteLine("Все задачи, которые были назначены, перешли в статус <В работе>");
                            Console.WriteLine();
                            task_game_1.StartTask(task_game_1);
                            task_game_2.StartTask(task_game_2);
                            task_game_3.StartTask(task_game_3); 
                            task_game_4.StartTask(task_game_4);
                            task_game_5.StartTask(task_game_5);
                            task_game_6.StartTask(task_game_6);
                            task_game_7.StartTask(task_game_7);
                            task_game_8.StartTask(task_game_8);
                            task_game_9.StartTask(task_game_9);
                            task_game_10.StartTask(task_game_10);
                            task_game_11.StartTask(task_game_11);
                            Console.WriteLine();
                            Console.WriteLine();
                            task_game_1.ExaminationTask(task_game_1);
                            task_game_2.ExaminationTask(task_game_2);
                            task_game_3.ExaminationTask(task_game_3);
                            task_game_4.ExaminationTask(task_game_4);
                            task_game_5.ExaminationTask(task_game_5);
                            task_game_6.ExaminationTask(task_game_6);
                            task_game_7.ExaminationTask(task_game_7);
                            task_game_8.ExaminationTask(task_game_8);
                            task_game_9.ExaminationTask(task_game_9);
                            task_game_10.ExaminationTask(task_game_10);
                            task_game_11.ExaminationTask(task_game_11);
                            Console.WriteLine();
                            Task[] task_games =  { task_game_1, task_game_2, task_game_3, task_game_4, task_game_5, task_game_6, task_game_7,
                            task_game_8, task_game_9, task_game_10, task_game_11};
                            Console.WriteLine();
                            Report game_report_1 = new Report(task_games[0].Report(task_games[0]));
                            Report game_report_2 = new Report(task_games[1].Report(task_games[1]));
                            Report game_report_3 = new Report(task_games[2].Report(task_games[2]));
                            Report game_report_4 = new Report(task_games[3].Report(task_games[3]));
                            Report game_report_5 = new Report(task_games[4].Report(task_games[4]));
                            Report game_report_6 = new Report(task_games[5].Report(task_games[5]));
                            Report game_report_7 = new Report(task_games[6].Report(task_games[6]));
                            Report game_report_8 = new Report(task_games[7].Report(task_games[7]));
                            Report game_report_9 = new Report(task_games[8].Report(task_games[8]));
                            Report game_report_10 = new Report(task_games[9].Report(task_games[9]));
                            Report game_report_11 = new Report(task_games[10].Report(task_games[10]));
                            Console.WriteLine();
                            game_report_1.ResultReport(game_report_1);
                            game_report_2.ResultReport(game_report_2);
                            game_report_3.ResultReport(game_report_3);
                            game_report_4.ResultReport(game_report_4);
                            game_report_5.ResultReport(game_report_5);
                            game_report_6.ResultReport(game_report_6);
                            game_report_7.ResultReport(game_report_7);
                            game_report_8.ResultReport(game_report_8);
                            game_report_9.ResultReport(game_report_9);
                            game_report_10.ResultReport(game_report_10);
                            game_report_11.ResultReport(game_report_11);
                            Console.WriteLine();
                            Report[] reports_2 = { game_report_1, game_report_2, game_report_3, game_report_4, game_report_5, game_report_6,
                            game_report_7, game_report_8, game_report_9, game_report_10, game_report_11};
                            int game_count = 0;
                            for (int i = 0; i < reports_2.Length; i++)
                            {
                                reports_2[i].CountTask(reports_2[i]);
                                game_count += reports_2[i].CountTask(reports_2[i]);
                            }
                            if (game_count >= 11)
                            {
                                Console.WriteLine("Ваш проект выполнен");
                            }
                            else
                            {
                                Console.WriteLine("Ваш проект не выполнен, так как не все приняли задачу");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш проект находится в статусе <Исполнения> или <Закрыт>, мы не можем начинать работу");
                        }
                        break;
                    case 3:
                        Project database = new Project("Разработка базы данных", new DateTime(2023, 11, 20), "Алёшка", semen, Status_Project.Проект);
                        if(database.Сhecking_Project_Status() == Status_Project.Проект)
                        {
                            Console.WriteLine("Теперь ваш проект находится в статусе <Проект>, теперь дадим каждому сотруднику задачу");
                            Task data_task_1 = new Task("Дать задачи сотрудникам", new DateTime(2023, 11, 09), "Рустам", Status_Task.Назначена);
                            Task data_task_2 = new Task("Разработать базу данных", new DateTime(2023, 11, 10), "Рустам", "Рашид", Status_Task.Назначена);
                            Task data_task_3 = new Task("Создать первую библиотеку данных", new DateTime(2023, 11, 11), "Рустам", "Лукас", Status_Task.Назначена);
                            Task data_task_4 = new Task("Создать вторую библиотеку данных", new DateTime(2023, 11, 12), "Рустам", "Ольхам", Status_Task.Назначена);
                            Task data_task_5 = new Task("Создать третью библиотеку данных", new DateTime(2023, 11, 13), "Рустам", "Оркадий", Status_Task.Назначена);
                            Task data_task_6 = new Task("Разработать ИИ", new DateTime(2023, 11, 14), "Рустам", "Володя", Status_Task.Назначена);
                            Task data_task_7 = new Task("Разработать безопасность системы", new DateTime(2023, 11, 15), "Рустам", "Ильташ", Status_Task.Назначена);
                            Task data_task_8 = new Task("Протестировать базу данных", new DateTime(2023, 11, 16), "Рустам", "Иваныч", Status_Task.Назначена);
                            Task data_task_9 = new Task("Разработать интерфейсы", new DateTime(2023, 12, 17), "Рустам", "Илья", Status_Task.Назначена);
                            Task data_task_10 = new Task("Нарисовать таблицу баз данных", new DateTime(2023, 11, 18), "Рустам", "Витя", Status_Task.Назначена);
                            Task data_task_11 = new Task("Создать коллекцию адресов", new DateTime(2023, 11, 19), "Рустам", "Женя", Status_Task.Назначена);
                            Console.WriteLine();
                            Console.WriteLine("Все участники проекта получили задачи");
                            semen.AddTask(data_task_1);
                            rashid.AddTask(data_task_2);
                            lucas.AddTask(data_task_3);
                            alkham.AddTask(data_task_4);
                            orkady.AddTask(data_task_5);
                            volodya.AddTask(data_task_6);
                            iltash.AddTask(data_task_7);
                            ivanich.AddTask(data_task_8);
                            ilya.AddTask(data_task_9);
                            vitya.AddTask(data_task_10);
                            zhenya.AddTask(data_task_11);
                            Console.WriteLine();
                            Console.WriteLine("Но один работник передал задачу другому человеку");
                            Console.WriteLine();
                            lucas.RemoveTask(data_task_3);
                            rashid.SubmitTask(data_task_3, lucas);
                            Console.WriteLine();
                            data_task_1.StartTask(data_task_1);
                            data_task_2.StartTask(data_task_2);
                            data_task_3.StartTask(data_task_3);
                            data_task_4.StartTask(data_task_4);
                            data_task_5.StartTask(data_task_5);
                            data_task_6.StartTask(data_task_6);
                            data_task_7.StartTask(data_task_7);
                            data_task_8.StartTask(data_task_8);
                            data_task_9.StartTask(data_task_9);
                            data_task_10.StartTask(data_task_10);
                            data_task_11.StartTask(data_task_11);
                            Console.WriteLine();
                            data_task_1.ExaminationTask(data_task_1);
                            data_task_2.ExaminationTask(data_task_2);
                            data_task_3.ExaminationTask(data_task_3);
                            data_task_4.ExaminationTask(data_task_4);
                            data_task_5.ExaminationTask(data_task_5);
                            data_task_6.ExaminationTask(data_task_6);
                            data_task_7.ExaminationTask(data_task_7);
                            data_task_8.ExaminationTask(data_task_8);
                            data_task_9.ExaminationTask(data_task_9);
                            data_task_10.ExaminationTask(data_task_10);
                            data_task_11.ExaminationTask(data_task_11);
                            Console.WriteLine();
                            Task[] task_datas = {data_task_1, data_task_2, data_task_3, data_task_4, data_task_5, data_task_6, data_task_7,
                            data_task_8, data_task_9, data_task_10, data_task_11};
                            Report data_report_1 = new Report(task_datas[0].Report(task_datas[0]));
                            Report data_report_2 = new Report(task_datas[1].Report(task_datas[1]));
                            Report data_report_3 = new Report(task_datas[2].Report(task_datas[2]));
                            Report data_report_4 = new Report(task_datas[3].Report(task_datas[3]));
                            Report data_report_5 = new Report(task_datas[4].Report(task_datas[4]));
                            Report data_report_6 = new Report(task_datas[5].Report(task_datas[5]));
                            Report data_report_7 = new Report(task_datas[6].Report(task_datas[6]));
                            Report data_report_8 = new Report(task_datas[7].Report(task_datas[7]));
                            Report data_report_9 = new Report(task_datas[8].Report(task_datas[8]));
                            Report data_report_10 = new Report(task_datas[9].Report(task_datas[9]));
                            Report data_report_11 = new Report(task_datas[10].Report(task_datas[10]));
                            Console.WriteLine();
                            data_report_1.ResultReport(data_report_1);
                            data_report_2.ResultReport(data_report_2);
                            data_report_3.ResultReport(data_report_3);
                            data_report_4.ResultReport(data_report_4);
                            data_report_5.ResultReport(data_report_5);
                            data_report_6.ResultReport(data_report_6);
                            data_report_7.ResultReport(data_report_7);
                            data_report_8.ResultReport(data_report_8);
                            data_report_9.ResultReport(data_report_9);
                            data_report_10.ResultReport(data_report_10);
                            data_report_11.ResultReport(data_report_11);
                            Report[] reports_3 = {data_report_1, data_report_2, data_report_3, data_report_4, data_report_5, data_report_6,
                            data_report_7, data_report_8, data_report_9, data_report_10, data_report_11};
                            int data_count = 0;
                            for (int i = 0; i < reports_3.Length; i++)
                            {
                                reports_3[i].CountTask(reports_3[i]);
                                data_count += reports_3[i].CountTask(reports_3[i]);
                            }
                            if (data_count >= 11)
                            {
                                Console.WriteLine("Ваш проект выполнен");
                            }
                            else
                            {
                                Console.WriteLine("Ваш проект не выполнен, так как не все приняли задачу");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Ваш проект находится в статусе <Исполнения> или <Закрыт>, мы не можем начинать работу");
                        }
                        break;
                    default:
                        Console.WriteLine("Такой команды нет");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Нельзя вводить строки, символы и отрицательные значения");
            }
            Console.WriteLine("Для того чтобы закрыть программу, нажмите на любую клавишу");
            Console.ReadKey();
        }
    }
}
