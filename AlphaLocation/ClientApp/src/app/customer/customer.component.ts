import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Customer } from './models/customer.model';
import { CreateCustomerDialogComponent } from './dialogs/create-customer-dialog/create-customer-dialog.component';
import { CustomerService } from './services/customer.service';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit {

  customers: Customer[];
  dialogRef: MatDialogRef<CreateCustomerDialogComponent>;
  customerCreatedSub: Subscription;

  constructor(
    private readonly customerService: CustomerService,
    private readonly matDialog: MatDialog,
  ) { }

  ngOnInit(): void {
    this.loadCustomersData();
  }
  private loadCustomersData(): void {
    this.customerService.GetCustomers()
      .subscribe({ next: (customers) => this.customers = customers });
  }

  public openCreateCustomerDialog(): void {
    this.dialogRef = this.matDialog.open(CreateCustomerDialogComponent);
    this.customerCreatedSub = this.dialogRef.componentInstance.customerCreated
      .subscribe({ next: (_) => this.loadCustomersData() });
  }
}
