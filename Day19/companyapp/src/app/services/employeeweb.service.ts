import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Employee } from "../employee/employee";

@Injectable()
export class EmployeeWebService{

    constructor(private httpClient:HttpClient){

    }
    getToken():string{
        return "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJuYW1lIjoiZ2ltdSIsInJvbGUiOiJNYW5hZ2VyIiwibmJmIjoxNjk1MTg3MDQxLCJleHAiOjE2OTUyNzM0NDEsImlhdCI6MTY5NTE4NzA0MX0.Kr7Bd3kX-nY64nTR3DntaaKnWyDzfnpDuMsCb0I8Mtg";
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
}