import { Component, OnInit } from '@angular/core';
import { SharedService } from 'src/app/shared.service';
import { FormGroup, FormControl, FormBuilder } from '@angular/forms';
import { Validators } from '@angular/forms';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  employeeForm = this.fb.group({
    firstName: ['', [Validators.required, Validators.minLength(2)]],
    lastName: ['', Validators.required],
    taxId: ['', Validators.required],
    phoneNumber: ['', Validators.required],
    sex: ['', Validators.required],
    birthDate: [''],
    hobbies: ['']
  })

  constructor(private service:SharedService, private fb: FormBuilder) { }

  ngOnInit() {
  }

  

  onSubmit() {
    this.service.addEmployee(this.employeeForm.value).subscribe(()=>{
      alert("Employee added!");
    })
    console.warn(this.employeeForm.value);
    this.employeeForm.reset();
  }
}
