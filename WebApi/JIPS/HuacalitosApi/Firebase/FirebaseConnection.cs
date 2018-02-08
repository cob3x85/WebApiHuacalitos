using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Auth;

namespace HuacalitosApi.Firebase
{
  public class FirebaseConnection : IFirebaseAuthProvider
  {
    private readonly string FirebaseApiKey = "AIzaSyD_cRIU6UUcJdWJhLJWbjef3Zm0K6e2rnM";
    private FirebaseAuthProvider authProvider { get; set; }
    private FirebaseConfig config { get; set; }

    public FirebaseConnection()
    {
      config = new FirebaseConfig(FirebaseApiKey);
      authProvider = new FirebaseAuthProvider(config);
    }

    public async Task<FirebaseAuthLink> SignInWithEmailAndPasswordAsync(string username, string password)
    {
      var auth = await authProvider.SignInWithEmailAndPasswordAsync("cob3x85@outlook.com", "cob3x85");
      return auth;
    }

    public Task<FirebaseAuthLink> CreateUserWithEmailAndPasswordAsync(string email, string password, string displayName = "", bool sendVerificationEmail = false)
    {
      throw new NotImplementedException();
    }

    public Task SendPasswordResetEmailAsync(string email)
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> SignInAnonymouslyAsync()
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> SignInWithOAuthAsync(FirebaseAuthType authType, string oauthAccessToken)
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> SignInWithCustomTokenAsync(string customToken)
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> LinkAccountsAsync(FirebaseAuth auth, string email, string password)
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> LinkAccountsAsync(string firebaseToken, string email, string password)
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> LinkAccountsAsync(FirebaseAuth auth, FirebaseAuthType authType, string oauthAccessToken)
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> LinkAccountsAsync(string firebaseToken, FirebaseAuthType authType, string oauthAccessToken)
    {
      throw new NotImplementedException();
    }

    public Task<ProviderQueryResult> GetLinkedAccountsAsync(string email)
    {
      throw new NotImplementedException();
    }

    public Task<User> GetUserAsync(string firebaseToken)
    {
      throw new NotImplementedException();
    }

    public Task<User> GetUserAsync(FirebaseAuth auth)
    {
      throw new NotImplementedException();
    }

    public Task SendEmailVerificationAsync(string firebaseToken)
    {
      throw new NotImplementedException();
    }

    public Task SendEmailVerificationAsync(FirebaseAuth auth)
    {
      throw new NotImplementedException();
    }

    public Task<FirebaseAuthLink> RefreshAuthAsync(FirebaseAuth auth)
    {
      throw new NotImplementedException();
    }
  }
}
