﻿namespace API_.NET.Constants
{
    public static class Constants
    {
        public enum USER_TYPES
        {
            DEFAULT, CUSTOMER, SHIPPER, STORE, ADMIN, GUEST
        }

        public static string GetRole(int userType)
        {
            switch (userType)
            {
                case 1:
                    return "ROLE_CUSTOMER";
                case 2:
                    return "ROLE_SHIPPER";
                case 3:
                    return "ROLE_STORE";
                case 4:
                    return "ROLE_ADMIN";
                default:
                    return "ROLE_GUEST";
            }
        }

        public enum REGION_LEVELS
        {
            DEFAULT, GREEN, YELLOW, ORANGE, RED
        }

        public static int PAGE_SIZE = 8;

        public static int PW_SALT = 10;

        public enum ORDER_STATUS
        {
            RECEIVED = 1,
            PREPARE = 2,
            SHIPPING = 3,
            DELIVERED = 4,
            PAYMENTED = 5,
            PAID = 6,
            REFUNDED = 7,
            CANCELED = 8
        }
    }
}
