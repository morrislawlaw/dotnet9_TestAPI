namespace dotnet9_TestAPI
{
    public class ResponseEntity
    {
        public int code { get; set; }
        public string? message { get; set; }    
        public string? datetime
        {
            get
            {
                return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            }
            set { }
        }
        public object? data { get; set; }

        public static int SUCCESS = 0;
        public static int USER_OR_PWD_ERROR = 1;
        public static int SIGN_ERR = 2;
        public static int TOKEN_ERROR = 3;
        public static int PRARM_ERROR = 4;
        public static int NAME_NULL_ERROR = 5;
        public static int PHONE_NULL_ERROR = 6;
        public static int BLOCK_NULL_ERROR = 7;
        public static int FLOOR_NULL_ERROR = 8;
        public static int DOOR_GROUP_NULL_ERROR = 9;
        public static int VISITOR_COMMENCE_NULL_ERROR = 10;
        public static int VISITOR_EXPIRY_NULL_ERROR = 11;
        public static int BOOKING_COMMENCE_NULL_ERROR = 12;
        public static int BOOKING_EXPIRY_NULL_ERROR = 13;
        public static int BOOKING_ID_NOT_EXISTS = 14;
        public static int CHOOSE_RES_VIS_ERROR = 16;
        public static int VISISTOR_ID_NOT_EXISTS = 17;
        public static int REF_CARDNUMBER_NULL_ERROR = 18;
        public static int REF_CARDNUMBER_NOT_EXISTS = 19;
        public static int OCTOPUSNUMBER_NULL_ERROR = 20;
        public static int OCTOPUSNUMBER_NOT_EXISTS = 21;
        public static int OCTOPUSNUMBER_IS_DUPLICATED = 22;
        public static int OTHER_ERROR = -1;


        public static string get_err_message(int code)
        {
            if (code == SUCCESS) { return "success"; }
            if (code == USER_OR_PWD_ERROR) { return "User does not exist or password incorrect"; }
            if (code == SIGN_ERR) { return "Signature error"; }
            if (code == TOKEN_ERROR) { return "Token expired or token error"; }
            if (code == PRARM_ERROR) { return "Parameter error"; }
            if (code == NAME_NULL_ERROR) { return "Input Parameter error: name is missing."; }
            if (code == PHONE_NULL_ERROR) { return "Input Parameter error: phone number is missing."; }
            if (code == BLOCK_NULL_ERROR) { return "Input Parameter error: block is missing."; }
            if (code == FLOOR_NULL_ERROR) { return "Input Parameter error: floor is missing."; }
            if (code == DOOR_GROUP_NULL_ERROR) { return "Input Parameter error: door_group is missing."; }
            if (code == VISITOR_COMMENCE_NULL_ERROR) { return "Input Parameter error: visitor_qr_commence is missing."; }
            if (code == VISITOR_EXPIRY_NULL_ERROR) { return "Input Parameter error: visitor_qr_expiry is missing."; }
            if (code == BOOKING_COMMENCE_NULL_ERROR) { return "Input Parameter error: booking_qr_commence is missing."; }
            if (code == BOOKING_EXPIRY_NULL_ERROR) { return "Input Parameter error: booking_qr_expiry is missing."; }
            if (code == BOOKING_ID_NOT_EXISTS) { return "booking_id does not exist"; }
            if (code == CHOOSE_RES_VIS_ERROR) { return "Input resident & visitor id error. Please choose either one of them."; }
            if (code == VISISTOR_ID_NOT_EXISTS) { return "Visitor card_id does not exist"; }
            if (code == REF_CARDNUMBER_NULL_ERROR) { return "Input Parameter error: Reference cardnumber is missing."; }
            if (code == REF_CARDNUMBER_NOT_EXISTS) { return "Reference cardnumber does not exist"; }
            if (code == OCTOPUSNUMBER_NULL_ERROR) { return "Input Parameter error: Octopus cardnumber is missing."; }
            if (code == OCTOPUSNUMBER_NOT_EXISTS) { return "Octopus cardnumber does not exist"; }
            if (code == OCTOPUSNUMBER_IS_DUPLICATED) { return "Octopus cardnumber is already used. Please use another Octopus cardnumber for the registration."; }

            return "other error ";
        }

        public void Success(object dat = null)
        {
            data = dat;
            code = SUCCESS;
            message = get_err_message(code);
        }
        public void Failure(int c, string msg)
        {
            data = null;
            code = c;
            message = msg;
        }
        public void Failure(int c)
        {
            data = null;
            code = c;
            message = get_err_message(code);
        }
    }
}
