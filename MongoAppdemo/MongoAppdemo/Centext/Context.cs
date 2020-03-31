using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using ValuePlus.ViewModel.LocaleChainVP;

namespace MnogoApp.Centext
{
    public class Context : DbContext
    {
        public Context() : base("name=eChainVP")
        {
        }

        public DbSet<AE_APPHAWBNo_Para> AE_APPHAWBNo_Para { get; set; }
        public DbSet<AE_APPHAWBNoViewModel> AE_APPHAWBNoViewModel { get; set; }
        public DbSet<AE_BookConfigViewModel> AE_BookConfigViewModel { get; set; }
        public DbSet<AE_BookConsole_StationViewModel> AE_BookConsole_StationViewModel { get; set; }
        public DbSet<AE_ControlBank_Search_Para> AE_ControlBank_Search_Para { get; set; }
        public DbSet<AE_ControlBankViewModel> AE_ControlBankViewModel { get; set; }
        public DbSet<AE_DAWB_GoodsViewModel> AE_DAWB_GoodsViewModel { get; set; }
        public DbSet<AE_DAWB_HeaderViewModel> AE_DAWB_HeaderViewModel { get; set; }
        public DbSet<AE_DAWB_MovementViewModel> AE_DAWB_MovementViewModel { get; set; }
        public DbSet<AE_DraftBooking_Search_Para> AE_DraftBooking_Search_Para { get; set; }
        public DbSet<AE_DraftBooking_SearchViewModel> AE_DraftBooking_SearchViewModel { get; set; }
        public DbSet<AE_HAWB_AppHAWBViewModel> AE_HAWB_AppHAWBViewModel { get; set; }
        public DbSet<AE_HAWB_BookingViewModel> AE_HAWB_BookingViewModel { get; set; }
        public DbSet<AE_HAWB_CustomsViewModel> AE_HAWB_CustomsViewModel { get; set; }
        public DbSet<AE_HAWB_ExtraViewModel> AE_HAWB_ExtraViewModel { get; set; }
        public DbSet<AE_HAWB_GoodsViewModel> AE_HAWB_GoodsViewModel { get; set; }
        public DbSet<AE_HAWB_gvPickupViewModel> AE_HAWB_gvPickupViewModel { get; set; }
        public DbSet<AE_HAWB_HeaderViewModel> AE_HAWB_HeaderViewModel { get; set; }
        public DbSet<AE_HAWB_InstructionViewModel> AE_HAWB_InstructionViewModel { get; set; }
        public DbSet<AE_HAWB_MilestoneViewModel> AE_HAWB_MilestoneViewModel { get; set; }
        public DbSet<AE_HAWB_MovementViewModel> AE_HAWB_MovementViewModel { get; set; }
        public DbSet<AE_HAWB_DocRequiredViewModel> AE_HAWB_DocRequiredViewModel { get; set; }
        public DbSet<AE_HAWB_PickupViewModel> AE_HAWB_PickupViewModel { get; set; }
        public DbSet<AE_HAWB_Search_Para> AE_HAWB_Search_Para { get; set; }
        public DbSet<AE_HAWB_SearchViewModel> AE_HAWB_SearchViewModel { get; set; }
        public DbSet<AE_HAWB_SHAWBViewModel> AE_HAWB_SHAWBViewModel { get; set; }
        public DbSet<AMS_SplitShipmentPara> AMS_SplitShipmentPara { get; set; }
        public DbSet<AE_HAWB_WarehouseViewModel> AE_HAWB_WarehouseViewModel { get; set; }
        public DbSet<AE_HAWBViewModel> AE_HAWBViewModel { get; set; }
        public DbSet<AE_MAWB_AppHAWBViewModel> AE_MAWB_AppHAWBViewModel { get; set; }
        public DbSet<AE_MAWB_CarrierBookingViewModel> AE_MAWB_CarrierBookingViewModel { get; set; }
        public DbSet<AE_MAWB_ConsolDetailViewModel> AE_MAWB_ConsolDetailViewModel { get; set; }
        public DbSet<AE_MAWB_ConsollistViewModel> AE_MAWB_ConsollistViewModel { get; set; }
        public DbSet<AE_MAWB_eManifestDetailViewModel> AE_MAWB_eManifestDetailViewModel { get; set; }
        public DbSet<AE_MAWB_eManifestViewModel> AE_MAWB_eManifestViewModel { get; set; }
        public DbSet<AE_MAWB_HeaderViewModel> AE_MAWB_HeaderViewModel { get; set; }
        public DbSet<AE_MAWB_InstructionViewModel> AE_MAWB_InstructionViewModel { get; set; }
        public DbSet<AE_MAWB_OnBoardDetailViewModel> AE_MAWB_OnBoardDetailViewModel { get; set; }
        public DbSet<AE_MAWB_Search_Para> AE_MAWB_Search_Para { get; set; }
        public DbSet<AE_MAWB_SearchViewModel> AE_MAWB_SearchViewModel { get; set; }
        public DbSet<AE_MAWBBuildHAWBViewModel> AE_MAWBBuildHAWBViewModel { get; set; }
        public DbSet<AE_MAWBBuildParaViewModel> AE_MAWBBuildParaViewModel { get; set; }
        public DbSet<AE_MAWBBuildViewModel> AE_MAWBBuildViewModel { get; set; }
        public DbSet<AE_MAWBViewModel> AE_MAWBViewModel { get; set; }
        public DbSet<AE_SMAWBViewModel> AE_SMAWBViewModel { get; set; }
    }
}
