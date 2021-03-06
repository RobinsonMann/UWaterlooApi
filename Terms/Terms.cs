﻿/* By Robinson Mann 
 * Licensed under the MIT License, See LICENSE.txt for more information. */

using System.Collections.Generic;
using Newtonsoft.Json;

namespace UWaterlooApi.Terms
{

	/// <summary> "reserves" (Official Documentation) </summary> 
	public class Reserves
	{
		/// <summary> "Name of the reserved group" (Official Documentation) </summary> 
		[JsonProperty("reserve_group")]
		public string ReserveGroup { get; set; }

		/// <summary> "Total enrollment capacity of the group" (Official Documentation) </summary> 
		[JsonProperty("enrollment_capacity")]
		public int? EnrollmentCapacity { get; set; }

		/// <summary> "Total reserve enrollment" (Official Documentation) </summary> 
		[JsonProperty("enrollment_total")]
		public int? EnrollmentTotal { get; set; }
	}

	/// <summary> "date" (Official Documentation) </summary> 
	public class Date
	{
		/// <summary> "24 hour class starting time" (Official Documentation) </summary> 
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary> "24 hour class ending time" (Official Documentation) </summary> 
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary> "Weekdays the course is offered" (Official Documentation) </summary> 
		public string Weekdays { get; set; }

		/// <summary> "Additional starting date for course" (Official Documentation) </summary> 
		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		/// <summary> "Additional ending date for course" (Official Documentation) </summary> 
		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		/// <summary> "If the course schedule is TBA" (Official Documentation) </summary> 
		[JsonProperty("is_tba")]
		public bool? IsTba { get; set; }

		/// <summary> "If the course is cancelled for the term" (Official Documentation) </summary> 
		[JsonProperty("is_cancelled")]
		public bool? IsCancelled { get; set; }

		/// <summary> "If the course is closed for the term" (Official Documentation) </summary> 
		[JsonProperty("is_closed")]
		public bool? IsClosed { get; set; }
	}

	/// <summary> "location" (Official Documentation) </summary> 
	public class Location
	{
		/// <summary> "Name of the building" (Official Documentation) </summary> 
		public string Building { get; set; }

		/// <summary> "Room number from the building" (Official Documentation) </summary> 
		public string Room { get; set; }
	}

	/// <summary> "classes" (Official Documentation) </summary> 
	public class Classes
	{
		/// <summary> "Date object for course schedule" (Official Documentation) </summary> 
		public Date Date { get; set; }

		/// <summary> "Class location details" (Official Documentation) </summary> 
		public Location Location { get; set; }

		/// <summary> "Names of instructors teaching the course" (Official Documentation) </summary> 
		public IList<string> Instructors { get; set; }
	}

	/// <summary> "Subject Schedule by Term" (Official Documentation) </summary> 
	public class SubjectScheduleByTerm
	{
		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Credit count for the mentioned course" (Official Documentation) </summary> 
		public double? Units { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Additional notes regarding enrollment for the given term" (Official Documentation) </summary> 
		public string Note { get; set; }

		/// <summary> "Associated term specific class enrollment number" (Official Documentation) </summary> 
		[JsonProperty("class_number")]
		public int? ClassNumber { get; set; }

		/// <summary> "Class instruction and number" (Official Documentation) </summary> 
		public string Section { get; set; }

		/// <summary> "Name of the campus the course is being offered" (Official Documentation) </summary> 
		public string Campus { get; set; }

		/// <summary> "Associated class id" (Official Documentation) </summary> 
		[JsonProperty("associated_class")]
		public int? AssociatedClass { get; set; }

		/// <summary> "Name of the related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_1")]
		public string RelatedComponent1 { get; set; }

		/// <summary> "Name of the second related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_2")]
		public string RelatedComponent2 { get; set; }

		/// <summary> "Class enrollment capacity" (Official Documentation) </summary> 
		[JsonProperty("enrollment_capacity")]
		public int? EnrollmentCapacity { get; set; }

		/// <summary> "Total current class enrollment" (Official Documentation) </summary> 
		[JsonProperty("enrollment_total")]
		public int? EnrollmentTotal { get; set; }

		/// <summary> "Class waiting capacity" (Official Documentation) </summary> 
		[JsonProperty("waiting_capacity")]
		public int? WaitingCapacity { get; set; }

		/// <summary> "Total current waiting students" (Official Documentation) </summary> 
		[JsonProperty("waiting_total")]
		public string WaitingTotal { get; set; }

		/// <summary> "Class discussion topic" (Official Documentation) </summary> 
		public string Topic { get; set; }

		/// <summary> "Course specific enrollment reservation data" (Official Documentation) </summary> 
		public IEnumerable<Reserves> Reserves { get; set; }

		/// <summary> "Schedule data" (Official Documentation) </summary> 
		public IEnumerable<Classes> Classes { get; set; }

		/// <summary> "A list of classes the course is held with" (Official Documentation) </summary> 
		[JsonProperty("held_with")]
		public IEnumerable<string> HeldWith { get; set; }

		/// <summary> "4 digit term representation" (Official Documentation) </summary> 
		public int? Term { get; set; }

		/// <summary> "Undergraduate or graduate course classification" (Official Documentation) </summary> 
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }

