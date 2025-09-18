import { Component, OnInit } from '@angular/core';
import { FoodItemService } from '../../Services/food-item-service';
import { FoodItem } from '../../Models/food-item';

@Component({
  selector: 'app-menu',
  standalone: false,
  templateUrl: './menu.html',
  styleUrls: ['./menu.css']
})
export class Menu implements OnInit {
  items: FoodItem[] = [];

  constructor(private foodItemService: FoodItemService) {}

  ngOnInit(): void {
    this.foodItemService.GetAllFoodItems().subscribe({
      next: (data) => {
        this.items = data;
      },
      error: (err) => {
        console.error('Error fetching food items:', err);
      }
    });
  }
}
