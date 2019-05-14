using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Videos.Models;

namespace Videos.Controllers
{
    public class VideosController : ApiController
    {

        private VideoDb db;

        public VideosController()
        {
            db = new VideoDb();
            //proxy y entity change tracking a lazy loading
            db.Configuration.ProxyCreationEnabled = false;
        }

        // GET api/videos
        public IEnumerable<Video> GetAllVideos()
        {
            //este videos viene del entity framework y el se encarga de todo
            return db.Videos;
        }

        // GET api/videos/5
        public Video GetVideo(int id)
        {
            var video = db.Videos.Find(id);
            if (video == null)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotFound));
            }

            return video;
        }

        // POST api/videos
        public HttpResponseMessage PostVideo(Video video)
        {
            if (ModelState.IsValid)
            {
                db.Videos.Add(video);
                db.SaveChanges();

                HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, video);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = video.Id }));
                return response;
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }


        // PUT api/videos/5
        public HttpResponseMessage PutVideo(int id, Video video)
        {
            if (ModelState.IsValid && id == video.Id)
            {
                db.Entry(video).State = EntityState.Modified;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateConcurrencyException)
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound);
                }

                return Request.CreateResponse(HttpStatusCode.OK, video);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
        }




        // DELETE api/videos/5
        public HttpResponseMessage DeleteVideo(int id)
        {
            Video video = db.Videos.Find(id);
            if (video == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            db.Videos.Remove(video);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

            return Request.CreateResponse(HttpStatusCode.OK, video);
        }

    }
}
