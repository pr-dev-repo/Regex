   public class NewPasswordViewModel
    {
        [Required(ErrorMessage = "New Password is Required.")]
        [RegularExpression("^(?=.*\\d{4,})(?=.*[a-z])(?=.*[A-Z]).{8,20}$", ErrorMessage ="The value provided for the new password field does not meet our policy complexity, please try again. " )]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password is Requiered")]
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage ="Password fields do not match, please try again.")]
        public string NewPasswordConfirm { get; set; }
  
    }
