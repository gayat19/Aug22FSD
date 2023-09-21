import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SecondComponent } from './second/second.component';
import { EmployeesComponent } from './employees/employees.component';
import { EmployeeComponent } from './employee/employee.component';
import { DeleteEmpComponent } from './delete-emp/delete-emp.component';
import { LoginComponent } from './login/login.component';
import { FirstComponent } from './first/first.component';

const routes: Routes = [
  {path:'home',component:SecondComponent},
  {path:'employees',component:EmployeesComponent},
  {path:'add',component:EmployeeComponent},
  {path:'delete',component:DeleteEmpComponent,children:[
    {path:'first',component:FirstComponent}
  ]},
  {path:'login',component:LoginComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
