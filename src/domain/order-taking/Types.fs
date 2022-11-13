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

type CustomerInf = Undefined
type ShippingAddress = Undefined
type BillingAddress = Undefined
type OrderLine = Undefined
type BillingAmount = Undefined

type Order =
    { CustoomerInfo: CustomerInfo
      ShippingAddress: ShippingAddress
      BillingAddress: BillingAddress
      OrderLines: OrderLine list
      AmountToBill: BillingAmount }
