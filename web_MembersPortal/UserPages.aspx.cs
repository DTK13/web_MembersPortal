using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Net.Http;
using web_MembersPortal.Models;
using System.Net.Mail;

namespace web_MembersPortal
{
    public partial class UserPages : System.Web.UI.Page
    {
        private string activeuser;
        private string id;
        private string path;
        private bool IsValid = false;
        public string successMessage = "Successfully updated user profile!";
        public string formResponse = "Home phone or mobile phone needed \r\n Please enter at least either one. ";

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            getUser();
        }
        protected void getUser()
        {
            string path = HttpContext.Current.Request.Url.AbsoluteUri;

            activeuser = path.Replace("http://localhost:58891/UserPages/?", "");

            txtactiveuser.Text = activeuser;


            if (activeuser != null)
            {


                try
                {
                    var client = new RestClient("https://localhost:44394/api/profile/");
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("Connection", "keep-alive");
                    request.AddHeader("accept-encoding", "gzip, deflate");
                    request.AddHeader("Host", "localhost:44394");

                    request.AddHeader("Cache-Control", "no-cache");
                    request.AddHeader("Accept", "*/*");
                    request.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
                    request.AddHeader("Content-Type", "application/json");
                    IRestResponse response = client.Execute(request);

                    var profiles = JsonConvert.DeserializeObject<List<Profile>>(response.Content.ToString());


                    foreach (var profile in profiles)
                    {
                        if (profile.username == activeuser)
                        {
                            try
                            {
                                txtRecordId.Text = profile.Id.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtRecordId.Text = "";
                            }

                            try
                            {
                                txtUsername.Text = profile.username.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtUsername.Text = "";
                            }

                            try
                            {
                                txtName.Text = profile.name.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtName.Text = "";
                            }
                            try
                            {
                                txtstreetAddress.Text = profile.street_address.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtstreetAddress.Text = "";
                            }

                            try
                            {
                                txtcity.Text = profile.city.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtcity.Text = "";
                            }

                            try
                            {
                                txtState.Text = profile.state.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtState.Text = "";
                            }
                            try
                            {
                                txtzipcode.Text = profile.zipCode.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtzipcode.Text = "";
                            }

                            try
                            {

                                txtHomePhone.Text = profile.home_phone.ToString();
                            }

                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtHomePhone.Text = "";
                            }

                            try
                            {
                                txtMobilePhone.Text = profile.mobile_Phone.ToString();
                            }

                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtMobilePhone.Text = "";
                            }

                            try
                            {
                                txtEmailAddress.Text = profile.email_Address.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtEmailAddress.Text = "";
                            }

                            try
                            {
                                id = profile.Id.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                id = "";
                            }

                            hidden1.Value = id;
                            hidden2.Value = txtUsername.Text;
                            hidden3.Value = txtName.Text;

                        }

                    }
                }
                catch (Exception exception)
                {
                    exception.ToString();
                }

            }

        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            txtResponse.Visible = false;
            if (txtHomePhone.Text.All(x => char.IsDigit(x)) && txtHomePhone.Text.Length <= 12)
            {

                if (txtEmailAddress.Text.Contains("@"))
                    {


                    path = HttpContext.Current.Request.Url.AbsoluteUri;
                    activeuser = path.Replace("http://localhost:58891/UserPages/?", "");


                    hidden1.Value.ToString();

                    if (activeuser == "DTK13" || activeuser == "JMax23" || activeuser == "EP432")
                    {


                        if (txtHomePhone.Text != "" || txtMobilePhone.Text != "")
                        {
                            var client = new RestClient("https://localhost:44394/api/profile/" + hidden1.Value);
                            var request = new RestRequest(Method.PUT);
                            request.AddHeader("cache-control", "no-cache");
                            request.AddHeader("Connection", "keep-alive");
                            request.AddHeader("accept-encoding", "gzip, deflate");
                            request.AddHeader("Cache-Control", "no-cache");
                            request.AddHeader("Accept", "*/*");
                            request.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
                            request.AddHeader("Content-Type", "application/json");
                            request.AddParameter("undefined", " {\n \"id\":\"" + hidden1.Value + "\",\n \"username\":\"" + hidden2.Value + "\",\n \"name\":\"" + hidden3.Value + "\",\n       \"street_address\": \"" + txtstreetAddress.Text + "\",\n        \"city\": \"" + txtcity.Text + "\",\n        \"state\": \"" + txtState.Text + "\",\n        \"zipCode\":" + txtzipcode.Text + ",\n        \"home_phone\": \"" + txtHomePhone.Text + "\",\n        \"mobile_Phone\": \"" + txtMobilePhone.Text + "\",\n        \"email_Address\": \"" + txtEmailAddress.Text + "\"\n    }", ParameterType.RequestBody);
                            IRestResponse response = client.Execute(request);

                            var responsecode = Convert.ToInt32(response.StatusCode);
                            if (responsecode == 204)
                            {
                                txtResponse.Visible = true;
                                txtResponse.Text = "Successfully updated your profile";
                            }


                        }

                    }
                }
                else
                {
                    txtResponse.Visible = true;
                    txtResponse.Text = "Email is not in valid format (does not contain @ symbol)";
                }
            }
            else
            {
                txtResponse.Visible = true;
                txtResponse.Text = "Invalid Home Phone Number";
            }

        }
        protected void btnAccount_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:58891/Account/?"+txtUsername.Text);

        }





    }
}