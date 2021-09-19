export const server = 'https://localhost:44350';

export const webAPIUrl = `${server}/api`;

export const authSettings = {
  domain: 'dev-orp5fiyt.us.auth0.com',
  client_id: 'W8Ha27fHXAiRMMmU1WMszsatGODA2rio',
  redirect_uri: window.location.origin + '/signin-callback',
  scope: 'openid profile QandAAPI email',
  audience: 'https://qanda',
};
