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

  addEmployee(val:any) {
    return this.http.post(this.APIUrl+'/employee', val);
  }

  updateEmployee(val:any){
    return this.http.put(this.APIUrl+'/employee', val);
  }

  deleteEmployee(val:any){
    return this.http.delete(this.APIUrl+'/employee', val);
  }
}