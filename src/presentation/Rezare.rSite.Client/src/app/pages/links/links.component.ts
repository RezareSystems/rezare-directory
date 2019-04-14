import { Component } from '@angular/core';

@Component({
  templateUrl: 'links.component.html',
  styleUrls: [ './links.component.scss' ]
})

export class LinksComponent {
  links = [
    {
      uri: "https://www.google.co.nz",
      name: "Google",
      description: "Search engine"
    }
  ];
  
  constructor() {}
}
