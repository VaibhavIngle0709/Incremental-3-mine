import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Observable, observable, of } from 'rxjs';
import { AuthService } from '../services/auth.service';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
username:FormControl
password:FormControl
loginform:FormGroup
  constructor(private router:Router,private authService:AuthService) {
    //this.username="admin"
    //this.password="password"

    this.loginform=new FormGroup(
      {
        this.username: FormControl('',Validators.required);
      }
    );
   }

  


  ngOnInit(): void {
  }
  login(): void {
    this.authService.login(this.username, this.password).subscribe(
      (response) => {
        if (response.role === 'ADMIN') {
          this.router.navigate(['/admin']);
        } else if (response.role === 'ORGANIZER') {
          this.router.navigate(['/organizer']);
        }
        // Handle other roles or scenarios if needed
      },
      (error) => {
        // Handle login error if needed
      }
    );
  }

}
