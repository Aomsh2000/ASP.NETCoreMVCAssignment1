using Microsoft.AspNetCore.Mvc;
using TechJobPortal.Models;
using System.Collections.Generic;
using System.Linq;


namespace TechJobPortal.Controllers
{
   public class JobListingController : Controller
   {
       private static List<JobListing> _jobs = new List<JobListing>
       {
           new JobListing
        {
            id = 1,
            title = "Software Developer",
            companyName = "Tech Solutions Inc.",
            location = "San Francisco, CA",
            type = JobListing.jobType.FullTime,   
            postedDate = DateTime.Now
        },
           new JobListing
        {
           id = 2,
        title = "Mobile App Developer",
        companyName = "App Innovators",
        location = "Los Angeles, CA",
        type = JobListing.jobType.PartTime,
        postedDate = DateTime.Now
        },
           new JobListing
        {
            id = 3,
        title = "Frontend Developer",
        companyName = "Web Dev Corp",
        location = "Remote",
        type = JobListing.jobType.Remote,
        postedDate = DateTime.Now.AddDays(-1) 
        },
         new JobListing
        {
              id = 4,
        title = "Data Scientist",
        companyName = "Data Analytics Group",
        location = "New York, NY",
        type = JobListing.jobType.Contract,
        postedDate = DateTime.Now.AddDays(-5) 
        },
        
         new JobListing
        {
            id = 5,
        title = "Back-End Developer",
        companyName = "Backend Builders",
        location = "Chicago, IL",
        type = JobListing.jobType.FullTime,
        postedDate = DateTime.Now.AddDays(-7)
        },
        
        

       };


       // 🟢 READ: Display all jobs
       public IActionResult Index()
       {
           return View(_jobs);
       }


     public IActionResult Details(int id)
{
    var job = _jobs.FirstOrDefault(j => j.id == id);
    
    // If no job is found, return NotFound()
    if (job == null)
    {
        return NotFound();
    }

    // Pass the job type options to the view
    ViewBag.JobTypes = Enum.GetValues(typeof(JobListing.jobType)).Cast<JobListing.jobType>().ToList();
    
    // Return the job object to the Details view
    return View(job);
}



      /*  // 🟢 CREATE: Show form
       public IActionResult Create()
       {
           return View();
       }


       // 🟢 CREATE: Add product
       [HttpPost]
       public IActionResult Create(JobListing job)
       {
           if (ModelState.IsValid)
           {
               job.id = _jobs.Max(p => p.id) + 1;
               _jobs.Add(job);
               return RedirectToAction("Index");
           }
           return View(job);
       }


       // 🟢 UPDATE: Show edit form
       public IActionResult Edit(int id)
       {
           var job = _jobs.FirstOrDefault(p => p.id == id);
           if (job == null) return NotFound();
           return View(job);
       }


       // 🟢 UPDATE: Save changes
       [HttpPost]
       public IActionResult Edit(JobListing updatedjob)
       {
           if (ModelState.IsValid)
           {
               var existingJob = _jobs.FirstOrDefault(p => p.id == updatedjob.id);
               if (existingJob == null) return NotFound();


              // existingJob.Name = updatedjob.Name;
             //  existingJob.price = updatedjob.price;


               return RedirectToAction("Index");
           }
           return View(updatedjob);
       }


       // 🟢 DELETE: Show confirmation page
       public IActionResult Delete(int id)
       {
           var job = _jobs.FirstOrDefault(p => p.id == id);
           if (job == null) return NotFound();
           return View(job);
       }


       // 🟢 DELETE: Remove product
       [HttpPost]
       public IActionResult DeleteConfirmed(int id)
       {
           var job = _jobs.FirstOrDefault(p => p.id == id);
           if (job == null) return NotFound();


           _jobs.Remove(job);
           return RedirectToAction("Index");
       } */
   }
}
