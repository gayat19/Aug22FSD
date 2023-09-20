import { Component } from '@angular/core';
import { Employee } from '../employee/employee';
import { EmployeeService } from '../services/employee.service';
import { EmployeeWebService } from '../services/employeeweb.service';


@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent {
  employees:Employee[]=[];
  
  constructor(private employeeService:EmployeeWebService){
    this.employeeService.getEmployees().subscribe(data=>{
      //console.log(data)
      this.employees = data as Employee[];
    })
  }



}
