namespace ServerSide.Services
{
    public class InMemoryStateService
    {
        private readonly Dictionary<string, bool> _userSessions = new();

        public bool TryGetSession(string userId, out bool isVerified)
        {
            if (string.IsNullOrEmpty(userId))
            {
                isVerified = false;
                return false;
            }
            return _userSessions.TryGetValue(userId, out isVerified);
        }

        public void SetSession(string userId, bool isVerified)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                _userSessions[userId] = isVerified;
            }
        }

        public void ClearSession(string userId)
        {
            if (!string.IsNullOrEmpty(userId))
            {
                // Remove the session for this user
                _userSessions.Remove(userId);
            }
        }

        // This method can be used for debugging or admin purposes
        public void ClearAllSessions()
        {
            _userSessions.Clear();
        }
    }
}