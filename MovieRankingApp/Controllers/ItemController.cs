using Microsoft.AspNetCore.Mvc;
using MovieRankingApp.Controllers.Models;

namespace MovieRankingApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id = 1, Title = "The Godfather", ImageId = 1, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 2, Title = "Inception", ImageId = 2, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 3, Title = "Fractured", ImageId = 3, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 4, Title = "The Boss Baby", ImageId = 4, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 5, Title = "War", ImageId = 5, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 6, Title = "The Shawshank Redemption", ImageId = 6, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 7, Title = "Titanic", ImageId = 7, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 8, Title = "The Out-Laws", ImageId = 8, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 9, Title = "Closer", ImageId = 9, Ranking = 1, ItemType = 1},
            new ItemModel{Id = 10, Title = "The International", ImageId = 10, Ranking = 1, ItemType = 1},
        };

        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(x => x.ItemType == itemType).ToArray();
            System.Threading.Thread.Sleep(2000);
            return items;
        }
    }
}
