import { EmployeeService } from './../services/employee.service';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-employee',
  templateUrl: './employee.component.html',
  styleUrls: ['./employee.component.css']
})
export class EmployeeComponent implements OnInit {
  @Input() employee: any;

  constructor() { }

  ngOnInit() {

  }

}
