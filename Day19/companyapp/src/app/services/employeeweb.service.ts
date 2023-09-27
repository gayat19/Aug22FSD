import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Employee } from "../employee/employee";

@Injectable()
export class EmployeeWebService{

    constructor(private httpClient:HttpClient){

    }
    getToken():string{
        var token = "";
        token = sessionStorage.getItem("token") as string;
        return token;

    }
    getEmployees(){
        return this.httpClient.get("http://localhost:5159/api/Employee");
    }

    addEmployee(employee:Employee){
        const header = new HttpHeaders({
            'Content-Type':'application/json',
            'Authorization':'Bearer '+this.getToken()
        });
        console.log(employee);
        const requestOptions = {headers:header};
        return this.httpClient.post("http://localhost:5159/api/Employee",employee,requestOptions);
    }
    deleteEmployee(eid:number){
        const header = new HttpHeaders({
            'Content-Type':'application/json',
            'Authorization':'Bearer '+this.getToken()
        });
        console.log(eid);
        const requestOptions = {headers:header};
        return this.httpClient.put("http://localhost:5159/api/Employee/UpdateStatus?id="+eid,requestOptions);
    }
    updateEmployee(eid:number){
        const header = new HttpHeaders({
            'Content-Type':'application/json',
            'Authorization':'Bearer '+this.getToken()
        });
        console.log(eid);
        const requestOptions = {headers:header};
        return this.httpClient.put("http://localhost:5159/api/Employee/UpdateStatus?id="+eid,requestOptions);
    }
}