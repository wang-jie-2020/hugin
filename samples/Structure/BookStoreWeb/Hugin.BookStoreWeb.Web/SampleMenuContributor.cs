using System.Threading.Tasks;
using Hugin.BookStore.Localization;
using Hugin.Sample.BookStore.Permissions;
using Volo.Abp.UI.Navigation;

namespace Hugin.Sample.Web
{
    public class SampleMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.GetLocalizer<BookStoreResource>();

            var sampleMenu = new ApplicationMenuItem(name: "Sample", displayName: l["Menu:Sample"]);
            context.Menu.AddItem(sampleMenu);

            var bookStoreMenu = new ApplicationMenuItem(name: "BooksStore", displayName: l["Menu:BookStore"], icon: "fa fa-book");
            sampleMenu.AddItem(bookStoreMenu);

            if (await context.IsGrantedAsync(BookStorePermissions.Book.Default))
            {
                bookStoreMenu.AddItem(new ApplicationMenuItem(name: "BooksStore.Books", displayName: l["Menu:Books"], url: "/BookStore/Books"));
            }
        }
    }
}

