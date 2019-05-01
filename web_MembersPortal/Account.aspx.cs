using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_MembersPortal
{
    public partial class Account : System.Web.UI.Page
    {
        private string activeuser;
        private string id;
        private string path;

        public string successMessage = "Successfully updated user profile!";
        public string formResponse = "Home phone or mobile phone needed \r\n Please enter at least either one. ";

        protected void Page_Load(object sender, EventArgs e)
        {


            path = HttpContext.Current.Request.Url.AbsoluteUri;


            activeuser = path.Replace("http://localhost:58891/Account/?", "");

            Hidden1.Value = activeuser;


            if (activeuser != null)
            {


                try
                {
                    var client1 = new RestClient("https://localhost:44394/api/account/");
                    var request1 = new RestRequest(Method.GET);
                    request1.AddHeader("cache-control", "no-cache");
                    request1.AddHeader("Connection", "keep-alive");
                    request1.AddHeader("accept-encoding", "gzip, deflate");
                    request1.AddHeader("Host", "localhost:44394");

                    request1.AddHeader("Cache-Control", "no-cache");
                    request1.AddHeader("Accept", "*/*");
                    request1.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
                    request1.AddHeader("Content-Type", "application/json");
                    IRestResponse response1 = client1.Execute(request1);

                    var profiles = JsonConvert.DeserializeObject<List<User_Account>>(response1.Content.ToString());


                    foreach (var profile in profiles)
                    {
                        if (profile.username == activeuser)
                        {
                            try
                            {
                                txtRecordId.Text = profile.id.ToString();
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
                                txtDescription.Text = profile.description.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtDescription.Text = "";
                            }
                            try
                            {
                                txtbalance.Text = profile.balance.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtbalance.Text = "";
                            }

                            try
                            {
                                txtDate.Text = profile.lastActivityDate.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtDate.Text = "";
                            }
                            try
                            {
                                id = profile.id.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                id = "";
                            }

                        }

                    }
                }
                catch (Exception exception)
                {
                    exception.ToString();
                }

                try
                {
                    var client = new RestClient("https://localhost:44394/api/checking");
                    var request = new RestRequest(Method.GET);
                    request.AddHeader("cache-control", "no-cache");
                    request.AddHeader("Connection", "keep-alive");
                    request.AddHeader("accept-encoding", "gzip, deflate");
                    request.AddHeader("Host", "localhost:44394");
                    request.AddHeader("Postman-Token", "1dd1f1d1-b352-430d-992d-a8091c130bec,a76aa133-7fd7-43e2-aaa8-e8174680da5e");
                    request.AddHeader("Cache-Control", "no-cache");
                    request.AddHeader("Accept", "*/*");
                    request.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
                    IRestResponse response2 = client.Execute(request);

                    var profiles1 = JsonConvert.DeserializeObject<List<User_Checking>>(response2.Content.ToString());


                    foreach (var profile in profiles1)
                    {
                        if (profile.username == activeuser)
                        {
                            try
                            {
                               txtCheckingId.Text = profile.id.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtCheckingId.Text = "";
                            }

                            try
                            {
                                txtCheckingUsername.Text = profile.username.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtCheckingUsername.Text = "";
                            }

                            try
                            {
                               txtCheckingDesc.Text= profile.description.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                               txtCheckingDesc.Text = "";
                            }
                            try
                            {
                                txtCheckingBalance.Text = profile.balance.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtCheckingBalance.Text = "";
                            }

                            try
                            {
                                txtCheckingDate.Text = profile.lastActivityDate.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtCheckingDate.Text = "";
                            }
                            try
                            {
                                id = profile.id.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                id = "";
                            }

                        }
               

                    }

                }
                catch(Exception e1)
                {
                    e1.ToString();
                }

                try
                {
                    var client2 = new RestClient("https://localhost:44394/api/loan");
                    var request2 = new RestRequest(Method.GET);
                    request2.AddHeader("cache-control", "no-cache");
                    request2.AddHeader("Connection", "keep-alive");
                    request2.AddHeader("accept-encoding", "gzip, deflate");
                    request2.AddHeader("Host", "localhost:44394");
                    request2.AddHeader("Postman-Token", "76d090d4-ebcc-4450-8be4-29cc32a22a8f,3867a245-b632-43e2-8de3-adafc34f0606");
                    request2.AddHeader("Cache-Control", "no-cache");
                    request2.AddHeader("Accept", "*/*");
                    request2.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
                    IRestResponse response3 = client2.Execute(request2);
                    var profiles2 = JsonConvert.DeserializeObject<List<User_Loan>>(response3.Content.ToString());


                    foreach (var profile in profiles2)
                    {
                        if (profile.username == activeuser)
                        {
                            try
                            {
                               txtLoanId.Text = profile.Id.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtLoanId.Text = "";
                            }

                            try
                            {
                                txtLoanUser.Text = profile.username.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtLoanUser.Text = "";
                            }

                            try
                            {
                                txtLoanDesc.Text = profile.description.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtLoanDesc.Text = "";
                            }
                            try
                            {
                               txtLoanBalance.Text = profile.balance.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtLoanBalance.Text = "";
                            }

                            try
                            {
                                txtLastActivity.Text = profile.lastActivityDate.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                               txtLastActivity.Text = "";
                            }
                            try
                            {
                                txtDueDate.Text = profile.paymentDueDate.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtDueDate.Text = "";
                            }
                            try
                            {
                                txtPayment.Text = profile.minimumAmountDue.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtPayment.Text = "";
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

                        }


                    }

                }
                catch(Exception ex1)
                {
                    ex1.ToString();
                }

                try
                {
                    var client3 = new RestClient("https://localhost:44394/api/certificate");
                    var request3 = new RestRequest(Method.GET);
                    request3.AddHeader("cache-control", "no-cache");
                    request3.AddHeader("Connection", "keep-alive");
                    request3.AddHeader("accept-encoding", "gzip, deflate");
                    request3.AddHeader("Host", "localhost:44394");
                    request3.AddHeader("Postman-Token", "8a6751d5-5a12-408e-b2fd-e8f161fb502d,13588711-f7c8-478b-972c-baa4e3f741f0");
                    request3.AddHeader("Cache-Control", "no-cache");
                    request3.AddHeader("Accept", "*/*");
                    request3.AddHeader("User-Agent", "PostmanRuntime/7.11.0");
                    IRestResponse response = client3.Execute(request3);
                    var profiles3 = JsonConvert.DeserializeObject<List<User_Certificate>>(response.Content.ToString());


                    foreach (var profile in profiles3)
                    {
                        if (profile.username == activeuser)
                        {
                            try
                            {
                                txtcId.Text = profile.Id.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtcId.Text = "";
                            }

                            try
                            {
                                txtLoanUser.Text = profile.username.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtLoanUser.Text = "";
                            }

                            try
                            {
                               txtcDesc.Text = profile.description.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtcDesc.Text = "";
                            }
                            try
                            {
                                txtcBalance.Text = profile.balance.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtcBalance.Text = "";
                            }

                            try
                            {
                               txtcActivityDate.Text = profile.lastActivityDate.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtcActivityDate.Text = "";
                            }
                            try
                            {
                                txtInterest.Text = profile.interestRate.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtInterest.Text = "";
                            }
                            try
                            {
                               txtMaturityDate.Text= profile.maturityDate.ToString();
                            }
                            catch (NullReferenceException ex)
                            {
                                ex.ToString();
                                txtPayment.Text = "";
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

                        }


                    }

                }
               catch(Exception ex2)
                {
                    ex2.ToString();
                }
            }
        }
 
    

        protected void btnProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:58891/UserPages/?" + Hidden1.Value);
        }
    }
}