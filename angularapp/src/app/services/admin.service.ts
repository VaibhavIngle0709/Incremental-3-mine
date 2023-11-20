import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  PlayerUrl="https://8080-ffbabdadcfacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin/"

  constructor(private httpclient:HttpClient) { }

  getPlayers():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.PlayerUrl+"GetPlayers");
  }
  
}
