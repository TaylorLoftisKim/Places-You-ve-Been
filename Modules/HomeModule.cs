using Nancy;
using Places.Objects;
using System.Collections.Generic;

namespace Places
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["add_new_place.cshtml"];
      Get["/view_all_places"] = _ => {
        List<Place> allPlaces = Place.GetAll();
        return View["view_all_places.cshtml", allPlaces];
      };
      Post["/place_added"] = _ => {
        Place newPlace = new Place (Request.Form["new-city"]);
        newPlace.Save();
        return View["place_added.cshtml", newPlace];
      };
      Post["places_cleared"] = _ => {
        Place.ClearAll();
        return View["places_cleared.cshtml"];
      };
    }
  }
}
