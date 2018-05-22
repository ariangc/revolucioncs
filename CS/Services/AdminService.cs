using System;

namespace Services {
    public class AdminService : UserService {
        private static AdminService adminService;

        private AdminService() {

        }

        public static AdminService getInstance() {
            if (adminService == null) {
                adminService = new AdminService();
            }
            return adminService;
        }

        public void createReport() {

        }

        public void clickButtonUploadExcel() {

        }

        public void requestBackup() {

        }
    }
}