import { Component } from '@angular/core';
import { Employee } from '../employee/employee';
import { EmployeeWebService } from '../services/employeeweb.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-delete-emp',
  templateUrl: './delete-emp.component.html',
  styleUrls: ['./delete-emp.component.css']
})
export class DeleteEmpComponent {
  employee:Employee= new Employee();
  employees:Employee[]=[];
  constructor(private employeeService:EmployeeWebService,
    private router:Router){
    this.employeeService.getEmployees().subscribe(emp=>{
      this.employees = emp as Employee[];
    })
  }
  selectChange(eid:any){
    for (let index = 0; index < this.employees.length; index++) {
      if(this.employees[index].id==eid)
      {
        this.employee = this.employees[index];
        break;
      }
      
    }
  }

  deleteEmployee(){
    this.employeeService.deleteEmployee(this.employee.id).subscribe(emp=>{
      if(emp){
        alert("employee status changed")
      }
    })
    this.employee = new Employee();
  }
  show(){
    this.router.navigateByUrl("delete/first")
  }
}
