import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../services/employee.service';
import { HubConnection, HubConnectionBuilder } from '@aspnet/signalr';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  employees: any;
  public now: Date = new Date();
  public hubConnection: HubConnection;
  xhr = new XMLHttpRequest();

  constructor(private employeeService: EmployeeService) {
    setInterval(() => {
      this.now = new Date();
    }, 1);
  }

  ngOnInit() {
    this.getEmployees();
    const builder = new HubConnectionBuilder();

    // as per setup in the startup.cs
    this.hubConnection = builder.withUrl('http://localhost:5000/hubs/entry').build();


    this.hubConnection.on('sendToAll', () => {
      this.getEmployees();
    });


    this.hubConnection.start()
                        .then(() => console.log('Connection started'))
                        .catch(error => console.log(error));
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
