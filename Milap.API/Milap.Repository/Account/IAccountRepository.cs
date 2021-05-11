using Milap.Model.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Milap.Repository.Account
{
    public interface IAccountRepository
    {
        #region Auth Module
        /// <summary>
        /// This method is use for login user
        /// </summary>
        /// <param name="loginAC"></param>
        /// <returns></returns>
        Task<BaseResponseModel> ValidateUserAsync(LoginDTO loginDTO);
        /// <summary>
        /// This method is use for signup new user
        /// </summary>
        /// <param name="userDetailDTO"></param>
        /// <returns></returns>
        Task<BaseResponseModel> SignUpAsync(UserDetailDTO userDetailDTO);

        /// <summary>
        /// This method is use for send otp in email and message
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        Task<bool> sendOTPtoEmailAndMessageForConfirm(string email);
        #endregion
    }
}
