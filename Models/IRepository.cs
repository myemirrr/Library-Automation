using Library.EF;
using System.Linq.Expressions;

namespace Library.Models
{
    public interface IRepository<T> where T : class
    {
       // private readonly UygulamaDbContext _uygulamaDbContext;
        // T -> KitapTuru
        IEnumerable<T> GetAll(string? includeProps = null);
        T Get(Expression<Func<T, bool>> filtre, string? includeProps = null);
        void Ekle(T entity);
        void Sil(T entity);
        void SilAralik(IEnumerable<T> entities);
    }
}