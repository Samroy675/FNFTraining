import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { FoodItem } from '../Models/food-item';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FoodItemService {
  url: string = "http://localhost:5104/api/FoodItems";
  constructor(private httpClient: HttpClient) {

  }
  public GetAllFoodItems(): Observable<FoodItem[]> {
    return this.httpClient.get<FoodItem[]>(this.url);
  }

  public GetFoodItemById(id: string): Observable<FoodItem> {
    const temp: string = `${this.url}/${id}`;
    return this.httpClient.get<FoodItem>(temp);
  }

  public AddFoodItem(item : FoodItem): Observable<FoodItem> {
    return this.httpClient.post(this.url, item) as Observable<FoodItem>;
  }

  public UpdateFoodItem(item: FoodItem): Observable<any> {
    const temp = `${this.url}/${item.ItemId}`;
    return this.httpClient.put(temp, item);
  }

  public DeleteFoodItem(id: number): Observable<any> {
    const temp = `${this.url}/${id}`;
    return this.httpClient.delete(temp);
  }

}
