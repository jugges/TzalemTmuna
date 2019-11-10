using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class CommentDB : GeneralDB
    {
        public CommentDB(): base("comments", "comment_id") { }
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
        public void AddComment(LoginUser login, string comment_text, int post_id)
        {
            table.Rows.Add(post_id,comment_text,login.Username);
            Save();
        }
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
