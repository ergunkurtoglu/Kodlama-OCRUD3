using KodlamaİOCRUD3.Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİOCRUD3.Business.Abstracts;

public interface IInstructorDal
{
    void Add(IInstructorDal instructor);
    void Delete(IInstructorDal ınstructor);
    void Update(IInstructorDal ınstructor);
    List<IInstructorDal> GetAll();
}
