using System;

namespace SharpWinBlogger
{
	public class BlogInfo
	{
		private bool m_isAdmin= false;
		public  bool isAdmin
		{
			get
			{
				return m_isAdmin;
			}
			set
			{
				m_isAdmin = value;
			}
		}

		private bool m_showTitle = false;
		public  bool showTitle 
		{
			get
			{
				return m_showTitle ;
			}
			set
			{
				m_showTitle  = value;
			}
		}

		private string m_blogid = "";
		public  string blogid 
		{
			get
			{
				return m_blogid ;
			}
			set
			{
				m_blogid  = value;
			}
		}

		private string m_url = "";
		public  string url 
		{
			get
			{
				return m_url ;
			}
			set
			{
				m_url  = value;
			}
		}

		private string m_blogName = "";
		public  string blogName 
		{
			get
			{
				return m_blogName ;
			}
			set
			{
				m_blogName  = value;
			}
		}

		private DateTime m_lastPublished = DateTime.Now;
		public  DateTime lastPublished 
		{
			get
			{
				return m_lastPublished ;
			}
			set
			{
				m_lastPublished  = value;
			}
		}

	}
}
