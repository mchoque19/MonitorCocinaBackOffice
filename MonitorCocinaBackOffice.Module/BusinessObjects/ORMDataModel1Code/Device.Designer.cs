﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;

namespace MonitorCocinaBackOffice.Module.BusinessObjects
{
	[DefaultClassOptions]
	public partial class Device : XPLiteObject
	{
		int fId;
		[Key(true)]
		public int Id
		{
			get { return fId; }
			set { SetPropertyValue<int>(nameof(Id), ref fId, value); }
		}
		string fName;
		[Size(SizeAttribute.Unlimited)]
		public string Name
		{
			get { return fName; }
			set { SetPropertyValue<string>(nameof(Name), ref fName, value); }
		}


		string fMac;
		[Size(SizeAttribute.Unlimited)]
		public string Mac
		{
			get { return fMac; }
			set { SetPropertyValue<string>(nameof(Mac), ref fMac, value); }
		}

		string fIp;
		[Size(SizeAttribute.Unlimited)]
		public string Ip
		{
			get { return fIp; }
			set { SetPropertyValue<string>(nameof(Ip), ref fIp, value); }
		}

		string fVersion;
		[Size(SizeAttribute.Unlimited)]
		public string Version
		{
			get { return fVersion; }
			set { SetPropertyValue<string>(nameof(Version), ref fVersion, value); }
		}


		DateTime fDate;
		[Size(SizeAttribute.Unlimited)]
		public DateTime Date
		{
			get { return fDate; }
			set { SetPropertyValue<DateTime>(nameof(Date), ref fDate, value); }
		}

		bool fActive;
		[Size(SizeAttribute.Unlimited)]
		public bool Active
		{
			get { return fActive; }
			set { SetPropertyValue<bool>(nameof(Active), ref fActive, value); }
		}


	}

}