using Volo.Abp;

namespace LG.NetCore.Sample.BookStore
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
