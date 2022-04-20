import { Component } from '@angular/core';
import { Repository } from './models/repository';
import { Book } from './models/book.model';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent {
  constructor(private repo: Repository) {}
  get book(): Book {
    return this.repo.book;
  }
}
