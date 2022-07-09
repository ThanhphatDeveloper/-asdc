using DevExpress.XtraRichEdit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangLinhKienPC_NCP
{
    public class NotificationText
    {
        //Form Đăng nhập
        public string loginDataError = "Thông tin tài khoản hoặc mật khẩu không chính xác!";
        public string loginInputError = "Vui lòng nhập đầy đủ thông tin ở các trường nhập!";
        //Form Lập hóa đơn
        public string addCustomerQuestion = "Bạn có muốn thêm khách hàng này?";
        public string addCustomerSuccess = "Thêm thành công!";
        public string addCustomerFail = "Thêm không thành công!";

        public string addBillQuestion = "Bạn có muốn lưu hóa đơn này?";
        public string addBillFail = "Thêm không thành công!!";
        public string addBillSuccess = "Thêm thành công!";
        public string inputBillError = "Lỗi, vui lòng kiểm tra lại các trường nhập. Yêu cầu điền đầy đủ thông tin ở tất cả các mục!";
        public string emptyBill = "Hóa đơn đang không có sản phẩm nào, không thể lập hóa đơn!";
        public string productNumberIsEmpty = "Vui lòng nhập số lượng sản phẩm!";
        public string deleteBillQuestion = "Bạn muốn xóa sản phẩm này khỏi hóa đơn?";
        public string exceptionErrorBill = "Lỗi không xác định!";

        public string numberOfProductExceededTheLimit = "Số lượng hàng trong kho không đủ!";
        public string numberOfSaleExceededTheLimit = "Giá trị khuyến mã đã vượt giới hạn!";

        public string inputValueInvalid = "Dữ liệu nhập không hợp lệ!";
        //Form Quản lý khách hàng
        public string updateCustomerQuestion = "Bạn có muốn cập nhật khách hàng này?";
        public string updateCustomerSuccess = "Sửa thành công!";
        public string updateCustomerFail = "Sửa không thành công!";

        public string deleteCustomerQuestion = "Bạn có muốn xóa khách hàng này?";
        public string deleteCustomerSuccess = "Xóa thành công!";
        public string deleteCustomerFail = "Xóa không thành công!";

        public string customerIsExit = "Khách hàng này đã tồn tại!";
        //Form Quản lý nhà cung cấp
        public string updateNCCQuestion = "Bạn có muốn cập nhật nhà cung cấp này?";
        public string updateNCCSuccess = "Sửa thành công!";
        public string updateNCCFail = "Sửa không thành công!";

        public string deleteNCCQuestion = "Bạn có muốn xóa nhà cung cấp này?";
        public string deleteNCCSuccess = "Xóa thành công!";
        public string deleteNCCFail = "Xóa không thành công!";

        public string addNCCQuestion = "Bạn có muốn thêm nhà cung cấp này?";
        public string addNCCSuccess = "Thêm thành công!";
        public string addNCCFail = "Thêm không thành công!";

        public string nccCodeNotExsit = "Mã nhà cung cấp không tồn tại!";
        public string nccCodeExsit = "Mã nhà cung cấp đã tồn tại!";
        public string emptyMaNCCInput = "Không có dữ liệu để xóa!";
        //Form Quản lý nhân viên
        public string updateStaffQuestion = "Bạn có muốn cập nhật nhân viên này?";
        public string updateStaffSuccess = "Sửa thành công!";
        public string updateStaffFail = "Sửa không thành công!";
        public string passwordError = "Mật khẩu không trùng khớp với mật khẩu cũ, mời nhập lại!";

        public string changePasswordSuccess = "Đổi mật khẩu thành công!";
        public string changePasswordFail = "Đổi mật khẩu không thành công!";

        public string addStaffQuestion = "Bạn có muốn thêm nhân viên này?";
        public string addStaffSuccess = "Thêm thành công!";
        public string addStafFail = "Thêm không thành công!";
        public string emptyInput = "Vui lòng điền đầy đủ thông tin vào các trường nhập (có thể bỏ qua phần hình ảnh đề cập nhật sau)!";

        public string deleteStaffQuestion = "Bạn có muốn xóa nhân viên này?";
        public string deleteStaffSuccess = "Xóa thành công!";
        public string deleteStaffFail = "Xóa không thành công!";

        public string staffCodeIsExsit = "Mã nhân viên đã tồn tại!";

        public string fileIsNotVaild = "Không được tải lên file này!";
        //Form Quản lý sản phẩm
        public string deleteProductQuestion = "Bạn có muốn xóa nhân viên này?";
        public string deleteProductSuccess = "Xóa thành công!";
        public string deleteProductFail = "Xóa không thành công!";
        //Form Tạo tài khoản
        public string createSuccess = "Tạo thành công!";
        public string createFail = "Tạo không thành công!";
        public string accountExists = "Tên tài khoản đã tồn tại hoặc nhân viên không hợp lệ!";
        //Form Nhập hàng
        public string emptyNumberOfProduct = "Vui lòng nhập số lượng sản phẩm!";

        public string addProductSuccess = "Thêm thành công!";
        public string addProductFail = "Thêm không thành công!";

        public string createImportCouponQuestion = "Bạn có chắc chắn muốn tạo phiếu không?";
        public string cancelImportCouponQuestion = "Bạn có chắc chắn muốn hủy phiếu không?";

        public string addProductQuestion = "Bạn có muốn nhập sản phẩm này và kho?";

        public string addImportCouponQuestion = "Bạn có muốn lưu phiếu nhập này?";
        public string addImportCouponSuccess = "Thêm thành công!";
        public string addImportCouponFail = "Thêm không thành công!";

        public string emptyInputOfFormNhapHang = "Lỗi, vui lòng kiểm tra lại các trường nhập. Yêu cầu điền đầy đủ thông tin ở tất cả các mục!";
        public string emptyImportCoupon = "Phiếu nhập rỗng!";
        public string typeNotExsit = "Loại sản phẩm và nhà cung cấp không tồn tại!";
        public string nccNotExsit = "Nhà cung cấp không tồn tại!";
        public string deleteProductFromImportCouponQuestion = "Bạn muốn xóa sản phẩm này khỏi phiếu nhập?";
        //Form Loại sản phẩm
        public string productTypeIsExit = "Loại sản phẩm này đã tồn tại!";
        public string productTypeIsNotExit = "Loại sản phẩm này không tồn tại!";
        public string addProductTypeSuccess = "Thêm thành công!";
        public string addProductTypeFail = "Thêm không thành công!";

        public string updateProductTypeFail = "Cập nhật không thành công!";
        public string updateProductTypeSuccess = "Cập nhật thành công!";

        public string deleteProductTypeFail = "Xóa không thành công!";
        public string deleteProductTypeSuccess = "Xóa thành công!";

        public string noProductTypeData = "Không có dữ liệu để xóa!";
        public string emptyProductTypeInput = "Lỗi, vui lòng kiểm tra lại các trường nhập. Yêu cầu điền đầy đủ thông tin ở tất cả các mục!";
        //...
        public string UnknownExceptionError = "Unknown exception error!";
        public string emptyAccountInput = "Lỗi, vui lòng kiểm tra lại các trường nhập. Yêu cầu điền đầy đủ thông tin ở tất cả các mục!";

        

    }
}