		/// <summary> "ISO8601 timestamp of when the data was last updated" (Official Documentation) </summary> 
		[JsonProperty("last_updated")]
		public string LastUpdated { get; set; }
	}

	/// <summary> "Course Schedule by Term" (Official Documentation) </summary> 
	public class CourseScheduleByTerm
	{
		/// <summary> "Requested subject acronym" (Official Documentation) </summary> 
		public string Subject { get; set; }

		/// <summary> "Registrar assigned class number" (Official Documentation) </summary> 
		[JsonProperty("catalog_number")]
		public string CatalogNumber { get; set; }

		/// <summary> "Credit count for the mentioned course" (Official Documentation) </summary> 
		public double? Units { get; set; }

		/// <summary> "Class name and title" (Official Documentation) </summary> 
		public string Title { get; set; }

		/// <summary> "Additional notes regarding enrollment for the given term" (Official Documentation) </summary> 
		public string Note { get; set; }

		/// <summary> "Associated term specific class enrollment number" (Official Documentation) </summary> 
		[JsonProperty("class_number")]
		public int? ClassNumber { get; set; }

		/// <summary> "Class instruction and number" (Official Documentation) </summary> 
		public string Section { get; set; }

		/// <summary> "Name of the campus the course is being offered" (Official Documentation) </summary> 
		public string Campus { get; set; }

		/// <summary> "Associated class id" (Official Documentation) </summary> 
		[JsonProperty("associated_class")]
		public int? AssociatedClass { get; set; }

		/// <summary> "Name of the related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_1")]
		public string RelatedComponent1 { get; set; }

		/// <summary> "Name of the second related course component" (Official Documentation) </summary> 
		[JsonProperty("related_component_2")]
		public string RelatedComponent2 { get; set; }

		/// <summary> "Class enrollment capacity" (Official Documentation) </summary> 
		[JsonProperty("enrollment_capacity")]
		public int? EnrollmentCapacity { get; set; }

		/// <summary> "Total current class enrollment" (Official Documentation) </summary> 
		[JsonProperty("enrollment_total")]
		public int? EnrollmentTotal { get; set; }

		/// <summary> "Class waiting capacity" (Official Documentation) </summary> 
		[JsonProperty("waiting_capacity")]
		public int? WaitingCapacity { get; set; }

		/// <summary> "Total current waiting students" (Official Documentation) </summary> 
		[JsonProperty("waiting_total")]
		public string WaitingTotal { get; set; }

		/// <summary> "Class discussion topic" (Official Documentation) </summary> 
		public string Topic { get; set; }

		/// <summary> "Course specific enrollment reservation data" (Official Documentation) </summary> 
		public IEnumerable<Reserves> Reserves { get; set; }

		/// <summary> "Schedule data" (Official Documentation) </summary> 
		public IEnumerable<Classes> Classes { get; set; }

		/// <summary> "A list of classes the course is held with" (Official Documentation) </summary> 
		[JsonProperty("held_with")]
		public IList<string> HeldWith { get; set; }

		/// <summary> "4 digit term representation" (Official Documentation) </summary> 
		public int? Term { get; set; }

		/// <summary> "Undergraduate or graduate course classification" (Official Documentation) </summary> 
		[JsonProperty("academic_level")]
		public string AcademicLevel { get; set; }

		/// <summary> "ISO8601 timestamp of when the data was last updated" (Official Documentation) </summary> 
		[JsonProperty("last_updated")]
		public string LastUpdated { get; set; }
	}

	/// <summary> "Employer Info Sessions by Term" (Official Documentation) </summary> 
	public class EmployerInfoSessionsByTerm
	{
		/// <summary> "Information session id" (Official Documentation) </summary> 
		public int? Id { get; set; }

		/// <summary> "Name of employer hosting session" (Official Documentation) </summary> 
		public string Employer { get; set; }

		/// <summary> "Date of session" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Start time of session" (Official Documentation) </summary> 
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary> "End time of session" (Official Documentation) </summary> 
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary> "Location of session" (Official Documentation) </summary> 
		public string Location { get; set; }

		/// <summary> "Employer's website" (Official Documentation) </summary> 
		public string Website { get; set; }

		/// <summary> "Target audience of session" (Official Documentation) </summary> 
		public string Audience { get; set; }

		/// <summary> "Programs of study relevant to employer" (Official Documentation) </summary> 
		public string Programs { get; set; }

		/// <summary> "Description of employer" (Official Documentation) </summary> 
		public string Description { get; set; }
	}

	/// <summary> "sections" (Official Documentation) </summary> 
	public class Sections
	{
		/// <summary> "Exam section number" (Official Documentation) </summary> 
		public string Section { get; set; }

		/// <summary> "Day of the exam" (Official Documentation) </summary> 
		public string Day { get; set; }

