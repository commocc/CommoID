namespace Commo.Id.WebHost.Contracts;

/// <summary>
/// Request to get user personalities in a community
/// </summary>
public class GetPersonalityRequest
{
    /// <summary>
    /// Identifier of a community the user is going to participate at
    /// </summary>
    public string CommunityId { get; set; }

    /// <summary>
    /// User's public key that was used to encrypt the personalities
    /// </summary>
    public string[] PublicKeys { get; set; }
}

/// <summary>
/// Holds the new token
/// </summary>
public class GetPersonalityResponse
{
    /// <summary>
    /// The new token a user can use to participate in a community
    /// </summary>
    public string[] Tokens { get; set; }
}

/// <summary>
/// Forces to create a new personality even if one already exists
/// </summary>
public class PostPersonalityRequest
{
    /// <summary>
    /// Identifier of a community the user is going to participate at
    /// </summary>
    public string CommunityId { get; set; }

    /// <summary>
    /// User's public key that should be used to encrypt the personality token
    /// </summary>
    public string PublicKey { get; set; }
}


/// <summary>
/// Update personality information and settings
/// </summary>
public class PutPersonalityRequest
{
    public string CommunityId { get; set; }
}