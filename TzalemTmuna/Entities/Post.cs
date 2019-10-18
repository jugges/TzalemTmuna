using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TzalemTmuna.Entities
{
    class Post
    {
        int post_id;
        string post_text;
        string src;
        User owner;
        List<User> likes;
        List<Comment> comments;
    }
}
