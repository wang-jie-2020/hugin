﻿using System;
using System.Threading.Tasks;
using LG.NetCore.Sample.BookStore.Dtos;
using Shouldly;
using Xunit;

namespace LG.NetCore.Sample.BookStore
{
    public class AuthorAppService_Tests : SampleApplicationTestBase
    {
        private readonly IAuthorAppService _authorAppService;

        public AuthorAppService_Tests()
        {
            _authorAppService = GetRequiredService<IAuthorAppService>();
        }

        [Fact]
        public async Task Should_Get_All_Authors_Without_Any_Filter()
        {
            var result = await _authorAppService.GetListAsync(new AuthorQueryInput());

            result.TotalCount.ShouldBeGreaterThanOrEqualTo(2);
            result.Items.ShouldContain(author => author.Name == "George Orwell");
            result.Items.ShouldContain(author => author.Name == "Douglas Adams");
        }

        [Fact]
        public async Task Should_Get_Filtered_Authors()
        {
            var result = await _authorAppService.GetListAsync(
                new AuthorQueryInput { Filter = "George" });

            result.TotalCount.ShouldBeGreaterThanOrEqualTo(1);
            result.Items.ShouldContain(author => author.Name == "George Orwell");
            result.Items.ShouldNotContain(author => author.Name == "Douglas Adams");
        }

        [Fact]
        public async Task Should_Create_A_New_Author()
        {
            var authorDto = await _authorAppService.CreateAsync(
                new AuthorEditDto
                {
                    Name = "Edward Bellamy",
                    BirthDate = new DateTime(1850, 05, 22),
                    Profile = "Edward Bellamy was an American author..."
                }
            );

            authorDto.Id.ShouldNotBe(Guid.Empty);
            authorDto.Name.ShouldBe("Edward Bellamy");
        }

        [Fact]
        public async Task Should_Not_Allow_To_Create_Duplicate_Author()
        {
            await Assert.ThrowsAsync<AuthorAlreadyExistsException>(async () =>
            {
                await _authorAppService.CreateAsync(
                    new AuthorEditDto
                    {
                        Name = "Douglas Adams",
                        BirthDate = DateTime.Now,
                        Profile = "..."
                    }
                );
            });
        }
    }
}
