import { Component, OnInit } from '@angular/core';
import { ConferenceService } from './conference.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-conference',
  templateUrl: './conference.component.html',
  styleUrls: ['./conference.component.css']
})
export class ConferenceComponent implements OnInit {

  Conferences: Conference[];
  isDataLoaded = false;
  conf: Conference;

  constructor(private conferenceService: ConferenceService) {
    // this.getConferences();
  }

  ngOnInit() {
    this.conferenceService.resolveItems().subscribe({
      next: results => {
        this.Conferences = results;
      }
    });
  }

  getConferences() {
    this.conferenceService.resolveItems().subscribe(result => {
      this.Conferences = result;
      return result;
    });
  }
}
