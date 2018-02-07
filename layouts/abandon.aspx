<%
    Sitecore.Analytics.Tracker.Current.CurrentPage.Cancel();
    System.Web.HttpContext.Current.Session.Abandon();
%>