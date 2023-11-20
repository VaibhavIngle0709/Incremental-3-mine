import { Component, OnInit } from '@angular/core';
import { Observable, observable } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
username:string
password:string
  constructor() { }

  ngOnInit(): void {
  }

  login():Observable<{role:string}>
  {
    return new Observable(observable=>{
      const fakeApiResponse={role:'ORGANIZER'}
    });
  }

}
