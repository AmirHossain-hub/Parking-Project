using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parking.DataLayer.Repositories;
using Parking.DataLayer.Services;

namespace Parking.DataLayer.Context
{
    public class db : DbContext
    {
        public db() : base("Parking_DBEntities3")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<db>());
        }
        // Your DbSet properties
    }
    public class UnitofWork:IDisposable
    {
        Parking_DBEntities3 db = new Parking_DBEntities3();
        private IRepository _repository;

        public UnitofWork()
        {
            db = new Parking_DBEntities3();
            db.Database.CreateIfNotExists(); // Explicitly create the database
        }

        public IRepository Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new Repository(db);
                }
                return _repository;
            }
        }
        private GenericRepository<GeneralInformation> _genericrepository;

        public GenericRepository<GeneralInformation> GenericRepository
        {
            get
            {
                if (_genericrepository == null)
                {
                    _genericrepository = new GenericRepository<GeneralInformation>(db);
                }
                return _genericrepository;
            }
        }

        public void Save()
        {
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                var errorMessage = new StringBuilder();

                foreach (var validationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string errorText = $"Property: {validationError.PropertyName} " +
                            $"Error: {validationError.ErrorMessage}";
                        errorMessage.AppendLine(errorText);
                    }
                }
                MessageBox.Show(errorMessage.ToString(),
                    "Validation Error",
                    System.Windows.Forms.MessageBoxButtons.OK, 
                    System.Windows.Forms.MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}",
                    "Error", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                throw; 
            }
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
