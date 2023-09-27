import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { FirstComponent } from './first/first.component';
import { SecondComponent } from './second/second.component';
import { ThirdComponent } from './third/third.component';
import { EmployeeComponent } from './employee/employee.component';
import { FormsModule } from '@angular/forms';
import { EmployeesComponent } from './employees/employees.component';
import { EmployeeService } from './services/employee.service';
import { DeleteEmpComponent } from './delete-emp/delete-emp.component';
import {HttpClientModule} from '@angular/common/http';
import { EmployeeWebService } from './services/employeeweb.service';
import { LoginComponent } from './login/login.component';
import { UserService } from './services/user.service';
import { AuthGuard } from './services/auth.service';
import { JwtModule } from '@auth0/angular-jwt';
import { MenuComponent } from './menu/menu.component';
import { EmployeedetailComponent } from './employeedetail/employeedetail.component';
import { EmployeesdetailComponent } from './employeesdetail/employeesdetail.component';
import { OneComponent } from './one/one.component';
import { TwoComponent } from './two/two.component';
import { UpdateEmployeeComponent } from './update-employee/update-employee.component';

export function tokenGetter(){
  return sessionStorage.getItem("token");
}

@NgModule({
  declarations: [
    AppComponent,
    FirstComponent,
    SecondComponent,
    ThirdComponent,
    EmployeeComponent,
    EmployeesComponent,
    DeleteEmpComponent,
    LoginComponent,
    MenuComponent,
    EmployeedetailComponent,
    EmployeesdetailComponent,
    OneComponent,
    TwoComponent,
    UpdateEmployeeComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    JwtModule.forRoot({
      config:{
        tokenGetter:tokenGetter,
        allowedDomains:["http://localhost:5159/"]
      }
    })
  ],
  providers: [EmployeeService,EmployeeWebService,UserService,AuthGuard],
  bootstrap: [AppComponent]
})
export class AppModule { }
