import { Component } from '@angular/core';
import { EmployeeService } from '../services/employee.service';
import { Employee } from '../employee/employee';

@Component({
  selector: 'app-delete-emp',
  templateUrl: './delete-emp.component.html',
  styleUrls: ['./delete-emp.component.css']
})
export class DeleteEmpComponent {
  employee:Employee= new Employee();
  employees:Employee[];
  constructor(private employeeService:EmployeeService){
    this.employees = this.employeeService.getEmployees();
  }
  selectChange(eid:any){
    this.employee = this.employeeService.getEmployee(eid);
  }

  deleteEmployee(){
    this.employeeService.deleteEmployee(this.employee.id);
    this.employee = new Employee();
  }
}
