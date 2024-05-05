using Auctions.Models;

namespace Auctions.Data.Services
{
    public class CommentsService : ICommentsService
    {
        private readonly ApplicationDbContext _context;

        public CommentsService(ApplicationDbContext context)
        {
            _context = context;
        }


        public async Task Add(Comment comment)
        {
            if (comment == null)
            {
                throw new ArgumentNullException(nameof(comment));
            }
            
            _context.Comments.Add(comment);
            await _context.SaveChangesAsync();
        }
    }
}
