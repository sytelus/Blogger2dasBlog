using System;

namespace SharpWinBlogger
{
	public class BloggerPost
	{
		private string m_content;
		public  string content
		{
			get
			{
				return m_content;
			}
			set
			{
				m_content = value;
			}
		}

		private string m_userid;
		public  string userid
		{
			get
			{
				return m_userid;
			}
			set
			{
				m_userid = value;
			}
		}

		private string m_postid;
		public  string postid
		{
			get
			{
				return m_postid;
			}
			set
			{
				m_postid = value;
			}
		}

		private DateTime m_dateCreated;
		public  DateTime dateCreated
		{
			get
			{
				return m_dateCreated;
			}
			set
			{
				m_dateCreated = value;
			}
		}

		private DateTime m_lastModified;
		public  DateTime lastModified
		{
			get
			{
				return m_lastModified;
			}
			set
			{
				m_lastModified = value;
			}
		}

		private string m_authorName;
		public  string authorName
		{
			get
			{
				return m_authorName;
			}
			set
			{
				m_authorName = value;
			}
		}

		private DateTime m_postDate;
		public  DateTime postDate
		{
			get
			{
				return m_postDate;
			}
			set
			{
				m_postDate = value;
			}
		}

		private string m_title;
		public  string title
		{
			get
			{
				return m_title;
			}
			set
			{
				m_title = value;
			}
		}

		private string m_status;
		public  string status
		{
			get
			{
				return m_status;
			}
			set
			{
				m_status = value;
			}
		}

	}
}
