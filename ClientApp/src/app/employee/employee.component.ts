import { Component, OnInit } from '@angular/core';
import { SharedService } from '../shared.service';
import { ActivatedRoute } from '@angular/router';
import { tap } from 'rxjs/operators';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';
import { Input } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  
  EmployeeList:any=[];

  employeeForm = this.fb.group({
    firstName: ['', [Validators.required, Validators.minLength(2)]],
    lastName: ['', Validators.required],
    taxId: ['', Validators.required],
    phoneNumber: ['', Validators.required],
    sex: ['', Validators.required],
    birthDate: [''],
    hobbies: ['']
  })

  

  constructor(
    private route: ActivatedRoute,
    private service: SharedService,
    private fb: FormBuilder 
  ) { }

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.service.getEmpById(id)
      .subscribe(data =>{
         this.EmployeeList = [data];
      });
  }

  onSubmit() {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.service.updateEmployee(id, this.employeeForm.value).subscribe(()=>{
      alert("Employee updated!");
    })
  }

}
