import { Employee } from "../employee/employee";

export class EmployeeService{
    employees:Employee[];
    constructor(){
        this.employees =[
          new Employee(101,"Ramu",24),
          new Employee(102,"Somu",41)
        ];
      }
      getEmployees(){
        return this.employees;
      }

      addEmployee(employee:Employee){
        this.employees.push(employee);
      }


      deleteEmployee(eid:number){
        var eidx;
        for (let index = 0; index < this.employees.length; index++) {
                if(this.employees[index].id==eid)
                {
                    eidx = index;
                    break;
                }
        }
        this.employees.splice(eidx??-1,1)
      }

      getEmployee(eid:number):any{
        var eidx:number=-1;
        for (let index = 0; index < this.employees.length; index++) {
                if(this.employees[index].id==eid)
                {
                    eidx = index;
                    break;
                }
        }
        if(eidx != -1)
            return this.employees[eidx];
      }
}