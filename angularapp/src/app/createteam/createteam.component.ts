import { Component, OnInit } from '@angular/core';
import { AdminService } from '../services/admin.service';
import { ActivatedRoute, Router } from '@angular/router';
import { Team } from 'src/models/team.model';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-createteam',
  templateUrl: './createteam.component.html',
  styleUrls: ['./createteam.component.css']
})
export class CreateteamComponent implements OnInit {
  teamData:Team
  constructor(private as:AdminService,private route:Router,private ar:ActivatedRoute) { }

  ngOnInit(): void {
  }

  createTeam(team:Team)
  {
    console.log(team)
   // this.as.createTeam(team);
    //this.route.navigate['listteam']
    
  }
}
