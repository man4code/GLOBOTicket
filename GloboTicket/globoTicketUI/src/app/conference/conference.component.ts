import { Component, OnInit } from '@angular/core';
import { ConferenceService } from './conference.service';

@Component({
  selector: 'app-conference',
  templateUrl: './conference.component.html',
  styleUrls: ['./conference.component.css']
})
export class ConferenceComponent implements OnInit {

  constructor(private conferenceService: ConferenceService) {
    conferenceService.resolveItems().subscribe(result => {
      console.log(result);
    });
  }

  ngOnInit() {
  }

  getConferences() {
    this.conferenceService.resolveItems().subscribe(result => {
      console.log(result);
    });
  }
}
