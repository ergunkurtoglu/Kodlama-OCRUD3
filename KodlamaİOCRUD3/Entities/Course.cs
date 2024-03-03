using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİOCRUD3.Entities;

public class Course
{
    public int CourseId { get; set; }
    public int CategoryId { get; set; }
    public string CourseName { get; set;}
    public string CourseDescription { get; set; }
    public double CoursePrice { get; set; }
    public int CourseInstructorId { get; set; }

}
