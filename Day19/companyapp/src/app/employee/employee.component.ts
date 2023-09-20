import { Component } from '@angular/core';
import { Employee } from './employee';
import { EmployeeService } from '../services/employee.service';
import { EmployeeWebService } from '../services/employeeweb.service';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent {
employee:Employee = new Employee()
className:string="";


constructor(private employeeService:EmployeeWebService){
  
}

addEmployee(){
  this.className= "spinner-border";
  // this.employeeService.addEmployee(this.employee);
  this.employeeService.addEmployee(this.employee).subscribe(data=>{
    this.employee = data as Employee;
    if(this.employee.id>0)
      alert("The emloyee has been added");
      this.className= "";
  },
  (err)=>{
      console.log(err);
  })
  this.employee = new Employee();
}
changeId(eid:any){
  this.employee.id=eid;
}

}
