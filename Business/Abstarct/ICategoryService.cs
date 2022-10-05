using Entities.Concrete;

namespace Business.Abstarct
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
