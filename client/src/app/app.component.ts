import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  title = 'Dating App';

  users: any;

  ngOnInit(): void {
    this.http.get("https://localhost:44335/api/users")
    .subscribe(
      response =>{
        this.users = response
        console.log(this.users)
      },error=>{
        console.log(error)
      }
    );
  }

  constructor(private http: HttpClient) {

  }
}