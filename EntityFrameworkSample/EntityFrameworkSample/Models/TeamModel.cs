using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFrameworkSample.Models
{
    public class InspectionDetails
    {
        /// <summary>
        /// InspID
        /// </summary>
        public int InspID { get; set; }

        /// <summary>
        /// InspTypeID
        /// </summary>
        public int InspTypeID { get; set; }

        /// <summary>
        /// VehicleNumber
        /// </summary>
        public int VehicleNumber { get; set; }

        /// <summary>
        /// CustomerVehicleNumber
        /// </summary>
        public string CustomerVehicleNumber { get; set; }

        /// <summary>
        /// CustomerNumber
        /// </summary>
        public int CustomerNumber { get; set; }

        /// <summary>
        /// CustomerName
        /// </summary>
        public string CustomerName { get; set; }

        /// <summary>
        /// LesseeNumber 
        /// </summary>
        public int LesseeNumber { get; set; }

        /// <summary>
        /// LesseName
        /// </summary>
        public string LesseeName { get; set; }

        /// <summary>
        /// LicenseTag 
        /// </summary>
        public string LicenseTag { get; set; }

        /// <summary>
        /// LicenseDate
        /// </summary>
        public DateTime LicenseDate { get; set; }

        /// <summary>
        /// LeaseTermMonths
        /// </summary>
        public int LeaseTermMonths { get; set; }

        /// <summary>
        /// AccountManagerNational
        /// </summary>
        public string AccountManagerNational { get; set; }

        /// <summary>
        /// AccountManagerLocal
        /// </summary>
        public string AccountManagerLocal { get; set; }

        /// <summary>
        /// DomicileLocationCode
        /// </summary>
        public string DomicileLocationCode { get; set; }

        /// <summary>
        /// DomicileLocationName
        /// </summary>
        public string DomicileLocationName { get; set; }

        /// <summary>
        /// DomicileDistrictCode
        /// </summary>
        public int DomicileDistrictCode { get; set; }

        /// <summary>
        /// DomicileDistrictName
        /// </summary>
        public string DomicileDistrictName { get; set; }

        /// <summary>
        /// PhysicalLocationCode 
        /// </summary>
        public int PhysicalLocationCode { get; set; }

        /// <summary>
        /// PhysicalLocationName
        /// </summary>
        public string PhysicalLocationName { get; set; }

        /// <summary>
        /// PhysicalDistrictCode
        /// </summary>
        public int PhysicalDistrictCode { get; set; }

        /// <summary>
        /// PhysicalDistrictName
        /// </summary>
        public string PhysicalDistrictName { get; set; }

        /// <summary>
        /// CbuCode
        /// </summary>
        public int CbuCode { get; set; }

        /// <summary>
        /// CbuName
        /// </summary>
        public string CbuName { get; set; }

        /// <summary>
        /// VehicleLeaseStartDate
        /// </summary>
        public DateTime VehicleLeaseStartDate { get; set; }

        /// <summary>
        /// VehicleLeaseEndDate
        /// </summary>
        public DateTime VehicleLeaseEndDate { get; set; }

        /// <summary>
        /// InServiceDate
        /// </summary>
        public DateTime InServiceDate { get; set; }

        /// <summary>
        /// OutServiceDate
        /// </summary>
        public DateTime OutServiceDate { get; set; }

        /// <summary>
        /// Odometer
        /// </summary>
        public int Odometer { get; set; }

        /// <summary>
        /// ReeferReading
        /// </summary>
        public int ReeferReading { get; set; }

        /// <summary>
        /// StandByreading
        /// </summary>
        public int StandByreading { get; set; }

        /// <summary>
        /// Progress
        /// </summary>
        public int Progress { get; set; }

        /// <summary>
        /// Status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// InspectionDate
        /// </summary>
        public DateTime InspectionDate { get; set; }

        /// <summary>
        /// TaskID 
        /// </summary>
        public int TaskID { get; set; }

        /// <summary>
        /// Insert_User
        /// </summary>
        public string Insert_User { get; set; }

        /// <summary>
        /// Insert_Date 
        /// </summary>
        public DateTime Insert_Date { get; set; }

        /// <summary>
        /// Enabled
        /// </summary>
        public bool Enabled { get; set; }
    }
}