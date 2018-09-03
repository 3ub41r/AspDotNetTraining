using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AspDotNetTraining.Models;
using FluentValidation;

namespace AspDotNetTraining.Validators
{
    public class StudentValidator : AbstractValidator<Student>
    {
        public StudentValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("What was your name again?");
            RuleFor(x => x.IcNumber).NotEmpty();
            RuleFor(x => x.MatricNumber).Must(IcAndMatricNotTheSame)
                .WithMessage("Matric Number and IC Number must not be the same.");
        }

        private static bool IcAndMatricNotTheSame(Student student, string matricNumber)
        {
            return student.IcNumber.Equals(matricNumber);
        }
    }
}