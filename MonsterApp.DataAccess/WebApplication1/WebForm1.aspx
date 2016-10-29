<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<% Response.Write(System.Security.Principal.WindowsIdentity.GetCurrent().Name); %>