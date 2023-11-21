import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Team } from 'src/models/team.model';
import { AdminService } from '../services/admin.service';

@Component({
  selector: 'app-listteam',
  templateUrl: './listteam.component.html',
  styleUrls: ['./listteam.component.css']
})
export class ListteamComponent implements OnInit {
  teamData:any[]=[]
  constructor(private as:AdminService,private route:Router,private ar:ActivatedRoute) { }

  ngOnInit(): void {
    this.as.getTeams().subscribe(data=>{this.teamData.push(...data)});
    console.log(this.teamData);``
  }
  getStarted()
  {
    this.route.navigate(['createteam'])
  }


}
