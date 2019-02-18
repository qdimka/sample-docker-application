import {Component, Inject, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Component({
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.sass']
})
export class EventsComponent {
    events: any;
    constructor(http: HttpClient) {
      http.get('/api/events').subscribe(result => {
        this.events = result;
      }, error => console.error(error));
    }
}
