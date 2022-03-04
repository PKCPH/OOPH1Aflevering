using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.CodesProjekt
{
    internal class Course : Schooling
    {
        //Base() fix
        public Course(Schooling schoolingName) : base(schoolingName)
        {
            SetCourses();
            SchoolingName = SchoolingName;

        }


        List<string>? SchoolingCourse { get; set; }
        public SchoolingCategory Programmeringslinje { get; }

        public override void SetCourses()
        {
            base.SetCourses();

            //Error CS1929 (x is not null)

            ////If Programming
            //if(SchoolingName == SchoolingCategory.Programmeringslinje)
            //{

            //    List<string> schoolingCourses = 
            //        Course.Where(x => x.Contains("Programmerings")).ToList();

            //}

            ////If Supporter
            //if (SchoolingName == SchoolingCategory.Supporterlinje)
            //{

            //    List<string> schoolingCourses =
            //        Course.Where(x => x.Contains("server")).ToList();

            //}

            ////if Infrastucture
            //if (SchoolingName == SchoolingCategory.Infrastrukturlinje)
            //{

            //    List<string> schoolingCourses =
            //        Course.Where(x => x.Contains("netværk")).ToList();

            //}

        }


        //Exceptions
        private static object Where(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        public override string GetTeacher()
        {
            throw new NotImplementedException();
        }
    }
}
