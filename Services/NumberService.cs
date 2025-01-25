using BlazorApi2.Models;

namespace BlazorApi2.Services;

public class NumberService{
    List<FavoriteNumberModel> listOfFavorites = new List<FavoriteNumberModel>();
    public List<FavoriteNumberModel> ListOfFavorites => listOfFavorites;

    public List<FavoriteNumberModel> AddFavoriteNumber(FavoriteNumberModel number){

     listOfFavorites.Add(number); 
     return listOfFavorites; 
    }

    public List<FavoriteNumberModel> RemoveFavoriteNumber(FavoriteNumberModel number){

     listOfFavorites.Remove(number); 
     return listOfFavorites; 
    }
}