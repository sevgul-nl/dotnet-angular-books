import { Subject } from './subject.model';
import { Rating } from './rating.model';
import { Review } from './review.model';
export class Book {
  constructor(
    public bookId?: number,
    public title?: string,
    public author?: string,
    public rating?: number,
    public review?: Review,
    public subject?: Subject,
    public ratings?: Rating[]
  ) {}
}
