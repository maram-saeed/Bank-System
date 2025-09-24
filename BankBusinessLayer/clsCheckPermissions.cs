using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsCheckPermissions
    {
        public static bool CheckAccessRights(clsUser.enPermissions Permission, clsUser CurrentUser)
        {
            if (!CurrentUser.CheckAccessPermission(Permission))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
