import { HttpClient } from "@angular/common/http";
import { Inject } from "@angular/core";
import { Observable } from "rxjs";
import { Customer } from "../customers-table/customer.model";

export class CustomerService {

    constructor(
        private readonly http: HttpClient,
        @Inject('BASE_URL') private readonly baseUrl: string,
    ) { }

    public GetCustomers(): Observable<Customer[]> {
        return this.http.get<Customer[]>(this.baseUrl + 'api/customer');
    }
}