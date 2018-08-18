using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
namespace AgendaXamarin
{
    public class PessoaItemDatabase
    {
        private readonly SQLiteAsyncConnection database;

        public PessoaItemDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Pessoa>().Wait();
        }

        public Task<List<Pessoa>> GetItemsAsync(){
            return database.Table<Pessoa>().ToListAsync();
        }

        public Task<Pessoa> GetItemAsync(int id){
            return database.Table<Pessoa>().Where(i => i.Id == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Pessoa item){
            if(item.Id != 0){
                return database.UpdateAsync(item);
            }
            else {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Pessoa item){
            return database.DeleteAsync(item);
        }
    }
}
