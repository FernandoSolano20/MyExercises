using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc_ajax_demo.Models
{
    public class InstructorRepository
    {
        public IEnumerable<Instructor> FindAll()
        {
            return _instructors;
        }

        public Instructor FindByID(int id)
        {
            return _instructors.Where(instructor => instructor.ID == id).First();
        }

        static List<Instructor> _instructors = new List<Instructor>()
        {
            new Instructor 
            { 
                    ID = 1,
                    Name="Fritz", 
                    Facts = new List<string>()
                    { 
                        "Hails from Maine", 
                        "Plays the classical guitar"
                    }
            },
            new Instructor 
            {
                ID = 2,
                Name="Scott",
                Facts = new List<string>()
                {
                    "Hails from MD",
                    "Plays the trumpet"
                }
            }
        };
    }
}
