import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  baseUrl: string;
constructor(private http: HttpClient) {
  this.baseUrl = 'http://localhost:5000/api/';
}

getEmployees() {
  return this.http.get(this.baseUrl + 'employees');
}

}
