using Common;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessFacade
{
    public class UserDetailsSystem
    {
        public string InsertData(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.InsertData(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable GetType()
        {
            try
            {
                return UserDetailsData.GetType();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetUnitNames(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.GetUnitNames(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetRouteNames(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.GetRouteNames(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetFinAccount(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.GetFinAccount(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet GetSeqId(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.GetSeqId(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataSet GetFacilityCode(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.GetFacilityCode(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet UpdateSequenceId(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.UpdateSequenceId(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataSet GetpriceChartMaxMin(UserDetails Cmn)
        {
            try
            {
                return UserDetailsData.GetpriceChartMaxMin(Cmn);
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
