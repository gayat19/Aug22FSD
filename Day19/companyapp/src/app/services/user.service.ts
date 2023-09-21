import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { User } from "../login/user";

@Injectable()
export class UserService{
    constructor(private httpClient:HttpClient){

    }
    login(user:User){
       return this.httpClient.post("http://localhost:5159/api/User/Login",user);
    }
}