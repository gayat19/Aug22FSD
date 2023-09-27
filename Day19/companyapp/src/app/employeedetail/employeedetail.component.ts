import { Component, Input, Output, EventEmitter } from '@angular/core';
import { Employee } from '../employee/employee';


@Component({
  selector: 'app-employeedetail',
  templateUrl: './employeedetail.component.html',
  styleUrls: ['./employeedetail.component.css']
})
export class EmployeedetailComponent {
@Input()ename:string ="";
@Input()employee:Employee = new Employee();
@Output()checkCom:EventEmitter<number> = new EventEmitter<number>();

raiseEvent(){
  this.checkCom.emit(this.employee.id);
}

}
