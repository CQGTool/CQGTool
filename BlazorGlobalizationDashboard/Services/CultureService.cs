using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace BlazorGlobalizationDashboard.Services
{
    public class CultureService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CultureService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public List<CultureData> GetAvailableCultures()
        {
            return new List<CultureData>
            {
                new CultureData { Code = "en-US", Name = "English", NativeName = "English (US)",
                    CurrencySymbol = "$", DateFormat = "MM/dd/yyyy", IsRightToLeft = false },
                new CultureData { Code = "fr-FR", Name = "French", NativeName = "Français",
                    CurrencySymbol = "€", DateFormat = "dd/MM/yyyy", IsRightToLeft = false },
                new CultureData { Code = "es-ES", Name = "Spanish", NativeName = "Español",
                    CurrencySymbol = "€", DateFormat = "dd/MM/yyyy", IsRightToLeft = false },
                new CultureData { Code = "de-DE", Name = "German", NativeName = "Deutsch",
                    CurrencySymbol = "€", DateFormat = "dd.MM.yyyy", IsRightToLeft = false },
                new CultureData { Code = "ja-JP", Name = "Japanese", NativeName = "日本語",
                    CurrencySymbol = "¥", DateFormat = "yyyy/MM/dd", IsRightToLeft = false },
                new CultureData { Code = "hi-IN", Name = "Hindi", NativeName = "हिन्दी",
                    CurrencySymbol = "₹", DateFormat = "dd/MM/yyyy", IsRightToLeft = false },
                new CultureData { Code = "ar-SA", Name = "Arabic", NativeName = "العربية",
                    CurrencySymbol = "ر.س", DateFormat = "dd/MM/yyyy", IsRightToLeft = true },
                new CultureData { Code = "zh-CN", Name = "Chinese", NativeName = "中文",
                    CurrencySymbol = "¥", DateFormat = "yyyy/MM/dd", IsRightToLeft = false }
            };
        }

        public CultureInfo GetCurrentCulture()
        {
            var httpContext = _httpContextAccessor.HttpContext;
            if (httpContext != null)
            {
                var feature = httpContext.Features.Get<IRequestCultureFeature>();
                return feature?.RequestCulture?.Culture ?? CultureInfo.CurrentCulture;
            }
            return CultureInfo.CurrentCulture;
        }

        public string FormatCurrency(decimal amount)
        {
            return amount.ToString("C", GetCurrentCulture());
        }

        public string FormatNumber(double number)
        {
            return number.ToString("N", GetCurrentCulture());
        }

        public string FormatDate(DateTime date)
        {
            return date.ToString("D", GetCurrentCulture());
        }

        public string FormatDateTime(DateTime dateTime)
        {
            return dateTime.ToString("F", GetCurrentCulture());
        }
    }

    public class CultureData
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string NativeName { get; set; } = string.Empty;
        public string CurrencySymbol { get; set; } = string.Empty;
        public string DateFormat { get; set; } = string.Empty;
        public bool IsRightToLeft { get; set; }
    }
}