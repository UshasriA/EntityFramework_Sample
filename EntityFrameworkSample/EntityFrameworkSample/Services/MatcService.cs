using EntityFrameworkSample.DBModels;
using EntityFrameworkSample.Models;
using EntityFrameworkSample.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Services
{
    public class MatcService : IMatchService
    {
        IMatchRepository matchRepository;
        public MatcService(IMatchRepository _matchRepository)
        {
            matchRepository = _matchRepository;
        }
        public async Task<string> InsertTeam(string TeamName)
        {
            TournamentContext obj = new TournamentContext();
            Team team = new Team();
            team.TeamName = TeamName;

            obj.Teams.Add(team);
            obj.SaveChanges();
            return "Added successfully";
        }

        public async Task<string> InsertInspDetails(InspectionDetails inspdts)
        {

            SqlConnection con = new SqlConnection("Data Source =BHAVNAWKS759; Initial Catalog =Tournament;User ID = sa; Password = Bhavna@123 ");
            con.Open();
            SqlCommand tCommand = new SqlCommand();
            tCommand.CommandText = "INSERT INTO  VINS_D_InspectionDetails InspTypeID=@InspTypeID, VehicleNumber=@VehicleNumber, CustomerVehicleNumber=@CustomerVehicleNumber, CustomerNumber=@CustomerNumber, CustomerName=@CustomerName, LesseeNumber=@LesseeNumber, LesseeName=@LesseeName, LicenseTag=@LicenseTag, LicenseDate=@LicenseDate, LeaseTermMonths=@LeaseTermMonths, AccountManagerNational=@AccountManagerNational, AccountManagerLocal=@AccountManagerLocal, DomicileLocationCode=@DomicileLocationCode, DomicileLocationName=@DomicileLocationName, DomicileDistrictCode=@DomicileDistrictCode, DomicileDistrictName=@DomicileDistrictName, PhysicalLocationCode=@PhysicalLocationCode, PhysicalLocationName=@PhysicalLocationName, PhysicalDistrictCode=@PhysicalDistrictCode, PhysicalDistrictName=@PhysicalDistrictName, CbuCode=@CbuCode, CbuName=@CbuName, VehicleLeaseStartDate=@VehicleLeaseStartDate, VehicleLeaseEndDate=@VehicleLeaseEndDate, InServiceDate=@InServiceDate, OutServiceDate=@OutServiceDate, Odometer=@Odometer, ReeferReading=@ReeferReading, StandByreading=@StandByreading, Progress=@Progress, Status=@Status, InspectionDate=@InspectionDate, TaskID=@TaskID, Insert_User=@Insert_User, Insert_Date=@Insert_Date, Enabled=@Enabled, ";

            try
            {
                //tCommand.Parameters.Add(new SqlParameter("@InspID", System.Data.SqlDbType.Int).Value = inspdts.InspID);
                tCommand.Parameters.Add(new SqlParameter("@InspTypeID", System.Data.SqlDbType.Int) { Value = inspdts.InspTypeID });
                tCommand.Parameters.Add(new SqlParameter("@VehicleNumber", System.Data.SqlDbType.Int) { Value = inspdts.VehicleNumber });
                tCommand.Parameters.Add(new SqlParameter("@CustomerVehicleNumber", System.Data.SqlDbType.VarChar) { Value = inspdts.CustomerVehicleNumber });
                tCommand.Parameters.Add(new SqlParameter("@CustomerNumber", System.Data.SqlDbType.Int) { Value = inspdts.CustomerNumber });
                tCommand.Parameters.Add(new SqlParameter("@CustomerName", System.Data.SqlDbType.VarChar) { Value = inspdts.CustomerName });
                tCommand.Parameters.Add(new SqlParameter("@LesseeNumber", System.Data.SqlDbType.Int) { Value = inspdts.LesseeNumber });
                tCommand.Parameters.Add(new SqlParameter("@LesseeName", System.Data.SqlDbType.VarChar) { Value = inspdts.LesseeName });
                tCommand.Parameters.Add(new SqlParameter("@LicenseTag", System.Data.SqlDbType.VarChar) { Value = inspdts.LicenseTag });
                tCommand.Parameters.Add(new SqlParameter("@LicenseDate", System.Data.SqlDbType.Date) { Value = inspdts.LicenseDate });
                tCommand.Parameters.Add(new SqlParameter("@LeaseTermMonths", System.Data.SqlDbType.Int) { Value = inspdts.LeaseTermMonths });
                tCommand.Parameters.Add(new SqlParameter("@AccountManagerNational", System.Data.SqlDbType.VarChar) { Value = inspdts.AccountManagerNational });
                tCommand.Parameters.Add(new SqlParameter("@AccountManagerLocal", System.Data.SqlDbType.VarChar) { Value = inspdts.AccountManagerLocal });
                tCommand.Parameters.Add(new SqlParameter("@DomicileLocationCode", System.Data.SqlDbType.Int) { Value = inspdts.DomicileLocationCode });
                tCommand.Parameters.Add(new SqlParameter("@DomicileLocationName", System.Data.SqlDbType.VarChar) { Value = inspdts.DomicileLocationName });
                tCommand.Parameters.Add(new SqlParameter("@DomicileDistrictCode", System.Data.SqlDbType.Int) { Value = inspdts.DomicileDistrictCode });
                tCommand.Parameters.Add(new SqlParameter("@DomicileDistrictName", System.Data.SqlDbType.VarChar) { Value = inspdts.DomicileDistrictName });
                tCommand.Parameters.Add(new SqlParameter("@PhysicalLocationCode", System.Data.SqlDbType.Int) { Value = inspdts.PhysicalLocationCode });
                tCommand.Parameters.Add(new SqlParameter("@PhysicalLocationName", System.Data.SqlDbType.VarChar) { Value = inspdts.PhysicalLocationName });
                tCommand.Parameters.Add(new SqlParameter("@PhysicalDistrictCode", System.Data.SqlDbType.Int) { Value = inspdts.PhysicalDistrictCode });
                tCommand.Parameters.Add(new SqlParameter("@PhysicalDistrictName", System.Data.SqlDbType.VarChar) { Value = inspdts.PhysicalDistrictName });
                tCommand.Parameters.Add(new SqlParameter("@CbuCode", System.Data.SqlDbType.Int) { Value = inspdts.CbuCode });
                tCommand.Parameters.Add(new SqlParameter("@CbuName", System.Data.SqlDbType.VarChar) { Value = inspdts.CbuName });
                tCommand.Parameters.Add(new SqlParameter("@VehicleLeaseStartDate", System.Data.SqlDbType.Date) { Value = inspdts.VehicleLeaseStartDate });
                tCommand.Parameters.Add(new SqlParameter("@VehicleLeaseEndDate", System.Data.SqlDbType.Date) { Value = inspdts.VehicleLeaseEndDate });
                tCommand.Parameters.Add(new SqlParameter("@InServiceDate", System.Data.SqlDbType.Date) { Value = inspdts.InServiceDate });
                tCommand.Parameters.Add(new SqlParameter("@OutServiceDate", System.Data.SqlDbType.Date) { Value = inspdts.OutServiceDate });
                tCommand.Parameters.Add(new SqlParameter("@Odometer", System.Data.SqlDbType.Int) { Value = inspdts.Odometer });
                tCommand.Parameters.Add(new SqlParameter("@ReeferReading", System.Data.SqlDbType.Int) { Value = inspdts.ReeferReading });
                tCommand.Parameters.Add(new SqlParameter("@StandByreading", System.Data.SqlDbType.Int) { Value = inspdts.StandByreading });
                tCommand.Parameters.Add(new SqlParameter("@Progress", System.Data.SqlDbType.Int) { Value = inspdts.Progress });
                tCommand.Parameters.Add(new SqlParameter("@Status", System.Data.SqlDbType.VarChar) { Value = inspdts.Status });
                tCommand.Parameters.Add(new SqlParameter("@InspectionDate", System.Data.SqlDbType.Date) { Value = inspdts.InspectionDate });
                tCommand.Parameters.Add(new SqlParameter("@TaskID", System.Data.SqlDbType.Int) { Value = inspdts.TaskID });
                tCommand.Parameters.Add(new SqlParameter("@Insert_User", System.Data.SqlDbType.VarChar) { Value = inspdts.Insert_User });
                tCommand.Parameters.Add(new SqlParameter("@Insert_Date", System.Data.SqlDbType.DateTime) { Value = inspdts.Insert_Date });
                tCommand.Parameters.Add(new SqlParameter("@Enabled", System.Data.SqlDbType.Bit) { Value = inspdts.Enabled });
                con.Close();
                tCommand.ExecuteNonQuery();
                return "Added";

            }
            catch (Exception ex)
            {
                return default;
            }
        }
    }
}
