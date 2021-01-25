using Claim.ClaimService.Data;
using Claim.ClaimService.Data.DataModel;
using Claim.IdentityService.Application.Service.User;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Claim.IdentityService.Application.Service
{
    public class UserService : IUserService
    {
        
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task CreateUser(AppUser user)
        {
            await unitOfWork.UserRepository.Create(user);
            await unitOfWork.Complete();
        }

        public async Task DeleteUser(int id)
        {
            var user = await unitOfWork.UserRepository.GetById(id);
            unitOfWork.UserRepository.Delete(user);
            await unitOfWork.Complete();
        }

        public async Task<AppUser> GetUser(int userId)
        {
            var userData = await unitOfWork.UserRepository.GetById(userId);
            await unitOfWork.Complete();
            return userData;
        }

        public async Task<List<AppUser>> GetUsers()
        {
            var userData = await unitOfWork.UserRepository.GetAll();
            await unitOfWork.Complete();
            return userData;

        }

        public async Task UpdateUser(AppUser user)
        {
             unitOfWork.UserRepository.Update(user);
            await unitOfWork.Complete();
        }
    }
}
