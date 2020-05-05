using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class PostDB : GeneralDB
    {
        public PostDB() : base("posts", "post_id") { }
        public List<Post> GetPosts()
        {
            var posts = new List<Post>();
            foreach (DataRow dr in table.Rows)
            {
                posts.Add(new Post(dr));
            }
            return posts;
        }
        public List<Post> GetPosts(string username)
        {
            var posts = new List<Post>();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["owner"].Equals(username))
                {
                    posts.Add(new Post(dr));
                }
            }
            return posts;
        }
        public Post GetPost(string username, int post_number)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr["owner"].Equals(username))
                {
                    if (dr["post_number"].Equals(post_number))
                        return new Post(dr);
                }
            }
            throw new Exception("post not found!");
        }
        public Post GetPost(int post_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(post_id))
                {
                    return new Post(dr);
                }
            }
            throw new Exception("post_id not found!");
        }
        public void RemovePost(int post_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(post_id))
                {
                    //delete comments on post
                    new CommentDB().RemoveComments(post_id);
                    //delete the post image
                    Utilities.FileTools.deletePost(dr["owner"].ToString(), (int)dr["post_number"]);
                    //delete row from table
                    DeleteRow(dr);
                    break;
                }
            }
            Save();
        }
        public void RemovePosts(string username)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                if (table.Rows[i]["owner"].Equals(username))
                {
                    //delete comments on post
                    new CommentDB().RemoveComments((int)table.Rows[i]["post_id"]);
                    //delete the post image
                    Utilities.FileTools.deletePost(username, (int)table.Rows[i]["post_number"]);
                    //delete row from table
                    DeleteRow(table.Rows[i]);
                }
            }
            Save();
        }
        public void AddPost(LoginUser login, string post_text)
        {
            table.Rows.Add(post_text, login.Username, login.Posts.Count + 1);
            Save();
        }
        public void EditPost(string post_text, int post_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(post_id))
                {
                    dr["post_text"] = post_text;
                    break;
                }
            }
            Save();
        }
    }
}
