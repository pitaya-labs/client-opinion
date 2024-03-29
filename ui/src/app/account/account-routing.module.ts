import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CreateAccountComponent } from "./create-account/create-account.component";
import { LoginComponent } from "./login/login.component";

const routes: Routes = [
  {
    path: 'register',
    component: CreateAccountComponent
  },
  {
    path: 'login',
    component: LoginComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AccountRoutingModule { }
