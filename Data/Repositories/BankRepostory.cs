using Core.Interfaces;
using Data.Interfaces;
using Model;
using EasyEncryption;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class BankRepository : IBankRepository
    {
        public string FileLocation { get; set; }
        public IWriteToFile Write;
        private IAccountServices AccountService;
        public List<Customer> Database { get; set; }
        public (string,string) _Temp { get; set; }// saves login data for a while after loading
        public BankRepository(IAccountServices AccountServices,IWriteToFile Write)
        {
            this.AccountService = AccountServices;
            this.Write = Write;
            // this section is used to read the database at first into the Memory
            var path = new DirectoryInfo(".").Parent.Parent.Parent;// get the file path and tranverses back
            var DataBaseLocation = Path.Combine(path.ToString(),"Database");

            // create the folder to be logged
            if(!Directory.Exists(DataBaseLocation)) Directory.CreateDirectory(DataBaseLocation);
            FileLocation = Path.Combine(DataBaseLocation, "DataBase.json");

            // this is the file loader method that automatically loadm thw file to the json file
            Write.fileLoader(this);// wrong operation change this approach later doesnt contain the an await
        }

        public async Task<bool> CreateCustomer(string fullname, string Password,string sex,string email)
        {
            var CreatingCustomer = AccountService.RegisterCustomer(fullname,Password,sex, email);

            var IsPassed = await Write.SaveCustomer(this,CreatingCustomer);
            _Temp = new(Password, email);// creates a session of the currently registered customer
            return IsPassed;
        }

    }
}
