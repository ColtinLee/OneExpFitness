using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OneExpFitness.Repository.Managers
{
    using Context;
    using ViewModels;
    using Models;

    public class GymManager
    {
        private readonly OneExpFitnessContext _dbContext;

        //creating dbcontext upon creation of manager
        public GymManager(OneExpFitnessContext dbContext)
        {
            _dbContext = dbContext;
        }

        //created Get region, to separate multiple gets in manager.
        #region Gets
        /// <summary>
        /// Gets all current gyms, from the db context.
        /// </summary>
        /// <returns></returns>
        public List<GymViewModel> GetGyms()
        {
            return (from gym in _dbContext.Gyms
                    select new GymViewModel
                    {
                        GymId = gym.GymId,
                        GymName = gym.GymName,
                        GymPrice = gym.GymPrice,
                        GymAddress1 = gym.GymAddress1,
                        GymAddress2 = gym.GymAddress2,
                        GymUrl = gym.GymUrl
                    })
                   .ToList();
        }

        /// <summary>
        /// Get specific gym
        /// </summary>
        /// <param name="GymId"></param>
        /// <returns></returns>
        public GymViewModel GetByGymId(int GymId)
        {
            return (from gym in _dbContext.Gyms
                    where gym.GymId == GymId
                    select new GymViewModel
                    {
                        GymId = gym.GymId,
                        GymName = gym.GymName,
                        GymPrice = gym.GymPrice,
                        GymAddress1 = gym.GymAddress1,
                        GymAddress2 = gym.GymAddress2,
                        GymUrl = gym.GymUrl
                    })
                   .FirstOrDefault();
        }
        #endregion

        /// <summary>
        /// Create Gym, receives a model (new gym), and pushes into Gym, via db context
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int CreateGym(GymViewModel model)
        {
            int gymId = 0;

            Gym entity = new Gym
            {
                GymName = model.GymName,
                GymPrice = model.GymPrice,
                GymAddress1 = model.GymAddress1,
                GymAddress2 = model.GymAddress2,
                GymUrl  = model.GymUrl
            };

            //inside of gym table, add in information being passed down
            _dbContext.Gyms.Add(entity);

            try
            {                
                //save changes, updates table and creates a gym id
                _dbContext.SaveChanges();

                //gym id is available via savechanges
                gymId = entity.GymId;
            }
            catch (Exception)
            {

                throw;
            }

            return gymId;
        }

        /// <summary>
        /// Update gym, IF we find the ID of the gym being changed
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public int UpdateGym(GymViewModel model)
        {
            int rowsAffected = 0;

            Gym entity = _dbContext.Gyms.Find(model.GymId);

            if (entity != null)
            {
                entity.GymName = model.GymName;
                entity.GymPrice = model.GymPrice;
                entity.GymAddress1 = model.GymAddress1;
                entity.GymAddress2 = model.GymAddress2;
                entity.GymUrl = model.GymUrl;

                try
                {
                    rowsAffected = _dbContext.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return rowsAffected;
        }

        /// <summary>
        /// Allows gym to be deleted, if gym is found in context.
        /// </summary>
        /// <param name="GymId"></param>
        /// <returns></returns>
        public int DeleteGym(int GymId)
        {
            int rowsAffected = 0;

            Gym entity = _dbContext.Gyms.Find(GymId);

            if (entity != null)
            {
                _dbContext.Gyms.Remove(entity);
                try
                {                    
                    rowsAffected = _dbContext.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return rowsAffected;
        }

        
        
        //todo: Add in GetGymsByZipCode(string ZipCode)
    }
}
