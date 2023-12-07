using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEduSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudyPlan plan = new StudyPlan();

			
			
				for (int i = 0;i<plan.eduPlan.Count;i++)
				{
					Console.WriteLine(i + " " + plan.eduPlan[i]);
					
				}
				



	
			//перебор листа
			//foreach (string classes in StudyPlan.educationPlan)
			//{
			//    Console.WriteLine(classes);
			//}
			//Вывести план обучения(некоторый список занятий)(можно через foreach)
			//Показать все дисциплины
			//Выбрать из показанных дисциплин
			//Показать все занятия по очередности
			//Показать информацию о конкретной лекции
			//Показать информацию о конкретном практическом занятии
			//Показать информацию о конкретном экзамене

			Console.ReadKey();
        }
    }
}
