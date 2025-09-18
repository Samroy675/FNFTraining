import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  standalone: false,
  templateUrl: './home.html',
  styleUrl: './home.css'
})
export class Home {
 featuredItems = [
    {
      name: 'Burger',
      image: 'burger.jpg',
      price: 149.5,
      restaurant: 'Burger Hub',
      location: 'Chennai'
    },
    {
      name: 'Dosa',
      image: 'dosa.jpg',
      price: 99,
      restaurant: 'South Spice',
      location: 'Mysore'
    },
    {
      name: 'Alfredo Pasta',
      image: 'pasta.jpg',
      price: 200,
      restaurant: 'Italiano Spicy Kitchen',
      location: 'Hyderabad'
    }
  ];
}



