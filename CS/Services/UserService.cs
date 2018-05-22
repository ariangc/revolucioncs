
using System;
using Entities;

namespace Services {
    public class UserService {
        private User currentUser;
        private static UserService userService;

        protected UserService() {
            currentUser = new User();
        }

        public void addEntity(Entity ent) {
           
        }

        public void updateEntity(Entity ent) {
            
        }

        public void deleteEntity(Entity ent) {
           
        }

        public void addTransaction(Transaction trn) {
            
        }

        public void logOut() {
            
        }

        public void search() {
            
        }

        public static UserService getInstance() {
            if (userService == null) {
                userService = new UserService();
            }
            return userService;
        }

    }
}