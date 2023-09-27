import { Component } from '@angular/core';
import { EmployeeWebService } from '../services/employeeweb.service';
import { Employee } from '../employee/employee';
import { Router } from '@angular/router';

@Component({
  selector: 'app-employeesdetail',
  templateUrl: './employeesdetail.component.html',
  styleUrls: ['./employeesdetail.component.css']
})
export class EmployeesdetailComponent {
employeename:string="";
employees:Employee[]=[]
constructor(private employeeService:EmployeeWebService,private router:Router){
    this.employeeService.getEmployees().subscribe(emps=>{
      this.employees = emps as Employee[];
    });
}

showData(data:any)
{
 console.log(data);
  this.router.navigate(["update",data])
}
}
