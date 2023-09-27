import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SecondComponent } from './second/second.component';
import { EmployeesComponent } from './employees/employees.component';
import { EmployeeComponent } from './employee/employee.component';
import { DeleteEmpComponent } from './delete-emp/delete-emp.component';
import { LoginComponent } from './login/login.component';
import { FirstComponent } from './first/first.component';
import { AuthGuard } from './services/auth.service';
import { MenuComponent } from './menu/menu.component';
import { OneComponent } from './one/one.component';
import { TwoComponent } from './two/two.component';
import { UpdateEmployeeComponent } from './update-employee/update-employee.component';

const routes: Routes = [
  {path:'menu',component:MenuComponent,children:[
    {path:'home',component:SecondComponent},
  {path:'employees',component:EmployeesComponent},
  {path:'add',component:EmployeeComponent,canActivate:[AuthGuard]},
  {path:'delete',component:DeleteEmpComponent,children:[
    {path:'first',component:FirstComponent}
  ]}
  ]},
  {path:'',component:LoginComponent},
  {path:'one',component:OneComponent},
  {path:'two/:g3',component:TwoComponent},
  {path:'update/:eid',component:UpdateEmployeeComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
