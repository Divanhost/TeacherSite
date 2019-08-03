import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-cardholder',
  templateUrl: './cardholder.component.html',
  styleUrls: ['./cardholder.component.css']
})
export class CardholderComponent implements OnInit {
  items = [{url:"../assets/i/student-ico.png",text:"Студентам"},
          {url:"../assets/i/student-ico.png",text:"Практика"},
          {url:"../assets/i/student-ico.png",text:"Подготовка к ЕГЭ"},
          {url:"../assets/i/student-ico.png",text:"Обо мне"}];

  constructor() { }

  ngOnInit() {
  }

}
