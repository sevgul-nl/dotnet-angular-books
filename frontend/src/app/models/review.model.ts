export class Review {
  constructor(
    public reviewId?: number,
    public bookId?: number,
    public author?: string,
    public comment?: string,
    public rating?: string
  ) {}
}
