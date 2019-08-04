import { Input,Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-post',
  templateUrl: './post.component.html',
  styleUrls: ['./post.component.css']
})
export class PostComponent implements OnInit {
  @Input() title:string;
  @Input() imageUrl:string;
  @Input() text:string;
  @Input() id?:number;
  constructor() { }

  ngOnInit() {
  }

}
