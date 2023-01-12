using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetCore.Shared
{
    #region Systems

    public class AppConstants
    {
        //public static bool SignExprireDate = true;
        public static string EnvironmentName = "production";
        public static int RootAppId => 1;
        public static int TestAppId => 2;
    }

    public class UserConstants
    {
        public static int AdministratorId => 1;
        public static int UserId => 2;
    }

    public static class NameConstants
    {
        public static string GetPropName(string name)
        {
            switch (name)
            {
                case "Code":
                    return "Mã";

                default:
                    return null;
            }
        }

        public static List<string> GetPropName(List<string> names)
        {
            var result = new List<string>();
            foreach (var name in names)
            {
                result.Add(GetPropName(name));
            }
            return result;
        }
    }

    public class SelectListItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
    }

    public class SelectItemModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedDate { get; set; }
    }


    public class MessageConstants
    {
        public static string ErrorLogMessage = "An error occurred: ";
        public static string CreateSuccessMessage = "Thêm mới thành công";
        public static string CreateErrorMessage = "Thêm mới thất bại";
        public static string UpdateSuccessMessage = "Cập nhật thành công";
        public static string UpdateErrorMessage = "Cập nhật thất bại";
        public static string DeleteSuccessMessage = "Kết quả xóa";
        public static string DeleteErrorMessage = "Xóa thất bại";
        public static string DeleteItemSuccessMessage = "Xóa thành công";
        public static string DeleteItemErrorMessage = "Xóa không thành công";
        public static string DeleteItemNotFoundMessage = "Không tìm thấy đối tượng";
        public static string GetDataSuccessMessage = "Tải dữ liệu thành công";
        public static string GetDataErrorMessage = "Tải dữ liệu thất bại";
        public static string SignSuccess = "Ký thành công";
    }

    public class ClaimConstants
    {
        public const string USER_ID = "x-user-id";
        public const string USER_EMAIL = "x-user-email";
        public const string USER_NAME = "x-user-name";
        public const string FULL_NAME = "x-full-name";
        public const string AVATAR = "x-avatar";
        public const string APP_ID = "x-app-id";
        public const string ORG_ID = "x-org-id";
        public const string APPS = "x-app";
        public const string ROLES = "x-role";
        public const string RIGHTS = "x-right";
        public const string ISSUED_AT = "x-iat";
        public const string EXPIRES_AT = "x-exp";
        public const string CHANNEL = "x-channel";
        public const string DOCUMENT_ID = "x-document-id";
        public const string REQUEST_ID = "x-request-id";
        public const string SAD_REQUEST_ID = "x-sad-id";
    }

    #endregion

    #region Business

    public class CacheConstants
    {
        public const string LIST_SELECT = "list-select";
        public const string WSO2_ACCESSTOKEN = "WSO2-ACCESSTOKEN";

        public const string USER = "User";
        public const string USER_MAP_ROLE = "User_map_role";
        public const string SYS_APP = "Sys_application";
        public const string FEES = "Fees";
        public const string SUBJECTION = "Subjection";
        public const string FIELDTION = "Fieldstion";
        public const string PROFILE_COMPOSITION = "ProfileComposition";
        public const string SEQUENCETION = "Sequencetion";
        public const string SERVICE = "Service";
        public const string RECORDS_CONFIG = "RecordsConfig";
        public const string RECORDS = "Records";
        public const string STUDENT_PROFILE = "StudentProfile";

        public const string RIGHT = "Right";
        public const string ROLE = "Role";
        public const string ROLE_MAP_RIGHT = "Role_map_right";
        public const string ROLE_MAP_DATA = "Role_map_data";
        public const string ROLE_MAP_API = "Role_map_api";
        public const string ROLE_MAP_NAV = "Role_map_nav";
        public const string ROLE_MAP_USER = "Role_map_user";
        public const string API_CATALOG = "Api_catalog";
        public const string ORGANIZATION = "Organization";
        public const string NAVIGATION = "Navigation";
        public const string NAV_MAP_ROLE = "Navigation_map_role";
    }

    public class LogConstants
    {
        #region Khởi tạo dữ liệu
        public const string ACTION_SEED_DATA = "Khởi tạo dữ liệu ứng dụng";
        #endregion

        #region Login
        public const string ACTION_LOGIN = "Đăng nhập";
        public const string ACTION_LOGOUT = "Đăng xuất";
        public const string ACTION_WSO2_LOGIN = "Truy cập hệ thống";
        #endregion

        #region System Application
        public const string ACTION_SYS_APP_CREATE = "Thêm mới ứng dụng";
        public const string ACTION_SYS_APP_UPDATE = "Cập nhật ứng dụng";
        public const string ACTION_SYS_APP_DELETE = "Xóa ứng dụng";
        #endregion

        #region Api catalog
        public const string ACTION_API_CATALOG_CREATE = "Thêm mới api";
        public const string ACTION_API_CATALOG_UPDATE = "Cập nhật api";
        public const string ACTION_API_CATALOG_DELETE = "Xóa api";
        #endregion

        #region Organization
        public const string ACTION_ORG_CREATE = "Thêm mới đơn vị/phòng ban";
        public const string ACTION_ORG_UPDATE = "Cập nhật đơn vị/phòng ban";
        public const string ACTION_ORG_DELETE = "Xóa đơn vị/phòng ban";
        #endregion

        #region User
        public const string ACTION_USER_CREATE = "Thêm mới người dùng";
        public const string ACTION_USER_UPDATE = "Cập nhật người dùng";
        public const string ACTION_USER_UPDATE_LOCK = "Khóa/mở khóa người dùng";
        public const string ACTION_USER_DELETE = "Xóa người dùng";
        #endregion

        #region Role
        public const string ACTION_ROLE_CREATE = "Thêm mới nhóm người dùng";
        public const string ACTION_ROLE_UPDATE = "Cập nhật nhóm người dùng";
        public const string ACTION_ROLE_DELETE = "Xóa nhóm người dùng";
        #endregion

        #region Right
        public const string ACTION_RIGHT_CREATE = "Thêm mới quyền người dùng";
        public const string ACTION_RIGHT_UPDATE = "Cập nhật quyền người dùng";
        public const string ACTION_RIGHT_DELETE = "Xóa quyền người dùng";
        #endregion

        #region Navigation
        public const string ACTION_NAV_CREATE = "Thêm mới điều hướng";
        public const string ACTION_NAV_UPDATE = "Cập nhật điều hướng";
        public const string ACTION_NAV_DELETE = "Xóa điều hướng";
        #endregion

        #region Device
        public const string DEVICE_WEB = "Web";
        public const string DEVICE_MOBILE = "mobile";

        #endregion

        #region FIELDSTION
        public const string ACTION_FIELDSTION_CREATE = "Thêm mới lĩnh vực";
        public const string ACTION_FIELDSTION_UPDATE = "Cập nhật lĩnh vực";
        public const string ACTION_FIELDSTION_DELETE = "Xóa lĩnh vực";
        #endregion

        #region PROFILE_COMPOSITION
        public const string ACTION_PROFILE_COMPOSITION_CREATE = "Thêm mới thành phần hồ sơ";
        public const string ACTION_PROFILE_COMPOSITION_UPDATE = "Cập nhật thành phần hồ sơ";
        public const string ACTION_PROFILE_COMPOSITION_DELETE = "Xóa thành phần hồ sơ";
        #endregion

        #region RECORDS_CONFIG
        public const string ACTION_RECORDS_CONFIG_CREATE = "Thêm mới cấu hình mã hồ sơ";
        public const string ACTION_RECORDS_CONFIG_UPDATE = "Cập nhật cấu hình mã hồ sơ";
        public const string ACTION_RECORDS_CONFIG_DELETE = "Xóa cấu hình mã hồ sơ";
        #endregion

        #region RECORDS
        public const string ACTION_RECORDS_CREATE = "Thêm mới hồ sơ";
        public const string ACTION_RECORDS_CREATE_PORTAL = "Đăng ký hồ sơ";
        public const string ACTION_UPDATE_PAYMENT_PORTAL = "Cập nhật thông tin thanh toán";
        public const string ACTION_UPDATE_INFO_PORTAL = "Cập nhật thông tin hồ sơ";
        public const string ACTION_RECORDS_UPDATE = "Cập nhật hồ sơ";
        public const string ACTION_RECORDS_RECEVE_OR_REJECT = "Tiếp nhận/hủy hoặc từ chối hồ sơ";
        public const string ACTION_MOVE_PROCESS = "Chuyển xử lý hồ sơ";
        public const string ACTION_MOVE_CANCEL = "Hủy đăng ký hồ sơ";
        public const string ACTION_RECORDS_DELETE = "Xóa hồ sơ";
        #endregion

        #region SEQUENCETION
        public const string ACTION_SEQUENCETION_CREATE = "Thêm mới trình tự thực hiện";
        public const string ACTION_SEQUENCETION_UPDATE = "Cập nhật trình tự thực hiện";
        public const string ACTION_SEQUENCETION_DELETE = "Xóa trình tự thực hiện";
        #endregion

        #region SERVICE
        public const string ACTION_SERVICE_CREATE = "Thêm mới dịch vụ";
        public const string ACTION_SERVICE_UPDATE = "Cập nhật dịch vụ";
        public const string ACTION_SERVICE_DELETE = "Xóa dịch vụ";
        #endregion

        #region SUBJECTION
        public const string ACTION_SUBJECTION_CREATE = "Thêm mới đối tượng sử dụng";
        public const string ACTION_SUBJECTION_UPDATE = "Cập nhật đối tượng sử dụng";
        public const string ACTION_SUBJECTION_DELETE = "Xóa đối tượng sử dụng";
        #endregion
        
        #region FEES
        public const string ACTION_FEES_CREATE = "Thêm mới chi phí";
        public const string ACTION_FEES_UPDATE = "Cập nhật chi phí";
        public const string ACTION_FEES_DELETE = "Xóa chi phí";
        #endregion
    }

    public class QueryFilter
    {
        public const int DefaultPageNumber = 1;
        public const int DefaultPageSize = 20;
    }

    #endregion

    public class KeyValueModel
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public static class MongoCollections
    {
        public static string SysLog = "sys_log";
        public static string NotifyLog = "notify_log";
    }

    public class CreateManyDataResult
    {
        public int? Id { get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Code { get; set; }
        public string Message { get; set; }
    }

    public enum GenderEnum
    {
        MALE = 1,
        FEMALE = 2,
        UNKNOW = 3
    }

    //Trạng thái hồ sơ:
    //        + 1: Chờ tiếp nhận
    //        + 2: Chờ bổ sung
    //        + 3: Đã tiếp nhận
    //        + 4: Đang xử lý
    //        + 5: Đã xử lý
    //        + 6: Đã trả kết quả
    //        + 7: Đã hủy
    public enum RecordStatusEnum
    {
        CHO_TIEP_NHAN = 1,
        CHO_BO_SUNG = 2,
        DA_TIEP_NHAN = 3,
        DANG_XU_LY = 4,
        DA_XU_LY = 5,
        DA_TRA_KET_QUA = 6,
        DA_HUY_DANG_KY = 7,
    }
}