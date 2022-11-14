namespace OrderTaking.Types

type WidgetCode = string
type GizimoCode = string
type UnitQuantity = int
type KilogramQuantity = decimal

type ProductCode =
    | WidgetCode
    | GizimoCode

type OrderQuantity =
    | UnitQuantity
    | KilogramQuantity


type Undefined = exn

type CustomerInfo = Undefined
type ShippingAddress = Undefined
type BillingAddress = Undefined
type BillingAmount = Undefined

type OrderId = Undefined
type ProductId = Undefined

[<NoEquality; NoComparison>]
type OrderLine = {
    OrderId: OrderId
    ProductId: ProductId
    Qty: int
}
with
    member this.Key = 
        (this.OrderId, this.ProductId)

type Order ={ 
    CustoomerInfo: CustomerInfo
    ShippingAddress: ShippingAddress
    BillingAddress: BillingAddress
    OrderLines: OrderLine list
    AmountToBill: BillingAmount }

type QuoteForm = Undefined
type OrderForm = Undefined

type EnvelopeContents = string
type CateforizedMail = Quote of QuoteForm | Order of OrderForm

type UnvalidatedOrder = Undefined
type ValidatedOrder = Undefined

type ValidationResponse<'a> = Async<Result<'a, ValidationError>>
and ValidationError = {
    FieldName: string
    ErrorDescription: string
}

type ValidateOrder = UnvalidatedOrder -> ValidationResponse<ValidatedOrder>

type ContactId = string
type PhoneNumber = string
type EmailAddress = string

[<NoEquality; NoComparison>]
type Contact = {
    ContactId: ContactId
    PhoneNumber: PhoneNumber
    EmailAddress: EmailAddress
}

