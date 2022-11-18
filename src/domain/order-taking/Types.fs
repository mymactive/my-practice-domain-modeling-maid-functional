namespace OrderTaking.Domain

type WidgetCode = WidgetCode of string
    // constraint: starting with "W" then 4 digits
type GizimoCode = GizimoCode of string
    // constraint: starting with "G" then 3 digits
type ProductCode =
    | WidgetCode
    | GizimoCode

// Order Quantity related
type UnitQuantity = UnitQuantity of int
type KilogramQuantity = KilogramQuantity of decimal

type OrderQuantity =
    | UnitQuantity
    | KilogramQuantity

type Undefined = exn

type OrderId = Undefined
type OrderLineId = Undefined
type CustomerId = Undefined

type CustomerInfo = Undefined
type ShippingAddress = Undefined
type Price = Undefined
type BillingAddress = Undefined
type BillingAmount = Undefined

type Order ={ 
    CustoomerInfo: CustomerInfo
    ShippingAddress: ShippingAddress
    BillingAddress: BillingAddress
    OrderLines: OrderLine list
    AmountToBill: BillingAmount }
    and OrderLine = {
        id: OrderLineId
        OrderId : OrderId
        ProductCode: ProductCode
        OrderQuantity: OrderQuantity
        Price: Price
    }


type UnvalitatedOrder = Undefined
type ValidatedOrder = Undefined

type PlacedOrderEvents = {
    AnknowledgmentSent: Undefined
    OrderPlaced: Undefined
    BillableOrderPlaced: Undefined
}

type PlaceOrderError =
| ValidationError of ValidationError list
and ValidationError = {
    FieldName: string
    ErrorDescription: string
}

type PlaceOrder = UnvalitatedOrder -> Result<PlacedOrderEvents, PlaceOrderError>
