using System;

using System.Data;
using System.Collections;
using JDSolutions.XmlRpc;
using JDSolutions.XmlRpc.Elements;

namespace SharpWinBlogger
{
	/// <summary>
	/// Summary description for 
	/// </summary>
	public class Blogger
	{
		private string BloggerApiKey = "B9C296C4DC1F09ED61129B1FDBFFE589482E5DAA";
		public string BloggerApiUrl = "http://api.blogger.com/api";

		private string m_userName = "";
		private string m_password = "";
		private string m_blogID= "";

		public Blogger (string userName, string password)
		{
			m_userName = userName;
			m_password = password;
		}

		public string BlogID
		{
			get
			{
				return m_blogID;
			}
			set
			{
				m_blogID = value;
			}
		}

		/// <summary>
		/// Makes a new post to a designated blog. Optionally, will publish the blog after making the post.
		/// </summary>
		/// <param name="content">The body of the post.</param>
		/// <param name="publish">Specifies whether or not to republish the weblog upon posting this post.</param>
		public bool PostNewBlog(
			string content,
			bool publish) 
		{
			XmlRpcClient client = new XmlRpcClient();
			return (bool)client.Call(new Uri(BloggerApiUrl), "blogger.newPost", 
				new object[] {BloggerApiKey, m_blogID, m_userName, m_password, content, publish});
		}

		/// <summary>
		/// Edits a given post. Optionally, will publish the blog after making the edit. 
		/// </summary>
		/// <param name="postid">The id of the weblog entry to edit</param>
		/// <param name="content">The body of the post.</param>
		/// <param name="publish">Specifies whether or not to republish the weblog upon posting this post.</param>
		public bool EditExistingPost(
			string postid,
			string content,
			bool publish) 
		{
			XmlRpcClient client = new XmlRpcClient();
			return (bool)client.Call(new Uri(BloggerApiUrl), "blogger.editPost", 
				new object[] {BloggerApiKey, postid, m_userName, m_password, content, publish});
		}

		/// <summary>
		/// Returns information on all the blogs a given user is a member of. 
		/// </summary>
		/// <param name="m_userName">The m_userName of the user authorized to perform this action.</param>
		/// <param name="m_password">The m_password of the user authorized to perform this action.</param>
		public BlogInfo[] GetUserBlogInfo() 
		{
			XmlRpcClient client = new XmlRpcClient();
			Array a = (Array)client.Call(new Uri(BloggerApiUrl), "blogger.getUsersBlogs", 
				new object[] {BloggerApiKey, m_userName, m_password});
			try 
			{
				ArrayList a2 = new ArrayList();
				for (int i=0;i<a.Length;i++) 
				{
					a2.Add((BlogInfo)XmlRpcTools.DeserializeObject((XmlRpcStruct)a.GetValue(i), typeof(BlogInfo)));
				}
				BlogInfo[] bi = (BlogInfo[])a2.ToArray(typeof(BlogInfo));
				return bi;
			} 
			catch 
			{ // no result
				return new BlogInfo[] {};
			}
		}

		/// <summary>
		/// Authenticates a user and returns basic user info (name, email, userid, etc.). 
		/// </summary>
		public UserInfo GetUserInfo() 
		{
			XmlRpcClient client = new XmlRpcClient();
			return (UserInfo)XmlRpcTools.DeserializeObject(((XmlRpcStruct)client.Call(new Uri(BloggerApiUrl), "blogger.getUserInfo", 
				new object[] {BloggerApiKey, m_userName, m_password})), typeof(UserInfo));
		}

		/// <summary>
		/// Returns the main or archive index template of a given blog. 
		/// </summary>
		/// <param name="m_blogID">The id of the weblog.</param>
		/// <param name="m_userName">The m_userName of the user authorized to perform this action.</param>
		/// <param name="m_password">The m_password of the user authorized to perform this action.</param>
		/// <param name="templateType">The name of the template ("main" or "archiveIndex")</param>
		public string GetTemplate(
			string m_blogID,
			string templateType) 
		{
			XmlRpcClient client = new XmlRpcClient();
			return (string)client.Call(new Uri(BloggerApiUrl), "blogger.getTemplate", 
				new object[] {BloggerApiKey, m_blogID, m_userName, m_password, templateType});
		}

		/// <summary>Edits the main or archive index template of a given blog.</summary>
		/// <param name="m_blogID">The id of the weblog.</param>
		/// <param name="m_userName">The m_userName of the user authorized to perform this action.</param>
		/// <param name="m_password">The m_password of the user authorized to perform this action.</param>
		/// <param name="template">The text for the new template (usually mostly HTML). Must contain opening and closing Blogger tags, since they're needed to publish.</param>
		/// <param name="templateType">The name of the template ("main" or "archiveIndex")</param>
		public bool SetTemplate(
			string m_blogID,
			string template,
			string templateType) 
		{
			XmlRpcClient client = new XmlRpcClient();
			return (bool)client.Call(new Uri(BloggerApiUrl), "blogger.setTemplate", 
				new object[] {BloggerApiKey, m_blogID, m_userName, m_password, template, templateType});
		}

