import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Team } from 'src/models/team.model';


@Injectable({
  providedIn: 'root'
})
export class AdminService {

  AdminUrl="https://8080-ffbabdadcfacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin/"
  TeamUrl="https://8080-ffbabdadcfacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Team/"

  constructor(private httpclient:HttpClient) { }

 //get all players
  getPlayers():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.AdminUrl+"GetPlayers");
  }

  createTeam(t:Team)
  {
    return this.httpclient.post<any[]>(this.TeamUrl+"CreateTeam",t);
  }
  getTeams():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.AdminUrl+"GetTeams");
  }
  
  
}
