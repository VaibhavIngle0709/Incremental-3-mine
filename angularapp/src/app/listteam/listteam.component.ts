import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Team } from 'src/models/team.model';
import { AdminService } from '../services/admin.service';
import { ExecException, ExecOptions } from 'child_process';

@Component({
  selector: 'app-listteam',
  templateUrl: './listteam.component.html',
  styleUrls: ['./listteam.component.css']
})
export class ListteamComponent implements OnInit {

  constructor(private as:AdminService,private route:Router,private ar:ActivatedRoute) { }

  ngOnInit(): void {
  }
  getStarted()
  {
    this.route.navigate(['createteam'])
  }


}
