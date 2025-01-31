﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using TopLearn.Core.DTOs.Course;
using TopLearn.DataLayer.Entities.Course;

namespace TopLearn.Core.Services.Interfaces
{
    public interface ICourseService
    {
        #region Group

        List<CourseGroup> getAllGroup();
        List<SelectListItem> GetGroupForManageCourse();
        List<SelectListItem> GetSubGroupForManageCourse(int groupId);
        List<SelectListItem> GetTeachers();
        List<SelectListItem> GetLevels();
        List<SelectListItem> GetStatues();
        void AddGroup(CourseGroup group);
        void UpdateGroup(CourseGroup group);
        CourseGroup GetById(int groupId);
        void DeleteGroup(CourseGroup courseGroup);
        #endregion

        #region Course

        List<ShowCourseForAdminViewModel> GetCoursesForAdmin();
        int AddCourse(Course course,IFormFile imgCourse,IFormFile couresDemo);
        Course GetCourseById(int Id);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile couresDemo);
        Tuple<List<ShowCourseListItemViewModel>,int> GetCourse(int pageId=1,string filter="",string getType="all",string orderByType="date",int startPrice=0,int endPrice=0, List<int> selectedGroups = null, int take = 0);
        Course GetCourseForShow(int courseId);
        List<ShowCourseListItemViewModel> GetPopularCourse();
        int GetCourseCount();
        bool IsFree(int courseId);
  
        #endregion

        #region Episode

        List<CourseEpisode> GetListEpisodeCourse(int courseId);
        bool CheckExistFile(string fileName);
        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        CourseEpisode GetEpisodeById(int episodeId);
        void EditEpisode(CourseEpisode episode, IFormFile episodeFile);

        #endregion

        #region Comments

        void AddComment(CourseComment comment);
        Tuple<List<CourseComment>,int> GetCourseComment(int courseId,int pageId=1);

        #endregion

        #region Course Vote

        void AddVote(int userId, int courseId, bool vote);
        Tuple<int, int> GetCourseVotes(int courseId);

        #endregion
    }
}