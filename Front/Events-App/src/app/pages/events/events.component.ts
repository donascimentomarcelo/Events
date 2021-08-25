import { EventService } from './../../services/event.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss']
})
export class EventsComponent implements OnInit {

  public events = [];

  constructor(
    private eventService: EventService
  ) { }

  ngOnInit(): void {
    this.getEvents();
  }

  public getEvents(): void {
    this.eventService.getAll()
      .subscribe(resp => console.log(resp));
  }

}
