import { Input,Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  @Input() imageUrl:string;
  @Input() title:string;
  @Input() text:string;
  constructor() { }

  ngOnInit() {
  }

}
