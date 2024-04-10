using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public interface IAsyncRepository<TEntity, TEntityId> : IQueryable<TEntity>
    where TEntity : Entity<TEntityId>
    {
        Task<TEntity?> GetAsync(
        Expression<Func<TEntity, bool>> predicate,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default);


        Task<Paginate<TEntity>> GetListAsync(
       Expression<Func<TEntity, bool>>? predicate = null,
       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
       Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
       int index = 0,
       int size = 10,
       bool withDeleted = false,
       bool enableTracking = true,
       CancellationToken cancellationToken = default
       );


        Task<Paginate<TEntity>> GetListByDynamicAsync(
        DynamicQuery dynamic,
        Expression<Func<TEntity, bool>>? predicate = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
        int index = 0,
        int size = 10,
        bool withDeleted = false,
        bool enableTracking = true,
        CancellationToken cancellationToken = default
    );

        /*predicate = null ifadesi, predicate parametresinin varsayılan değerinin null olduğunu belirtir. Yani, eğer predicate parametresine herhangi bir değer atanmazsa veya null olarak belirtilirse, bu durumda filtreleme koşulu olarak herhangi bir şey belirtilmemiştir demektir.*/
        Task<bool> AnyAsync(
       Expression<Func<TEntity, bool>>? predicate = null,
       bool withDeleted = false,
       bool enableTracking = true,
       CancellationToken cancellationToken = default
   );


        Task<TEntity> AddAsync(TEntity entity);


        //Çoklu işlemler için range kullanılıyor
        Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entities);

        Task<TEntity> UpdateAsync(TEntity entity);

        Task<ICollection<TEntity>> UpdateRangeAsync(ICollection<TEntity> entities);



        /*permanent: Bu parametre, silme işleminin kalıcı olup olmayacağını belirlemek için kullanılır. Eğer permanent değeri true olarak belirtilirse, silme işlemi kalıcı olacaktır. Yani, veri tabanında ilgili kayıt tamamen silinecektir. Eğer permanent değeri false olarak belirtilirse, silme işlemi geçici olacaktır ve ilgili kayıt genellikle bir "soft delete" işlemi olarak işaretlenecektir.
         */
        Task<TEntity> DeleteAsync(TEntity entity, bool permanent = false);

        Task<ICollection<TEntity>> DeleteRangeAsync(ICollection<TEntity> entities, bool permanent = false);
    }


}
