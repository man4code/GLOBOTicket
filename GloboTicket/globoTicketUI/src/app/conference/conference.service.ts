import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
    providedIn: 'root'
})

export class ConferenceService {
    private readonly url = 'http://localhost:5000/api/Conference';

    constructor(private http: HttpClient) {
    }

    resolveItems(): Observable<any> {
        console.log('Request is sent!');
        // this.http is a HttpClient library provide by @angular/common
        // we are calling .get() method over this.http object
        // this .get() method takes URL to call API
        return this.http.get(this.url);
      }
}
