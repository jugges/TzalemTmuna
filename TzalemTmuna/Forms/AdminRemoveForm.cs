using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using TzalemTmuna.DB;
using TzalemTmuna.Utilities;
using TzalemTmuna.Entities;
using TzalemTmuna.Data;
using TzalemTmuna.Statics;

namespace TzalemTmuna.Forms
{
    public partial class AdminRemoveForm : MetroFramework.Forms.MetroForm
    {
        public AdminRemoveForm()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
        }
        public AdminRemoveForm(Report report)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };

            btnSubmit.Click += (sender,e) => CloseReport(sender,e,report);
        }

        public AdminRemoveForm(Post post)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };

            Text = "Remove Post";
            lblReason.Text = "The reason for removing this post:";
            btnSubmit.Click += (sender,e) => RemovePost(sender,e,post);
        }

        public AdminRemoveForm(Comment comment)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };

            Text = "Remove Comment";
            lblReason.Text = "The reason for removing this comment:";
            btnSubmit.Click += (sender, e) => RemoveComment(sender, e, comment);
        }

        public AdminRemoveForm(User user, bool ban)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };

            Text = ban ? "Ban User" : "Unban User";
            lblReason.Text = $"The reason for {(ban?"":"un")}banning this user:";
            btnSubmit.Click += (sender, e) => UserAction(sender, e, user, ban);
        }

        private void CloseReport(object sender, EventArgs e, Report report)
        {
            if (TextTools.StripWhitespace(txtText.Text) != string.Empty)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Confirm closing of report \"" + report.Report_text + "\"", "Close Report", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ReportDB().CloseReport(report.Report_id);
                    new AlertDB().NewAlert($"Your report:\n\r\"{report.Report_text}\"\n\r\n\rWas closed by an admin:\n\r\"{txtText.Text}\"", report.Owner);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Report closing description cannot be empty!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void RemovePost(object sender, EventArgs e, Post post)
        {
            if (TextTools.StripWhitespace(txtText.Text) != string.Empty)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Confirm removal of post \"" + post.Post_text + "\"", "Remove Post", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new PostDB().RemovePost(post.Post_id);
                    new AlertDB().NewAlert($"Your post:\n\r\"{post.Post_text}\"\n\r\n\rWas removed by an admin:\n\r\"{txtText.Text}\"", post.Owner);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Reason description cannot be empty!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void RemoveComment(object sender, EventArgs e, Comment comment)
        {
            if (TextTools.StripWhitespace(txtText.Text) != string.Empty)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Confirm removal of comment \"" + comment.Comment_text + "\"", "Remove Post", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new CommentDB().RemoveComment(comment.Comment_id);
                    new AlertDB().NewAlert($"Your comment:\n\r\"{comment.Comment_text}\"\n\r\n\rWas removed by an admin:\n\r\"{txtText.Text}\"", comment.Owner);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Reason description cannot be empty!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }

        private void UserAction(object sender, EventArgs e, User user, bool ban)
        {
            if (TextTools.StripWhitespace(txtText.Text) != string.Empty)
            {
                if (MetroFramework.MetroMessageBox.Show(this, $"Confirm {(ban ? "":"un")}banning of user \"" + user.Username + "\"", $"{(ban ? "Ban":"Unban")} User", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new UserDB().ActionUser(user.Username,ban?txtText.Text:"");
                    if (!ban)
                        new AlertDB().NewAlert($"You were unbanned by an admin:\n\r\"{txtText.Text}\"", user);
                    //remove banned user's posts and comments
                    else
                    {
                        //Clear DB from this user's deeds
                        new PostDB().RemovePosts(user.Username);
                        new CommentDB().RemoveComments(user.Username);
                        new AlertDB().RemoveAlerts(user.Username);
                        new FollowingDB().RemoveFollowings(user.Username);
                        new LikeDB().RemoveLikes(user.Username);
                        new ReportDB().RemoveReports(user.Username);
                        new RequestsDB().RemoveRequests(user.Username);
                    }
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Reason description cannot be empty!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
