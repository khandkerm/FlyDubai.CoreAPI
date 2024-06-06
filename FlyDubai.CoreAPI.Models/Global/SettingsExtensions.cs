﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace FlyDubai.CoreAPI.Models.Global
{
    public static class SettingsExtensions
    {
        public static bool IsValid<T>(this T data)
        {
            if (data == null)
                throw new ArgumentNullException(nameof(data));

            var validationResult = new List<ValidationResult>();
            var result = Validator.TryValidateObject(data, new ValidationContext(data), validationResult, false);

            if (!result)
            {
                foreach (var item in validationResult)
                {
                    Debug.WriteLine($"ERROR::{item.MemberNames}:{item.ErrorMessage}");
                }
            }

            return result;
        }
    }
}
