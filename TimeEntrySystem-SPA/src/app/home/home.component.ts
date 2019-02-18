import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employee.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  employees: any;
  public now: Date = new Date();

  constructor(private employeeService: EmployeeService) { 
    setInterval(() => {
      this.now = new Date();
    }, 1);
  }

  ngOnInit() {
    this.getEmployees();
  }

  getEmployees() {
    this.employeeService.getEmployees().subscribe(response => {
      this.employees = response;
      console.log(this.employees);
    }, error => {
      console.log(error);
    });
  }

}
