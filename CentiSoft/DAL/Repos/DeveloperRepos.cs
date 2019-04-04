using CentiSoft.DAL.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;

namespace CentiSoft.DAL.Repos {
    public class DeveloperRepos : IRepository<Developer> {
        public Func<IDbConnection> Connection { get; set; }

        public Developer Create(string name, string email) {
            using (var connection = Connection()) {
                int rowCount = connection.Execute("Insert into Developer(name, email) values(@name, @email)", new { name, email });
                if (rowCount == 1) {
                    return new Developer {
                        Name = name,
                        Email = email
                    };
                }
                else {
                    return null;
                }
            }
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IEnumerable<Developer> GetAll() {
            using (var connection = Connection()) {
                return connection.Query<Developer>("Select * from Developer").AsList();
            }
        }

        public Developer GetById(int id) {
            throw new NotImplementedException();
        }

        public void Insert(Developer entity) {
            throw new NotImplementedException();
        }

        public void Save() {
            throw new NotImplementedException();
        }

        public void Update(Developer entity) {
            throw new NotImplementedException();
        }
    }
    
}
