using System;

namespace Services {
    public class ChangePasswordService {
        private static ChangePasswordService changePasswordService;

        private ChangePasswordService() { }

        

        public static ChangePasswordService getInstance() {
            if (changePasswordService == null) {
                changePasswordService = new ChangePasswordService();
            }
            return changePasswordService;
        }
    }
}