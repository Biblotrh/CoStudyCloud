﻿using CoStudyCloud.Core.Models;

namespace CoStudyCloud.Core.Repositories
{
    /// <summary>
    /// Represents StudyGroup repository interface
    /// </summary>
    public interface IStudyGroupRepository
    {
        /// <summary>
        /// Get all study groups with the status of being joined in the groups for the given user
        /// </summary>
        /// <param name="userId">User Id</param>
        /// <returns>All study groups with the join status for the given user</returns>
        Task<IEnumerable<StudyGroupWithJoinStatus>> GetStudyGroupsWithJoinStatus(string userId);

        /// <summary>
        /// Add a new study group
        /// </summary>
        /// <param name="studyGroup">StudyGroup</param>
        Task Add(StudyGroup studyGroup);

        /// <summary>
        /// Add a user to a study group
        /// </summary>
        /// <param name="userStudyGroup">UserStudyGroup</param>
        Task AddUserToStudyGroup(UserStudyGroup userStudyGroup);

        /// <summary>
        /// Remove a user from a study group
        /// </summary>
        /// <param name="userStudyGroupMappingId">The mapping Id used for mapping user and group</param>
        Task RemoveUserFromStudyGroup(string userStudyGroupMappingId);
    }
}
