import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Customer } from '../../models/customer.model';
import { SimpleDate } from '../../models/simple-date.model';
import { CustomerService } from '../../services/customer.service';

// Depending on whether rollup is used, moment needs to be imported differently.
// Since Moment.js doesn't have a default export, we normally need to import using the `* as`
// syntax. However, rollup creates a synthetic default module and we thus need to import it using
// the `default as` syntax.
import * as _moment from 'moment';

const moment = _moment;

@Component({
  selector: 'app-create-customer-dialog',
  templateUrl: './create-customer-dialog.component.html',
  styleUrls: ['./create-customer-dialog.component.css']
})
export class CreateCustomerDialogComponent implements OnInit {


  formGroup: FormGroup;
  titleAlert: string;
  constructor(
    private formBuilder: FormBuilder,
    private readonly customerService: CustomerService,
  ) { }

  ngOnInit() {
    this.createForm();
  }

  private createForm(): void {
    this.formGroup = this.formBuilder.group({
      'gender' : [null, [Validators.required]],
      'firstname' : [null, [Validators.required]],
      'lastname' : [null, [Validators.required]],
      'birthdate' : null,
      'comment' : null,
    });
  }

  onSubmit(): void {

    const customer: Customer = {
      gender: +this.formGroup.value.gender,
      firstname: this.formGroup.value.firstname,
      lastname: this.formGroup.value.lastname,
      comment: this.formGroup.value.comment,
      birthdate: this.getBirthdate(this.formGroup.value.birthdate)
    };

    this.customerService.CreateCustomer(customer)
      .subscribe();
  }
  private getBirthdate(date: Date): SimpleDate {
    if (!date) {
      return null;
    }
    const momentDate = moment(date);
    return {
      year: momentDate.year(),
      month: momentDate.month(),
      day: momentDate.day()
    };
  }
}
