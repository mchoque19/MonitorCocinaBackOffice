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
using System.Threading;

namespace MonitorCocinaBackOffice.Module.BusinessObjects
{
	[DefaultClassOptions]
	public partial class Monitor : XPLiteObject
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

		XPCollection<Article> farticles;
		[Association(@"ArticleReferencesMonitor")]
		public XPCollection<Article> Articles
		{
			get { return GetCollection<Article>(nameof(Articles));}

		}


		XPCollection<State> fstates;
		[Association(@"StateReferencesMonitor")]
		public XPCollection<State> States
		{
			get { return GetCollection<State>(nameof(States)); }

		}

		XPCollection<Family> ffamilies;
		[Association(@"FamilyReferencesMonitor")]
		public XPCollection<Family> Families
		{
			get { return GetCollection<Family>(nameof(Families)); }

		}

		XPCollection<Department> fdepartaments;
		[Association(@"DepartmentReferencesMonitor")]
		public XPCollection<Department> Departments
		{
			get { return GetCollection<Department>(nameof(Departments)); }

		}
	}

}
