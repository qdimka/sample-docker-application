import {Component, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {ActivatedRoute, Route, Router} from '@angular/router';

@Component({
  templateUrl: './event-details.component.html',
  styleUrls: ['./event-details.component.sass']
})
export class EventDetailsComponent implements OnInit {
  event: any;
  ngOnInit(): void {
    this.http.get(`/api/events/details/${this.getEventId()}`)
      .subscribe(data => this.event = data);
  }
  constructor(protected http: HttpClient,
              protected route: ActivatedRoute) {}
  getEventId() {
    return this.route.snapshot.paramMap.get('id');
  }
}
