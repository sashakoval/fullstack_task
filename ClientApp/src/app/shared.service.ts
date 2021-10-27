import { Injectable } from '@angular/core';
import { HttpClient, HttpClientModule } from "@angular/common/http";
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl = "https://localhost:5001/api";
  constructor(private http:HttpClient) { }

  getEmpList():Observable<any[]>{
   return this.http.get<any>(this.APIUrl+'/employee');
 }
 
 getEmpById(val:number):Observable<any[]> {
   return this.http.get<any>(this.APIUrl+`/employee/${val}`)
 }

  addEmployee(val:number) {
    return this.http.post(this.APIUrl+'/employee', val);
  }

  updateEmployee(val:number, obj:object){
    return this.http.put(this.APIUrl+`/employee/${val}`, obj);
  }

  deleteEmployee(val:number){
    return this.http.delete(this.APIUrl+`/employee/${val}`);
  }

  deleteAllEmployees(){
    return this.http.delete(this.APIUrl+'/employee')
  }
}