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
        public List<Post> GetPosts(string username)
        {
            var posts = new List<Post>();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["owner"].Equals(username))
                {
                    posts.Add(new Post(GetCurrentRow()));
                }
            }
            return posts;
        }
        public Post GetPost(string username,int post_number)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr["owner"].Equals(username))
                {
                    if(dr["post_number"].Equals(post_number))
                        return new Post(GetCurrentRow());
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
                    return new Post(GetCurrentRow());
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
                    DeleteRow(dr);
                    break;
                }
            }
            Save();
        }
        public void AddPost(LoginUser login, string post_text)
        {
            table.Rows.Add(post_text, login.Username, login.Posts.Count+1);
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
