import { NgModule, provideBrowserGlobalErrorListeners } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing-module';
import { App } from './app';
import { Navbar } from './Components/navbar/navbar';
import { Home } from './Components/home/home';
import { Menu } from './Components/menu/menu';
import { Search } from './Components/search/search';
import { Cart } from './Components/cart/cart';

@NgModule({
  declarations: [
    App,
    Navbar,
    Home,
    Menu,
    Search,
    Cart
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [
    provideBrowserGlobalErrorListeners()
  ],
  bootstrap: [App]
})
export class AppModule { }
