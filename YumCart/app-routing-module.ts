import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { Search } from './Components/search/search';
import { Home } from './Components/home/home';
import { Menu } from './Components/menu/menu';
import { Cart } from './Components/cart/cart';


const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'home', component: Home },
  { path: 'menu', component: Menu },
  { path: 'cart', component: Cart },
  { path: 'search', component: Search }
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }




