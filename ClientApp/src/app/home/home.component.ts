import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {

  constructor(private service:SharedService) {}

  EmployeeList:any=[];

  ngOnInit(): void {
    this.refreshEmpList();
  }

  refreshEmpList(){
    this.service.getEmpList().subscribe(data=>{
      this.EmployeeList=data
    })
  }

  deleteClick(item) {
    if(confirm('Are you sure?')){
      this.service.deleteEmployee(item.EmployeeId).subscribe(data=>{
        alert(data.toString());
        this.refreshEmpList();
      })
    }
  }
  deleteAllClick() {
    if(confirm('Are you really want to delete all employees?')) {
      this.service.deleteAllEmployees().subscribe(data=>{
        alert(data.toString());
        this.refreshEmpList();
      })
    }
  }
}
