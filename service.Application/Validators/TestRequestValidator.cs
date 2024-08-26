using FluentValidation;
using service.Domain.Requests;

namespace service.Application.Validators
{
    public class TestRequestValidator : AbstractValidator<TestRequest>
    {

        public TestRequestValidator() 
        {

            RuleFor(x => x.TestString)
                .NotEmpty()
                .Length(100)
                .Must(value => value.StartsWith("test")).WithMessage("string must start with test")
                .Matches(@"[a-zA-Z]+$").WithMessage("can only be letters");

            RuleFor(x => x.TestInt)
                .GreaterThan(1)
                .LessThan(101);

            RuleFor(x => x.TestBool)
                .Equal(true);

            //RuleFor(x => x.TestDate)
            //    .GreaterThan(DateTime.Now);

            //RuleFor(x => x.TestCollection)
            //    .NotEmpty()
            //    .ForEach(item => item.value.GreaterThan(0));

        }

    }
}
