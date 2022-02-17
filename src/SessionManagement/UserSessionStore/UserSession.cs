// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.

namespace Duende.SessionManagement;

/// <summary>
/// A user session
/// </summary>
public class UserSession
{
    /// <summary>
    /// The key
    /// </summary>
    public string Key { get; set; } = default!;

    /// <summary>
    /// The cookie handler scheme
    /// </summary>
    public string Scheme { get; set; } = default!;

    /// <summary>
    /// The subject ID
    /// </summary>
    public string SubjectId { get; set; } = default!;

    /// <summary>
    /// The session ID
    /// </summary>
    public string SessionId { get; set; } = default!;

    /// <summary>
    /// The display name for the user
    /// </summary>
    public string? DisplayName { get; set; }

    /// <summary>
    /// The creation time
    /// </summary>
    public DateTime Created { get; set; }

    /// <summary>
    /// The renewal time
    /// </summary>
    public DateTime Renewed { get; set; }

    /// <summary>
    /// The expiration time
    /// </summary>
    public DateTime? Expires { get; set; }

    /// <summary>
    /// The serialized ticket
    /// </summary>
    public string Ticket { get; set; } = default!;

    /// <summary>
    /// Clones the instance
    /// </summary>
    /// <returns></returns>
    internal UserSession Clone()
    {
        var item = new UserSession()
        {
            Key = Key,
            Scheme = Scheme,
            SubjectId = SubjectId,
            SessionId = SessionId,
            DisplayName = DisplayName,
            Created = Created,
            Renewed = Renewed,
            Expires = Expires,
            Ticket = Ticket,
        };
        return item;
    }
}
