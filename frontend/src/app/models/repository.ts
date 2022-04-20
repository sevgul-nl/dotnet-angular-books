import { Book } from './book.model';
export class Repository {
  constructor() {
    this.book = JSON.parse(document?.getElementById('data')?.textContent);
  }
  book: Book;
}
