using Microsoft.AspNetCore.Mvc;

namespace TF.Web.Controllers
{
    public class TFController : Controller
    {
        protected readonly BusinessLogic.BusinessLogic _businessLogic;

        public TFController()
        {
            _businessLogic = new BusinessLogic.BusinessLogic();
        }
    }
}
