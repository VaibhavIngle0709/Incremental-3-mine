import { Component, OnInit } from '@angular/core';
import { Player } from 'src/models/player.model';
import { AdminService } from '../services/admin.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-createplayer',
  templateUrl: './createplayer.component.html',
  styleUrls: ['./createplayer.component.css']
})
export class CreateplayerComponent implements OnInit {
player:Player={name:'',age:0,category:'',biddingPrice:0}
  constructor(private as:AdminService,private route:Router) { }

  ngOnInit(): void {

  }
  createPlayer(p:Player)
  {
    this.as.createPlayer(p).subscribe(()=>{alert("Player Record Added Successfully"); this.route.navigate(['listplayer'])})
  }

}
