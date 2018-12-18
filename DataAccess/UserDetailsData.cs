using Common;
using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace DataAccess
{
    public class UserDetailsData
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(UserDetailsData).Name);
        public static string connString = ConfigurationManager.ConnectionStrings["LocalSqlServer"].ToString();
        public static int intCommandTimeOut = int.Parse(ConfigurationManager.AppSettings["CommandTimeOut"].ToString());


        public static string InsertData(UserDetails Cmn)
        {
            //log.Info("InsertData method started");
            try
            {
                SqlParameter[] objParam = new SqlParameter[39];

                objParam[0] = new SqlParameter("@Type", Cmn.Type);
                objParam[1] = new SqlParameter("@UnitName", Cmn.UnitName);
                objParam[2] = new SqlParameter("@UnionName", Cmn.UnionName);
                objParam[3] = new SqlParameter("@Name", Cmn.Name);
                objParam[4] = new SqlParameter("@Code", Cmn.Code);
                objParam[5] = new SqlParameter("@having_b_m_c", Cmn.bmcsubcenter);
                objParam[6] = new SqlParameter("@type_of_m_p_c_s", Cmn.TypeOfMPCS);
                objParam[7] = new SqlParameter("@status_id", Cmn.Status);
                objParam[8] = new SqlParameter("@secretary_of_society", Cmn.SecretaryName);
                objParam[9] = new SqlParameter("@president_of_society_phone", Cmn.SecretaryMobile);
                objParam[10] = new SqlParameter("@hamlet_name", Cmn.HamletName);
                objParam[11] = new SqlParameter("@revenue_village", Cmn.RevenueVillage);
                objParam[12] = new SqlParameter("@revenue_number", Cmn.RevenueNumber);
                objParam[13] = new SqlParameter("@revenue_block", Cmn.RevenueBlock);
                objParam[14] = new SqlParameter("@assembly_constituency", Cmn.AssemblyName);
                objParam[15] = new SqlParameter("@parliment_constituency", Cmn.ParlimentaryConstituency);
                objParam[16] = new SqlParameter("@assembly_code", Cmn.AssemblyCode);
                objParam[17] = new SqlParameter("@block_code", Cmn.BlockCode);
                objParam[18] = new SqlParameter("@taluk", Cmn.TalukName);
                objParam[19] = new SqlParameter("@district", Cmn.District);
                objParam[20] = new SqlParameter("@taluk_code", Cmn.TalukCode);
                objParam[21] = new SqlParameter("@district_code", Cmn.DistrictCode);
                objParam[22] = new SqlParameter("@pin_code", Cmn.PinCode);
                objParam[23] = new SqlParameter("@fin_account_name", Cmn.BankName);
                objParam[24] = new SqlParameter("@bank_short_name", Cmn.ShortName);
                objParam[25] = new SqlParameter("@fin_account_branch", Cmn.FinACBranch);
                objParam[26] = new SqlParameter("@fin_account_code", Cmn.AccountNumber);
                objParam[27] = new SqlParameter("@b_code", Cmn.BankCode);
                objParam[28] = new SqlParameter("@gb_code", Cmn.BranchCode);
                objParam[29] = new SqlParameter("@b_place", Cmn.BranchPlace);
                objParam[30] = new SqlParameter("@ifsc_code", Cmn.IFSCCode);
                objParam[31] = new SqlParameter("@RegistrationNumber", Cmn.RegistrationNumber);
                objParam[32] = new SqlParameter("@OpeningDate", Cmn.OpeningDate);
                objParam[33] = new SqlParameter("@facilitySize", Cmn.facilitySize);
                objParam[34] = new SqlParameter("@AreaOfOperation", Cmn.AreaOfOperation);
                objParam[35] = new SqlParameter("@ShareCapital", Cmn.ShareCapital);
                objParam[36] = new SqlParameter("@bmcmaincenter", Cmn.bmcmaincenter);
                objParam[37] = new SqlParameter("@parentfacilityId", Cmn.parentfacilityId);
                objParam[38] = new SqlParameter("@FacilityId", Cmn.facilityId);
                

                SqlHelper.ExecuteNonQuery(connString, CommandType.StoredProcedure, "USP_Insert_Data", intCommandTimeOut, objParam);

                return "";
            }
            catch (Exception ex)
            {

                log.Error("Exception occured at InsertData : " + ex);

                return null;
            }
        }

        public static DataTable GetType()
        {

            try
            {

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Get_Type", intCommandTimeOut).Tables[0];
            }
            catch (Exception ex)
            {

                return null;
            }
        }

        public static DataSet GetUnitNames(UserDetails Cmn)
        {
          
            try
            {
                SqlParameter[] objParam = new SqlParameter[1];

                objParam[0] = new SqlParameter("@UnionName", Cmn.UnionName);

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Get_UnitName", intCommandTimeOut, objParam);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet GetRouteNames(UserDetails Cmn)
        {

            try
            {
                SqlParameter[] objParam = new SqlParameter[1];

                objParam[0] = new SqlParameter("@parentfacilityId", Cmn.parentfacilityId);

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Get_RouteName", intCommandTimeOut, objParam);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet GetFinAccount(UserDetails Cmn)
        {

            try
            {
                SqlParameter[] objParam = new SqlParameter[1];

                objParam[0] = new SqlParameter("@UnionName", Cmn.UnionName);

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Get_FinAccount", intCommandTimeOut, objParam);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static DataSet GetSeqId(UserDetails Cmn)
        {

            try
            {
                SqlParameter[] objParam = new SqlParameter[1];

                objParam[0] = new SqlParameter("@seq_name", Cmn.SequenceName);

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Get_Sequence", intCommandTimeOut, objParam);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet GetFacilityCode(UserDetails Cmn)
        {

            try
            {
                SqlParameter[] objParam = new SqlParameter[1];

                objParam[0] = new SqlParameter("@type", Cmn.Type);

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Get_FacilityCode", intCommandTimeOut, objParam);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet UpdateSequenceId(UserDetails Cmn)
        {

            try
            {

                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@sequenceName", Cmn.SequenceName);
                objParam[1] = new SqlParameter("@sequenceId", Cmn.sequenceId);

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Update_Sequence", intCommandTimeOut, objParam);

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static DataSet GetpriceChartMaxMin(UserDetails Cmn)
        {

            try
            {
                SqlParameter[] objParam = new SqlParameter[2];

                objParam[0] = new SqlParameter("@pricechartId", Cmn.pricechartId);
                objParam[1] = new SqlParameter("@productId", Cmn.productId);

                return SqlHelper.ExecuteDataset(connString, CommandType.StoredProcedure, "USP_Get_PriceChartMaxMin", intCommandTimeOut, objParam);

            }
            catch (Exception ex)
            {
                return null;
            }
        }

    }
}
