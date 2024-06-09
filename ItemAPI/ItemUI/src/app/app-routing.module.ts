import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login/login.component';
import { AppComponent } from './app.component';
import { ItemDetailsComponent } from './item-details/item-details.component';

const routes: Routes = [
  { path:  '', component:  LoginComponent},
  { path:  'app', component:  AppComponent},
  { path:  'item-details', component:  ItemDetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
