import { HttpClient, HttpHeaders,HttpResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Player } from 'src/models/player.model';
import { Team } from 'src/models/team.model';



@Injectable({
  providedIn: 'root'
})
export class AdminService {

  AdminUrl="https://8080-ffbabdadcfacbbecabcdadeafbbdcaeafe.premiumproject.examly.io/Admin/"

  constructor(private httpclient:HttpClient) { }

  httpOptions={headers:new HttpHeaders({'Content-type':'application/json'})}
  //Create New Team
  createTeam(t:Team):Observable<Team>
  {
    return this.httpclient.post<Team>(this.AdminUrl+"PostTeam",t);
  }

  //Get All Teams
  getTeams():Observable<any[]>
  {
    return this.httpclient.get<any[]>(this.AdminUrl+"GetTeams");
  }

  editTeam(teamid:number,t:Team):Observable<Team>
  {
    return this.httpclient.put<Team>(this.AdminUrl+"PutTeam/"+teamid,t,this.httpOptions);
  }

  deleteTeam(teamid:number):Observable<Team>
  {
    return this.httpclient.delete<Team>(this.AdminUrl+"DeleteTeam/"+teamid)
  }

//-----------------------------------------------------------------------------------------------------------------

  ///////////////////////////////////////SERVICE PLAYER/////////////////////////////////

  //get all players
   getPlayers():Observable<any[]>
   {
     return this.httpclient.get<any[]>(this.AdminUrl+"GetPlayers");
   }
   createPlayer(p:Player):Observable<Player>
  {
    return this.httpclient.post<Player>(this.AdminUrl+"PostPlayer",p);
  }
  
  
}
