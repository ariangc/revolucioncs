using System;

namespace Services {
    public class LoginService {
        private static LoginService loginService;
        private LoginService() { }

        public void login(int userId, String password) {
            //Gets real password from userID
            //Compares password correctness
            //If so, establishes connection
        }

        public static LoginService getInstance() {
            if (loginService == null) {
                loginService = new LoginService();
            }
            return loginService;
        }
    }
}