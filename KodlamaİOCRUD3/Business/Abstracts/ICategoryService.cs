using KodlamaİOCRUD3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaİOCRUD3.Business.Abstracts;

public interface ICategoryService
{
    void Add(Category category);
    void Delete(Category category);
    void Update(Category category);
    List<ICategoryService> GetAll();
}
