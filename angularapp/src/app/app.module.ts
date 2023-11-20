import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { AdminComponent } from './admin/admin.component';
import { PlayerComponent } from './player/player.component';
import { RegistrationComponent } from './registration/registration.component';
import { HomeComponent } from './home/home.component';
import { OrganizerComponent } from './organizer/organizer.component';
import { ErrorComponent } from './error/error.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    AdminComponent,
    PlayerComponent,
    RegistrationComponent,
    HomeComponent,
    OrganizerComponent,
    ErrorComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
