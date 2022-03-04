using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPH1Aflevering.CodesProjekt
{
    internal abstract class Schooling
    {
        public SchoolingCategory SchoolingName { get; set; }

        List<TECPerson>? Teachers { get; set; }

        List<string>? Courses { get; set; }

      

        public virtual void SetCourses()
        {
            //Loop through enum values and insert enum value as string in list
            foreach(CourseCategory item in Enum.GetValues(typeof(CourseCategory)))
            {
                Courses?.Add(item.ToString());
            }

        }


        public abstract string GetTeacher();


        //constructor
        public Schooling(Schooling schoolingName)
        {

            //Teacher list
            Teachers = new List<TECPerson>()
            {
                new() {FullName = "Niels Olesen", SchoolingName = SchoolingCategory.Programmeringslinje},

                new() {FullName = "Bo Hansen", SchoolingName = SchoolingCategory.Supporterlinje},

                new() {FullName = "Ole Nielesen", SchoolingName = SchoolingCategory.Infrastrukturlinje},

            };

        }

    }
}
