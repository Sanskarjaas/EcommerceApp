export interface Pagination<T>{
    pagesize:number;
    pageIndex:number;
    count:number;
    data:T;
}