using System;
using System.Collections.Generic;

namespace MELCloudAPILib
{
    public class LoginReply
    {
        public object ErrorId { get; set; }
        public object ErrorMessage { get; set; }
        public int LoginStatus { get; set; }
        public int UserId { get; set; }
        public object RandomKey { get; set; }
        public object AppVersionAnnouncement { get; set; }
        public LoginData LoginData { get; set; }
        public List<object> ListPendingInvite { get; set; }
        public List<object> ListOwnershipChangeRequest { get; set; }
        public List<object> ListPendingAnnouncement { get; set; }
        public int LoginMinutes { get; set; }
        public int LoginAttempts { get; set; }

        public string GetToken(LoginReply reply)
        {
            return reply.LoginData.ContextKey;
        }
    }


    public class LoginData
    {
        public string ContextKey { get; set; }
        public int Client { get; set; }
        public int Terms { get; set; }
        public int AL { get; set; }
        public int ML { get; set; }
        public bool CMI { get; set; }
        public bool IsStaff { get; set; }
        public bool CUTF { get; set; }
        public bool CAA { get; set; }
        public bool ReceiveCountryNotifications { get; set; }
        public bool ReceiveAllNotifications { get; set; }
        public bool CACA { get; set; }
        public bool CAGA { get; set; }
        public int MaximumDevices { get; set; }
        public bool ShowDiagnostics { get; set; }
        public int Language { get; set; }
        public int Country { get; set; }
        public int RealClient { get; set; }
        public string Name { get; set; }
        public bool UseFahrenheit { get; set; }
        public int Duration { get; set; }
        public DateTime Expiry { get; set; }
        public bool CMSC { get; set; }
        public object PartnerApplicationVersion { get; set; }
        public bool EmailSettingsReminderShown { get; set; }
        public int EmailUnitErrors { get; set; }
        public int EmailCommsErrors { get; set; }
        public int ChartSeriesHidden { get; set; }
        public bool IsImpersonated { get; set; }
        public string LanguageCode { get; set; }
        public string CountryName { get; set; }
        public string CurrencySymbol { get; set; }
        public string SupportEmailAddress { get; set; }
        public string DateSeperator { get; set; }
        public string TimeSeperator { get; set; }
        public string AtwLogoFile { get; set; }
        public bool DECCReport { get; set; }
        public bool CSVReport1min { get; set; }
        public bool HidePresetPanel { get; set; }
        public bool EmailSettingsReminderRequired { get; set; }
        public string TermsText { get; set; }
        public bool MapView { get; set; }
        public int MapZoom { get; set; }
        public double MapLongitude { get; set; }
        public double MapLatitude { get; set; }


    }
}
