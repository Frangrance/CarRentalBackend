# Rent A Car | kutaykeles@msn.com | [Linkedin](https://www.linkedin.com/in/kutay-keleş-17227561/ "Linkedin")

#### Kurumsal katmanlı mimari yapısı ile C# dilinde kodlanmıştır. Araba kiralama projesinin backend kısmıdır.
### Frontend kısmı için : [Frontend](https://github.com/Frangrance/RentACarFront)

# Katmanlar

- **Core**: Projenin çekirdek katmanıdır. Diğer projelerde de kullanılabilinir.
- **DataAccess**: Projenin veritabanı ile bağlantı kurduğu katmandır.
- **Entities**: Veritabanındaki nesnelerimizi yazdığımız katmandır.
- **Business**: İş katmandır. İş kuralları burada yazılır.
- **WebAPI**: API Katmanıdır. Get, post, delete, put işlemleri bu katmanda yazılır. 

### 1) Business
#### Concrete 
1. [CarManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/CarManager.cs)
2. [BrandManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/BrandManager.cs)
3. [ColorManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/ColorManager.cs)
4. [CustomerManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/CustomerManager.cs)
5. [UserManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/UserManager.cs)
6. [RentalManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/RentalManager.cs)
7. [CardManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/CardManager.cs)
8. [AuthManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/AuthManager.cs)
9. [CarImageManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/CarImageManager.cs)
10. [CreditCardManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/CreditCardManager.cs)
11. [UserManager.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Concrete/UserManager.cs)
  
#### Abstract 
1. [ICarService.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Abstract/ICarService.cs)
2. [IBrandService.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Abstract/IBrandService.cs)
3. [IColorService.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Abstract/IColorService.cs)
4. [ICustomerService.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Abstract/ICustomerService.cs)
5. [IUserService.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Abstract/IUserService.cs)
6. [IRentalService.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Abstract/IRentalService.cs)

#### Constants 
1. [Messages.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/Constants/Messages.cs)

#### DependencyResolvers
1. [AutofacBusinessModule.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/DependencyResolvers/Autofac/AutofacBusinessModule.cs)

#### FluentValidation
1. [CarValidator.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/ValidationRules/FluentValidation/CarValidator.cs)
2. [RentalValidator.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/ValidationRules/FluentValidation/RentalValidator.cs)
3. [UserValidator.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Business/ValidationRules/FluentValidation/UserValidator.cs)


### 2) DataAccess 
#### EntityFramework
1. [EfCarDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Concrete/EntityFramework/EfCarDal.cs)
2. [EfBrandDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Concrete/EntityFramework/EfBrandDal.cs)
3. [EfColorDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Concrete/EntityFramework/EfColorDal.cs)
4. [EfCustomerDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Concrete/EntityFramework/EfCustomerDal.cs)
5. [EfUserDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Concrete/EntityFramework/EfUserDal.cs)
6. [EfRentalDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Concrete/EntityFramework/EfRentalDal.cs)
7. [RentACarDbContext.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Concrete/EntityFramework/RentACarDbContext.cs)

#### Abstract 
1. [ICarDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Abstract/ICarDal.cs)
2. [IBrandDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Abstract/IBrandDal.cs)
3. [IColorDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Abstract/IColorDal.cs)
4. [ICustomerDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Abstract/ICustomerDal.cs)
5. [IUserDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Abstract/IUserDal.cs)
6. [IRentalDal.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Abstract/IRentalDal.cs)
7. [IEntityRepository.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/DataAccess/Abstract/IEntityRepository.cs)

### 3) Entities
#### Concrete 
1. [Car.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Concrete/Car.cs)
2. [Brand.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Concrete/Brand.cs)
3. [Color.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Concrete/Color.cs)
4. [Customer.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Concrete/Customer.cs)
5. [User.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Concrete/User.cs)
6. [Rental.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Concrete/Rental.cs)

#### Abstract
1. [IEntity.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Abstract/IEntity.cs)

#### DTOs
1. [CarDetailDto.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Abstract/CarDetailDto.cs)
2. [RentalDetailDto.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Entities/Abstract/RentalDetailDto.cs)

### 4) Core 
#### DataAccess
1. [IEntityRepository.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/DataAccess/IEntityRepository.cs)
2. [EfEntityRepositoryBase.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/DataAccess/EntityFramework/EfEntityRepositoryBase.cs)

#### Entities
1. [IDto.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/Entities/IDto.cs)
2. [IEntity.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/Entities/IEntity.cs)

#### Utilities
##### Interceptors
1. [AspectInterceptorSelector.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/Utilities/Interceptors/AspectInterceptorSelector.cs)
2. [MethodInterception.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/Utilities/Interceptors/MethodInterception.cs)
3. [MethodInterceptionBaseAttribute.cs](https://github.com/Frangrance/CarRentalBackendProjectt/blob/master/Core/Utilities/Interceptors/MethodInterceptionBaseAttribute.cs)

#### CrossCuttingConcerns
1. [ValidationTool.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/CrossCuttingConcerns/Validation/ValidationTool.cs)


#### Aspects
1. [ValidationAspect.cs](https://github.com/Frangrance/CarRentalBackendProject/blob/master/Core/Aspects/Autofac/Validation/ValidationAspect.cs)

