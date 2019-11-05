using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HexQFormat.Models;

namespace HexQFormat.Services
{
    public class MockDataStore : IDataStore<Converter>
    {
        List<Converter> items;

        public MockDataStore()
        {
            items = new List<Converter>();
            var mockItems = new List<Converter>
            {
                new Converter { Id = Guid.NewGuid().ToString(), Text = "First item", Description="This is an item description." },
                new Converter { Id = Guid.NewGuid().ToString(), Text = "Second item", Description="This is an item description." },
                new Converter { Id = Guid.NewGuid().ToString(), Text = "Third item", Description="This is an item description." },
                new Converter { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
                new Converter { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
                new Converter { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." },
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Converter item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Converter item)
        {
            var oldItem = items.Where((Converter arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Converter arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Converter> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Converter>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}