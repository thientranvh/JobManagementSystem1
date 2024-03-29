﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JobManagementSystem.Common
{
    public static class Constants
    {
        public const string DefaultConnection = "DefaultConnection";
        public const string X2 = "x2";
        public const string Admin = "Admin";
        public const string Member = "Member";
        public const string RequestPath = "RequestPath";
        public const string Id = "Id";
        public const string Email = "Email";
        public const string IdHttp = "{id}";
        public const string Name = "Name";
        public const string Asc = "asc";
        public const string OrderBy = "OrderBy";
        public const string OrderByDescending = "OrderByDescending";
        public const string CreateSuccess = "CreateSuccess";
        public const string CreateViewFalse = "CreateFalse";
        public const string UpdateSuccess = "UpdateSuccess";
        public const string UpdateFalse = "UpdateFalse";
        public const string DeleteSuccess = "DeleteSuccess";
        public const string DeleteFalse = "DeleteFalse";
        public const string InjectSuccess = "InjectSuccess";
        public const string InjectFalse = "InjectFalse";
        public const string Plain = "plain";
        public const string SmtpClient = "smtp.gmail.com";
        public const string Xoauth2 = "XOAUTH2";

    }

    public static class UserDefaults
    {
        public const string MailMember = "member";
        public const string MailAdmin = "admin";
        public const string DomainJob = "@job.com.vn";
        public const string Password = "123456";
        public const string AdminName = "Admin";
        public const string MemberName = "Seeker";
        public const string BirthDayAdmin = "26-05-2019";
        public const string BirthDayMember = "26-05-2019";
        public const string PhoneNumberAdmin = "0123456789";
        public const string PhoneNumberMember = "0123456789";
        public const string AddressDefault = "Ha Noi";
        public const string EmailSendMail = "jobmanager@gmail.com";
        public const string PasswordSendMail = "matkhau123";
    }

    public static class CategoryDefaults
    {
        public const string CategoryNameDefaul = "Category name";
    }

    public static class Signs
    {
        public const string Dot = ".";
        public const string Comma = ",";
        public const string Ellipsis = "...";
        public const string Colon = ":";
        public const string Semicolon = ";";
        public const string Exclamation = "!";
        public const string Mark = "?";
        public const string Hyphen = "-";
        public const string Ampersand = "&";
        public const string Plus = "+";
        public const string Equal = "=";
        public const string BackSlash = "\\";
        public const string Slash = "/";
        public const string Tilde = "~";
        public const string DoubleQuotationMarks = "";
    }

    public static class Settings
    {
        public const string NameSpaceWeb = "JobManagementSystem.Web";
    }

    public static class Paths
    {
        public const string PathLogs = "Logs/log-.txt";
    }

    public static class RouteConfigs
    {
        public const string AdminToController = "admin/[controller]";
        public const string AdminToControllerToAction = "admin/[controller]/[action]";
        public const string AdminToControllerToActionToId = "admin/[controller]/[action]/{id}";
        public const string Error400 = "Error/400";
        public const string Error401 = "Error/401";
        public const string Error403 = "Error/403";
        public const string Error404 = "Error/404";
        public const string Error500 = "Error/500";
    }

    public static class RedirectConfig
    {
        public const string HomeError = "/Home/Error";
        public const string AdminAccountAuthentication = "/Account/Authentication";
        public const string AccountAuthentication = "/Account/Authentication";
        public const string AdminUserIndex = "/Admin/User/Index";
        public const string AdminUserLoadTable = "/Admin/User/LoadTable";
        public const string DataImages = "wwwroot/DataImage";
        public const string HomeIndex = "/Home/Index";
        public const string ContactFeedbackFailed = "/Contact/FeedbackFailed";
        public const string ContactFeedbackSuccess = "/Contact/FeedbackSuccess";
        public const string AdminContactIndex = "/Admin/Contact/Index";
    }

    public static class MapRoutesConfig
    {
        public const string HomeIndexId = "{controller=Home}/{action=Index}/{id?}";
        public const string AreasExistsHomeIndex = "{area:exists}/{controller=Home}/{action=Index}";
    }

    public static class MapRouteNames
    {
        public const string Default = "default";
        public const string AreaRoute = "areaRoute";
    }

    public static class TypeOf
    {
        public const string Decimal = "decimal";
        public const string Text = "ntext";
    }

    public static class ActionNames
    {
        public const string Authentication = "Authentication";
        public const string Logout = "Logout";
        public const string Index = "Index";
    }

    public static class ControllerNames
    {
        public const string Account = "Account";
        public const string Home = "Home";
    }

    public static class AreasNames
    {
        public const string AreaAdmin = "Admin";
    }

    public static class RegexConfigs
    {
        public const string RegexMail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
    }

    public static class ParamConstants
    {
        public const string Id = "Id";
        public const string Asc = "asc";
        public const string OrderBy = "OrderBy";
        public const string OrderByDescending = "OrderByDescending";
    }

    public static class TypeMethod
    {
        public const string Post = "POST";
    }

    public static class ContentType
    {
        public const string AppJson = "application/json";
    }

    public static class DataType
    {
        public const string Json = "json";
    }

    public static class Types
    {
        public const string Display = "display";
        public const string Filter = "filter";
    }

    public static class TypeStatus
    {
        public const string True = "true";
        public const string False = "false";
    }

    public static class ViewDataTypes
    {
        public const string ImageLocal = "imageLocal";

    }

    public static class FormatTimes
    {
        public const string DdMmYyyy = "dd-MM-yyyy";
    }

    public static class PathError
    {
        public const string PathError400 = "/Error/400";
        public const string PathError401 = "/Error/401";
        public const string PathError403 = "/Error/403";
        public const string PathError404 = "/Error/404";
        public const string PathError500 = "/Error/500";
    }
}
