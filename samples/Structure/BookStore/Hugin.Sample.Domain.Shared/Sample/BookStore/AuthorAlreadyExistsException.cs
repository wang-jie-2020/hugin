using Volo.Abp;

namespace Hugin.Sample.BookStore
{
    public class AuthorAlreadyExistsException : BusinessException
    {
        public AuthorAlreadyExistsException(string name)
            : base(BookStoreConsts.ErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
