using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;
using TzalemTmuna.Statics;

namespace TzalemTmuna.DB
{
    public class CommentDB : GeneralDB
    {
        public CommentDB(): base("comments", "comment_id") { }
        public List<Comment> GetComments()
        {
            var comment = new List<Comment>();
            foreach (DataRow dr in table.Rows)
            {
                comment.Add(new Comment(dr));
            }
            return comment;
        }
        public Comment GetComment(int comment_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(comment_id))
                {
                    return new Comment(dr);
                }
            }
            throw new Exception("comment_id not found!");
        }
        public List<Comment> GetComments(int post_id)
        {
            var comments = new List<Comment>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["post_id"].Equals(post_id))
                {
                    if (udb.Find(dr["owner"]))
                        comments.Add(new Comment(dr));
                    else
                        throw new Exception("Comment owner was not found in users database!");
                }
            }
            return comments;
        }
        public void RemoveComments(int post_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr["post_id"].Equals(post_id))
                {
                    DeleteRow(dr);
                }
            }
            Save();
        }
        public void RemoveComments(string username)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr["owner"].Equals(username))
                {
                    //delete row from table
                    DeleteRow(dr);
                }
            }
            Save();
        }
        public void RemoveComment(int comment_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(comment_id))
                {
                        DeleteRow(dr);
                        break;
                }
            }
            Save();
        }
        //DELETED: USING SQL QUERY WORKS BEST FOR AUTO FIELDS, REFER TO btnSubmit_Click() IN ViewPost.cs
        //public void AddComment(string comment_text, int post_id)
        //{
        //    table.Rows.Add(null,post_id,comment_text,LoggedInUser.login.Username);
        //    Save();
        //}
        public void EditComment(string comment_text, int comment_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(comment_id))
                {
                    dr["comment_text"] = comment_text;
                    break;
                }
            }
            Save();
        }
    }
}
