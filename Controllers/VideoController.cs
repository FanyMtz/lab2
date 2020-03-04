using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data;
using System.Data.SqlClient;
using MVCLaboratorio.Utilerias;

namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }

        //muestra la pantalla de create (que es la interfaz)
        public ActionResult Create()
        {
            return View();
        }
        //este retoma los datos y guarda del video(aqui estan las variables que el usuario ingreso)


        //decorador httpPost
        [HttpPost]
        public ActionResult Create(int idVideo, string titulo, int repro, string url)
        {
            //guardar el video
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@idVideo", idVideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_insertar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Index","Video");

        }


        public ActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int idVideo)
        {
            BaseHelper.ejecutarSentencia("Delete * from Video where idVideo=@idVideo", CommandType.Text);
            return View();
        }

        public ActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int idVideo, string titulo, int repro, string url)
        {
            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add
            return View();
        }
        public ActionResult Search()
        {
            return View();
        }

    [HttpPost]
        public ActionResult Search()
        {
            return View();
        }

        
    }
}
