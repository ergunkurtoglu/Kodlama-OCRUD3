using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİOCRUD3.Entities;

internal class Instructor
{
    public int Id { get; set; }
    public int CourseInstructorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
