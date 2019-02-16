import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import {MatListModule} from '@angular/material/list';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { FlexLayoutModule } from '@angular/flex-layout';

import { AppComponent } from './app.component';
import { JwtHelperService } from '@auth0/angular-jwt';
import { HomeComponent } from './home/home.component';
import { EmployeeComponent } from './employee/employee.component';

@NgModule({
   declarations: [
      AppComponent,
      HomeComponent,
      EmployeeComponent
   ],
   imports: [
      BrowserModule,
      MatListModule,
      BrowserAnimationsModule,
      FlexLayoutModule
   ],
   providers: [
      JwtHelperService
   ],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
