﻿using System.ComponentModel.DataAnnotations;

namespace Amazon.Services.AuthService.User.Dto
{
	public class ResetPasswordDto
	{
		[Required]
		[StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
		public string Password { get; set; }
		[Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
		public string ConfirmPassword { get; set; }
	}

}
