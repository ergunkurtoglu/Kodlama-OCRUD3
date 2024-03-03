using KodlamaİOCRUD3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİOCRUD3.Business.Abstracts;

public interface ICourseDal
{
    void Add(Course course);
    void Delete(Course course);
    void Update(Course course);
}
