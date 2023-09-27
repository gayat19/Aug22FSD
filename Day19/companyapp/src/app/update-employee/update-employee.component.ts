import { Component } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';

import { EmployeeWebService } from '../services/employeeweb.service';

@Component({
  selector: 'app-update-employee',
  templateUrl: './update-employee.component.html',
  styleUrls: ['./update-employee.component.css']
})
export class UpdateEmployeeComponent {

  constructor(private activatedRoute:ActivatedRoute, 
    private router:Router,
    private employeeService:EmployeeWebService){

    }
  updateEmployee(){
      var id = this.activatedRoute.snapshot.params["eid"];
      this.employeeService.updateEmployee(id).subscribe(data=>{
        alert("Updated status");
        this.router.navigate([""]);
      })
  }
}
