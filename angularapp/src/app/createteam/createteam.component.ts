import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-createteam',
  templateUrl: './createteam.component.html',
  styleUrls: ['./createteam.component.css']
})
export class CreateteamComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  createTeam(team:Team)
  {
    
    this.as.createTeam(team);
    this.route.navigate['listteam']
    
  }
}
