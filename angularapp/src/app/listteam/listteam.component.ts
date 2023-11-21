import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-listteam',
  templateUrl: './listteam.component.html',
  styleUrls: ['./listteam.component.css']
})
export class ListteamComponent implements OnInit {

  constructor(private route:Router,private ar:ActivatedRoute) { }

  ngOnInit(): void {
  }
  getStarted()
  {
    
  }

}