		/// <summary> "ISO8601 exam date representation" (Official Documentation) </summary> 
		public string Date { get; set; }

		/// <summary> "Exam starting time" (Official Documentation) </summary> 
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary> "Exam ending time" (Official Documentation) </summary> 
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary> "Exam location" (Official Documentation) </summary> 
		public string Location { get; set; }

		/// <summary> "Additional notes regarding the section" (Official Documentation) </summary> 
		public string Notes { get; set; }
	}

	/// <summary> "Exam Schedule" (Official Documentation) </summary> 
	public class ExamSchedule
	{
		/// <summary> "Full course name (subject and catalog number)" (Official Documentation) </summary> 
		public string Course { get; set; }

		/// <summary> "Exam schedule for all sections of the course" (Official Documentation) </summary> 
		public IList<Sections> Sections { get; set; }
	}

	/// <summary> "{year}" (Official Documentation) </summary> 
	public class Term
	{
		/// <summary> "Term's numeric ID" (Official Documentation) </summary> 
		public int? Id { get; set; }

		/// <summary> "Parsed term name (human readable)" (Official Documentation) </summary> 
		public string Name { get; set; }
	}

	/// <summary> "listings" (Official Documentation) </summary> 
	public class Listings
	{
		/// <summary> "First item is previous year, second is current, last is next year" (Official Documentation) </summary> 
		[JsonProperty("2014")]
		public IList<Term> Year2014 { get; set; }

		/// <summary> "First item is previous year, second is current, last is next year" (Official Documentation) </summary> 
		[JsonProperty("2015")]
		public IList<Term> Year2015 { get; set; }

		/// <summary> "First item is previous year, second is current, last is next year" (Official Documentation) </summary> 
		[JsonProperty("2016")]
		public IList<Term> Year2016 { get; set; }
	}

	/// <summary> "Terms Listings" (Official Documentation) </summary> 
	public class TermsListings
	{
		/// <summary> "Current Term's numerical value" (Official Documentation) </summary> 
		[JsonProperty("current_term")]
		public int? CurrentTerm { get; set; }

		/// <summary> "Previous term's numerical value" (Official Documentation) </summary> 
		[JsonProperty("previous_term")]
		public int? PreviousTerm { get; set; }

		/// <summary> "Upcoming term's numerical value" (Official Documentation) </summary> 
		[JsonProperty("next_term")]
		public int? NextTerm { get; set; }

		/// <summary> "Term listings by year" (Official Documentation) </summary> 
		public Listings Listings { get; set; }
	}

	/// <summary> Terms Endpoints </summary> 
	public class TermsApi
	{

		// The Users University of Waterloo Open Data API Key
		private readonly string _apiKey;

		/// <summary> Default constructor </summary>
		/// <param name="apiKey">University of Waterloo Open Data API Key</param>
		public TermsApi(string apiKey)
		{
			_apiKey = apiKey;
		}

		/// <summary>
		/// Official Method Name: Terms Listings
		/// Description: This method returns the current, previous and next term's id along with a list of terms in the past year and the next year
		/// Update Frequency: On request
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<TermsListings> TermsListings()
		{
			return ApiRequest<TermsListings>.CreateApiRequest("/terms/list", _apiKey);
		}

		/// <summary>
		/// Official Method Name: Exam Schedule
		/// Description: This method returns a given term's exam schedule
		/// Update Frequency: Once a day
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<ExamSchedule>> ExamSchedule(int term)
		{
			return ApiRequest<List<ExamSchedule>>.CreateApiRequest(string.Format("/terms/{0}/examschedule", term), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Employer Info Sessions by Term
		/// Description: This method returns the schedule for employer information sessions of a given term
		/// Update Frequency: Weekly
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<EmployerInfoSessionsByTerm>> EmployerInfoSessionsByTerm(int term)
		{
			return ApiRequest<List<EmployerInfoSessionsByTerm>>.CreateApiRequest(string.Format("/terms/{0}/infosessions", term), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Course Schedule by Term
		/// Description: This method returns the class schedule for the given course of a given term
		/// Update Frequency: Every hour
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<CourseScheduleByTerm>> CourseScheduleByTerm(int term, string subject, string catalogNumber)
		{
			return ApiRequest<List<CourseScheduleByTerm>>.CreateApiRequest(string.Format("/terms/{0}/{1}/{2}/schedule", term, subject, catalogNumber), _apiKey);
		}

		/// <summary>
		/// Official Method Name: Subject Schedule by Term
		/// Description: This method returns all class schedule for the given subject for a given term
		/// Update Frequency: Every hour
		/// All the above information is from the Official Documentation
		/// </summary>
		public ApiRequest<List<SubjectScheduleByTerm>> SubjectScheduleByTerm(int term, string subject)
		{
			return ApiRequest<List<SubjectScheduleByTerm>>.CreateApiRequest(string.Format("/terms/{0}/{1}/schedule", term, subject), _apiKey);
		}

	}
}