		/// <summary>
		/// Returns a struct (like the structs in getRecentPosts) containing the 
		/// userid, post body, datecreated, and post id.
		/// </summary>
		/// <param name="postid">The id of the weblog article</param>
		/// <param name="m_userName">The m_userName of the user authorized to perform this action.</param>
		/// <param name="m_password">The m_password of the user authorized to perform this action.</param>
		public BloggerPost GetPost(
			string postid) 
		{
			XmlRpcClient client = new XmlRpcClient();
			return (BloggerPost)XmlRpcTools.DeserializeObject((XmlRpcStruct)client.Call(new Uri(BloggerApiUrl), "blogger.getPost", 
				new object[] {BloggerApiKey, postid, m_userName, m_password}), typeof(BloggerPost));
		}

		public void GetRecentPostsInDataSet(
			int numberOfPosts, DataSet blogDataSet) 
		{
			DataTable blogItemTable;
			if (blogDataSet.Tables.Contains("BlogItem")==false)
			{
				blogItemTable = blogDataSet.Tables.Add("BlogItem");
				blogItemTable.Columns.Add("Content", typeof(string));
				blogItemTable.Columns.Add("AuthorName", typeof(string));
				blogItemTable.Columns.Add("DateCreated", typeof(DateTime));
				blogItemTable.Columns.Add("LastModified", typeof(DateTime));
				blogItemTable.Columns.Add("PostDate", typeof(DateTime));
				blogItemTable.Columns.Add("PostID", typeof(string));
				blogItemTable.Columns.Add("Status", typeof(string));
				blogItemTable.Columns.Add("Title", typeof(string));
				blogItemTable.Columns.Add("UserID", typeof(string));
			}
			else
				blogItemTable = blogDataSet.Tables["BlogItem"];

			BloggerPost[] blogItemArray = this.GetRecentPosts(numberOfPosts);
			foreach (BloggerPost blogItem in blogItemArray)
			{
				DataRow newRow = blogItemTable.Rows.Add(new object[] {});
				newRow["Content"] = blogItem.content;
				newRow["AuthorName"] = blogItem.authorName;
				newRow["DateCreated"] = blogItem.dateCreated;
				newRow["LastModified"] = blogItem.lastModified;
				newRow["PostDate"] = blogItem.postDate;
				newRow["PostID"] = blogItem.postid;
				newRow["Status"] = blogItem.status;
				newRow["Title"] = blogItem.title;
				newRow["UserID"] = blogItem.userid;
			}
		}


		/// <summary>
		/// Returns an array of structs containing the latest n posts to a given 
		/// blog, newest first.</summary>
		/// <param name="m_blogID">The id of the weblog</param>
		/// <param name="m_userName">The m_userName of the user authorized to perform this action.</param>
		/// <param name="m_password">The m_password of the user authorized to perform this action.</param>
		/// <param name="numberOfPosts">Maximum number of posts to retrieve (up to 20).</param>
		public BloggerPost[] GetRecentPosts(
			int numberOfPosts) 
		{
			XmlRpcClient client = new XmlRpcClient();
			Array a = (Array)client.Call(new Uri(BloggerApiUrl), "blogger.getRecentPosts", 
				new object[] {BloggerApiKey, m_blogID, m_userName, m_password, numberOfPosts});
			try 
			{
				ArrayList a2 = new ArrayList(a.Length);
				for (int i=0;i<a.Length;i++) 
				{
					XmlRpcStruct s = (XmlRpcStruct)a.GetValue(i);
					a2.Add((BloggerPost)XmlRpcTools.DeserializeObject(s, typeof(BloggerPost)));
				}
				return (BloggerPost[])a2.ToArray(typeof(BloggerPost));
			} 
			catch 
			{ // no result
				return new BloggerPost[] {};
			}
		}

		/// <summary>
		/// This, um, deletes a post. Same permissions requirements as blogger_editPost 
		/// (user must have created the post or be an admin on the associated 
		/// blog).
		/// 
		/// Publish will either republish the blog after deleting the post (true) 
		/// or now (false).
		/// </summary>
		/// <param name="postid">The id of the post to delete</param>
		public bool DeletePost(
			string postid,
			bool publish) 
		{
			XmlRpcClient client = new XmlRpcClient();
			return (bool)client.Call(new Uri(BloggerApiUrl), "blogger.deletePost", 
				new object[] {BloggerApiKey, postid, m_userName, m_password, publish});
		}
	}
}
