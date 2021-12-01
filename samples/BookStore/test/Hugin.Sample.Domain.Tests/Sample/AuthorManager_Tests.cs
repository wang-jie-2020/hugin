using LG.NetCore.Sample.BookStore.impl;

namespace LG.NetCore.Sample
{
    public class AuthorManager_Tests : SampleDomainTestBase
    {
        private readonly AuthorManager _authorManager;

        public AuthorManager_Tests()
        {
            _authorManager = GetRequiredService<AuthorManager>();
        }

        //[Fact]
        //public async Task Should_Not_Allow_To_Create_Duplicate_Author()
        //{
        //    await Assert.ThrowsAsync<AuthorAlreadyExistsException>(async () =>
        //    {
        //        await _authorManager.ChangeNameAsync(
        //            new Author(Guid.Empty, "Douglas Adams", DateTime.Now), "new name"
        //        );
        //    });
        //}
    }
}