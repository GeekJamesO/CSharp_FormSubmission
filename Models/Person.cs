using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;



namespace FormSubmission.Models
{
	class Person
	{
		[Required]
		[MinLength(4)]
		public string FirstName { get; set; }

		[Required]
		[MinLength(4)]
		public string LastName { get; set; }

		[Required]
		[Range(1,140)]
		public int Age { get; set; }

		[Required]
		[EmailAddress]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		[Required]
		[MinLength(8)]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}