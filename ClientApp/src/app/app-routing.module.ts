import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import {EmployeeComponent} from './employee/employee.component';
import { HomeComponent } from './home/home.component';
import { AddEmployeeComponent } from './employee/add-employee/add-employee.component';


const routes: Routes = [
{path:'employee',component:EmployeeComponent},
{path:'home',component:HomeComponent},
{path:'add-employee',component:AddEmployeeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }