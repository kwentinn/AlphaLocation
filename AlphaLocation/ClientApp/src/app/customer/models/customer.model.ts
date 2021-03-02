import { Gender } from './gender.enum';
import { SimpleDate } from './simple-date.model';

export interface Customer {
  firstname: string;
  lastname: string;
  gender: Gender;
  comment: string;
  birthdate: SimpleDate;
}
