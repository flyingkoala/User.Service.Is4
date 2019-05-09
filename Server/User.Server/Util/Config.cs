using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace User.Server.Util
{

    public static class Config
    {
        /// <summary>
        /// 获取身份资源
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        /// <summary>
        /// 获取api资源
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<ApiResource> GetApis()
        {
            return new List<ApiResource>
            {
                new ApiResource("api1", "第一个Api资源")
                {
                    //自定义api可接受的claims
                    UserClaims = new List<string>()
                    {
                        "name","website"
                    }
                }
            };
        }
        /// <summary>
        /// 获取客户端信息
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                //客户端认证 ClientCredentials
                //这种情况适用于没有用户交互，独立的的服务调用api服务的验证
                new Client
                {
                    ClientId = "client1",
                    // no interactive user, use the clientid/secret for authentication
                    AllowedGrantTypes = GrantTypes.ClientCredentials,
                    // secret for authentication
                    ClientSecrets =
                    {
                        new Secret("client1_123456".Sha256())
                    },
                    // scopes that client has access to
                    AllowedScopes = { "api1" },
                    //令牌过期时间，单位为秒，不设置默认为3600秒即1小时
                    AccessTokenLifetime = 30*60
                },
                //密码认证 ResourceOwnerPassword
                new Client
                {
                    ClientId = "client2",
                    AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,

                    ClientSecrets =
                    {
                        new Secret("client2_123456".Sha256())
                    },
                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,//若要调用connect/userinfo获取用户信息，scope至少需要包含openid
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    },
                    AllowOfflineAccess = true,//可返回refreshtoken
                    AccessTokenLifetime = 30*60 //令牌过期时间，单位为秒，不设置默认为3600秒即1小时
                },
                // OpenID Connect implicit flow client (MVC)
                new Client
                {
                    ClientId = "client3",
                    ClientName = "ImplicitFlow模式 mvc客户端",
                    AllowedGrantTypes = GrantTypes.Implicit,
                    
                    // where to redirect to after login
                    RedirectUris = { "http://localhost:5002/signin-oidc" },

                    // where to redirect to after logout
                    PostLogoutRedirectUris = { "http://localhost:5002/signout-callback-oidc" },

                    AllowedScopes = new List<string>
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    },
                    //是否显示同意授权页面
                    RequireConsent = false,
                    //令牌过期时间，单位为秒，不设置默认为3600秒即1小时
                    AccessTokenLifetime = 30*60,
                    AllowAccessTokensViaBrowser = true //使用implicitflow时允许Accesstoken通过浏览器返回
                },
                // OpenID Connect Hybrid flow client (MVC)
                //交互式服务器端（或本地桌面/移动）应用程序使用混合流程（hybrid flow）。 这个流程更安全，因为访问令牌仅通过反向通道传输（并允许访问刷新令牌）
                new Client
                {
                    ClientId = "client4",
                    ClientName = "HybridFlow模式 mvc客户端",
                    AllowedGrantTypes = GrantTypes.Hybrid,
                    ClientSecrets =
                    {
                        new Secret("client4_123456".Sha256())
                    },
                    RedirectUris           = { "http://localhost:5003/signin-oidc" },
                    PostLogoutRedirectUris = { "http://localhost:5003/signout-callback-oidc" },

                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    },
                    //是否显示同意授权页面
                    RequireConsent = false,
                    AllowOfflineAccess = true,
                     //令牌过期时间，单位为秒，不设置默认为3600秒即1小时
                    AccessTokenLifetime = 30*60

                },
                // OpenID Connect JavaScript Client
                //使用authorizationcode从JavaScript请求身份和访问令牌
                new Client
                {
                    ClientId = "client5",
                    ClientName = "JavaScript Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequirePkce = true,
                    RequireClientSecret = false,
                    RedirectUris =           {
                        "http://localhost:5004/callback.html",
                        "http://localhost:5004/silent-renew.html" },
                    PostLogoutRedirectUris = { "http://localhost:5004/index.html" },
                    
                    AllowedCorsOrigins =     { "http://localhost:5004" },
                    AllowedScopes =
                    {
                        IdentityServerConstants.StandardScopes.OpenId,
                        IdentityServerConstants.StandardScopes.Profile,
                        "api1"
                    },
                    //是否显示同意授权页面
                    RequireConsent = false,
                    AllowAccessTokensViaBrowser = true,
                    //令牌过期时间，单位为秒，不设置默认为3600秒即1小时
                    AccessTokenLifetime = 90
                }

            };
        }

        /// <summary>
        /// 获取测试用户
        /// </summary>
        /// <returns></returns>
        public static List<TestUser> GetUsers()
        {
            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "1",
                    Username = "alice",
                    Password = "123456",
                    Claims = new []
                    {
                        new Claim("name", "Alice"),
                        new Claim("website", "https://alice.com")
                    }
                },
                new TestUser
                {
                    SubjectId = "2",
                    Username = "bob",
                    Password = "123456",
                    Claims = new []
                    {
                        new Claim("name", "Bob"),
                        new Claim("website", "https://bob.com")
                    }

                }
            };
        }
    }

}
