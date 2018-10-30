using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using SQLite;


namespace A2_AppProject.Data
{
    public class TaskDatabase
    {
        readonly SQLiteAsyncConnection database;
        

        public TaskDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Models.TaskItem>().Wait();
        }

        public Task<List<Models.TaskItem>> GetItemsAsync()
        {
            return database.Table<Models.TaskItem>().ToListAsync();
        }

        public Task<List<Models.TaskItem>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Models.TaskItem>("SELECT * FROM [TaskItem] WHERE [Done] = 0");
        }

        public Task<Models.TaskItem> GetItemAsync(int id)
        {
            return database.Table<Models.TaskItem>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Models.TaskItem item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Models.TaskItem item)
        {
            return database.DeleteAsync(item);
        }
    }
}
