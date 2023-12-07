using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEduSystem
{
	public class StudyPlan
	{
		//Экзамены
		public static Exam examMath = new Exam(0, "Programming");
		public static Exam examEnglish = new Exam(1, "English");
		public static Exam examRussian = new Exam(2, "Russian");
		public static Exam fakeExam = new Exam(3, "Lection");
		//Список экзаменов
		public List<object> exams = new List<object>()
		{
			examMath.subject, examEnglish.subject, examRussian.subject
		};
		//Лекции

		//Практические

		//Тесты

		//Сам план составленный из всего этого вручную
		public List<object> eduPlan = new List<object>()
		{
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			fakeExam.subject,
			examMath.subject,
			examEnglish.subject,
		};

		



	}
}
