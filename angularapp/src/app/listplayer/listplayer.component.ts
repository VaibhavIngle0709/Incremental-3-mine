import { Component, OnInit } from '@angular/core';
import { Player } from 'src/models/player.model';
import { AdminService } from '../services/admin.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-listplayer',
  templateUrl: './listplayer.component.html',
  styleUrls: ['./listplayer.component.css']
})
export class ListplayerComponent implements OnInit {
players:Player[]
  constructor(private as:AdminService,private ar:ActivatedRoute,private route:Router) { }

  ngOnInit(): void {
    this.as.getAllPlayers().subscribe(data=>{this.players.push(...data)});
  }

}
